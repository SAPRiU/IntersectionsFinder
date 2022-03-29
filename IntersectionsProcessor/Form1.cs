namespace IntersectionsProcessor
{
    public partial class Form1 : Form
    {
        Models.SegmentsDBContext db;
        SegmentsProcessor segmentsProcessor;

        public Form1()
        {
            InitializeComponent();
            db = new Models.SegmentsDBContext();
            segmentsProcessor = new SegmentsProcessor();
            WindowState = FormWindowState.Maximized;
            LoadSets();
        }

        //Метод обрабатывает событие нажатия на кнопку "Создать новый набор"
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNumberOfSegments.Text, out _))
                return;

            //Создание и обработка набора отрезков
            segmentsProcessor.Generate(int.Parse(textBoxNumberOfSegments.Text));
            segmentsProcessor.SplitSegments();

            pictureInitialSegments.Invalidate();
            pictureSplittedSegments.Invalidate();
        }

        //Обработчики события отрисовки PictureBox
        private void pictureInitialSegments_Paint(object sender, PaintEventArgs e)
        {
            foreach (Segment segment in  segmentsProcessor.initialSegments)
            {
                e.Graphics.DrawLine(Pens.Black, segment.P1.X, segment.P1.Y, segment.P2.X, segment.P2.Y);
            }
        }

        private void pictureSplittedSegments_Paint(object sender, PaintEventArgs e)
        {

            foreach (Segment segment in segmentsProcessor.initialSegments)
            {
                if (!segment.IsSplitted)
                    e.Graphics.DrawLine(Pens.Black, segment.P1.X, segment.P1.Y, segment.P2.X, segment.P2.Y);
            }
            foreach (Segment segment in segmentsProcessor.terminalSegments)
            {
                e.Graphics.DrawLine(Pens.Red, segment.P1.X, segment.P1.Y, segment.P2.X, segment.P2.Y);
            }
        }

        //Метод производит сохранение данных в базу данных 
        private void buttonSaveInDB_Click(object sender, EventArgs e)
        {
            //Проверка корректности поля "Название набора"
            if (textBoxNameSet.Text.Trim() == String.Empty)
                return;
            if (segmentsProcessor.initialSegments.Count == 0)
                return;

            Models.Set set = new Models.Set();
            set.Name = textBoxNameSet.Text;

            db.Sets.Add(set);            

            //Добавление начального набора отрезков в базу данных
            Models.SegmentDBEntity segmentDB;
            foreach (Segment segment in segmentsProcessor.initialSegments)
            {
                segmentDB = new Models.SegmentDBEntity();
                segmentDB.StartX = segment.P1.X;
                segmentDB.StartY = segment.P1.Y;
                segmentDB.EndX = segment.P2.X;
                segmentDB.EndY = segment.P2.Y;
                segmentDB.IsSplitted = segment.IsSplitted;
                segmentDB.Set = set;
                db.Segments.Add(segmentDB);
                db.SaveChanges();
            }


            //Добавление пересечений в базу данных
            Models.Intersection intersection;
            foreach (Segment segment in segmentsProcessor.terminalSegments)
            {
                intersection = new Models.Intersection();
                intersection.StartX = segment.P1.X;
                intersection.StartY = segment.P1.Y;
                intersection.EndX = segment.P2.X;
                intersection.EndY = segment.P2.Y;
                intersection.Set = set;
                db.Intersections.Add(intersection);
                db.SaveChanges();
            }

            LoadSets();
            MessageBox.Show("Данные успешно сохранены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Метод извлекает список наборов из базы данных
        private void LoadSets()
        {
            var sets = db.Sets.ToList();
            comboBoxSets.Items.Clear();

            if (sets.Count > 0)
            {
                foreach (Models.Set set in sets)
                    comboBoxSets.Items.Add(set.Id + ". " + set.Name);
                comboBoxSets.SelectedIndex = 0;
            }

        }

        //Метод извлекает отрезки и их пересечения из базы данных
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSets.Text.Trim() == String.Empty)
                return;

            //Получение id набора и загрузка данных из базы данных
            int id = int.Parse(comboBoxSets.Text.Substring(0, comboBoxSets.Text.IndexOf('.')));
            var set = db.Sets.Find(id);
            db.Entry(set).Collection(i => i.Segments).Load();
            db.Entry(set).Collection(i => i.Intersections).Load();

            List<Segment> initialSegments = new List<Segment>();
            List<Segment> terminalSegments = new List<Segment>();

            Segment newSegment;
            foreach(var s in set.Segments)
            {
                newSegment = new Segment(s.StartX, s.EndX, s.StartY, s.EndY, s.IsSplitted);
                initialSegments.Add(newSegment);
            }

            foreach (var s in set.Intersections)
            {
                newSegment = new Segment(s.StartX, s.EndX, s.StartY, s.EndY);
                terminalSegments.Add(newSegment);
            }

            segmentsProcessor.initialSegments = initialSegments;
            segmentsProcessor.terminalSegments = terminalSegments;
            textBoxNumberOfSegments.Text = initialSegments.Count.ToString();

            pictureInitialSegments.Invalidate();
            pictureSplittedSegments.Invalidate();
        }
    }
}