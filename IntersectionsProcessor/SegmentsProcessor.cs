using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionsProcessor
{
    internal class SegmentsProcessor
    {
        //Список с изначальными отрезками
        public List<Segment> initialSegments { get; }
        //Список с отрезками, которые получились в результате деления других отрезков
        public List<Segment> terminalSegments { get; set; }

        //Список с отрезками, у которых поле IsSplitted = false
        public List<Segment> UnsplittedSegments { get; set; }

        public SegmentsProcessor()
        {
            initialSegments = new List<Segment>();
            terminalSegments = new List<Segment>();
        }

        //Метод создания нового набора отрезков
        public void Generate(int numberOfSegments)
        {
            initialSegments.Clear();
            terminalSegments.Clear();

            Random random = new Random();
            Segment newSegment;            

            for (int i = 0; i < numberOfSegments; i++)
            {
                newSegment = new Segment(random.Next(0, 1200), random.Next(0, 1200), random.Next(0, 900), random.Next(0, 900));
 
                newSegment.IsSplitted = false;
                initialSegments.Add(newSegment);
            }
        }

        //Метод деления отрезков в текущем наборе
        public void SplitSegments()
        {
            bool finish;
            Point? intersection;
            UnsplittedSegments = new List<Segment>();
            foreach (Segment segment in initialSegments)
                GetUnsplittedSegments(segment);

            //Делим все возможные отрезки, у которых IsSplitted = false
            //После чего рекурсивно получаем наиболее мелкие отрезки, в результате у всех полученных отрезков IsSplitted = false
            //Выполняется пока возможно делить отрезки
            do
            {
                finish = true;

                for (int i = 0; i < UnsplittedSegments.Count - 1; i++)
                {
                    for (int j = i + 1; j < UnsplittedSegments.Count; j++)
                    {
                        intersection = GetSegmentsItersection(UnsplittedSegments[i], UnsplittedSegments[j]);
                        if (intersection != null && !UnsplittedSegments[i].IsSplitted && !UnsplittedSegments[j].IsSplitted)
                        {
                            if (Math.Abs(UnsplittedSegments[i].K) > Math.Abs(UnsplittedSegments[j].K))
                            {
                                SplitSegment(UnsplittedSegments[i], intersection?.X);
                            }
                            else
                            {
                                SplitSegment(UnsplittedSegments[j], intersection?.X);
                            }
                            finish = false;
                        }
                    }
                }

                //Если пересечения расположены слишком близко, возможно зацикливание, так как они будут "сдвигать" небольшой кусочек между собой
                //Чтобы этого избежать необходимо прервать цикл при появлении дублирующихся отрезков
                if (CheckForDuplicates())
                    break;

                GetTerminalSegments();
                UnsplittedSegments.Clear();
                foreach (Segment segment in initialSegments)
                    GetUnsplittedSegments(segment);
            } while (!finish);

            GetTerminalSegments();
        }

        //Рекурсия для получения всех отрезков, у которых IsSplitted = false
        private void GetUnsplittedSegments(Segment segment)
        {
            if (!segment.IsSplitted)
            {
                UnsplittedSegments.Add(segment);
                return;
            }
            else
            {
                GetUnsplittedSegments(segment.FirstDerivative);
                GetUnsplittedSegments(segment.SecondDerivative);
            }
        }

        //Получение точки пересечения отрезков
        private Point? GetSegmentsItersection(Segment segment1, Segment segment2)
        {
            //Получение точки пересечения прямых, на которых лежат отрезки
            int X = (int)((segment2.D - segment1.D) / (segment1.K - segment2.K));
            int Y = (int)(segment1.K * ((segment2.D - segment1.D) / (segment1.K - segment2.K)) + segment1.D);

            //Проверка, входит ли точка пересечения в оба отрезка
            if (CheckIntersection(X, Y, segment1, segment2))
            {
                return new Point(X, Y);
            }
            return null;
        }

        //Проверка, входит ли точка пересечения в оба отрезка
        private bool CheckIntersection(int X, int Y, Segment segment1, Segment segment2)
        {
            if (Math.Abs(X - segment1.P1.X) < Math.Abs(segment1.P1.X - segment1.P2.X) &&
                Math.Abs(X - segment1.P2.X) < Math.Abs(segment1.P1.X - segment1.P2.X) &&
                Math.Abs(X - segment2.P1.X) < Math.Abs(segment2.P1.X - segment2.P2.X) &&
                Math.Abs(X - segment2.P2.X) < Math.Abs(segment2.P1.X - segment2.P2.X) &&
                Math.Abs(Y - segment1.P1.Y) < Math.Abs(segment1.P1.Y - segment1.P2.Y) &&
                Math.Abs(Y - segment1.P2.Y) < Math.Abs(segment1.P1.Y - segment1.P2.Y) &&
                Math.Abs(Y - segment2.P1.Y) < Math.Abs(segment2.P1.Y - segment2.P2.Y) &&
                Math.Abs(Y - segment2.P2.Y) < Math.Abs(segment2.P1.Y - segment2.P2.Y))
                return true;

            return false;
        }

        //Разделение отрезка на две части и занесение потомков в родительский отрезок
        private void SplitSegment(Segment segment, int? intersectionX)
        {
            segment.IsSplitted = true;
            Segment firstDerivative, secondDerivative;

            int X1 = (int)(intersectionX - 4), X2 = (int)(intersectionX + 4);
            int Y1 = (int)(X1 * segment.K + segment.D);
            int Y2 = (int)(X2 * segment.K + segment.D);

            if (segment.P1.X < segment.P2.X)
            {
                segment.FirstDerivative = new Segment(segment.P1.X, X1, segment.P1.Y, Y1);
                segment.SecondDerivative = new Segment(segment.P2.X, X2, segment.P2.Y, Y2);
            }
            else
            {
                segment.FirstDerivative = new Segment(segment.P1.X, X2, segment.P1.Y, Y2);
                segment.SecondDerivative = new Segment(segment.P2.X, X1, segment.P2.Y, Y1);
            }
        }

        //Метод проверки наличия дублиуатов
        private bool CheckForDuplicates()
        {
            bool duplicate = false;
            for (int i = 0; i < UnsplittedSegments.Count - 1; i++)
            {
                for (int j = i + 1; j < UnsplittedSegments.Count; j++)
                {
                    if (UnsplittedSegments[i].Equals(UnsplittedSegments[j]))
                    {
                        duplicate = true;
                    }
                }
            }
            return duplicate;
        }

        //Занесение всех отрезков не первого уровня в список, для дальнейшей отрисовки
        private void GetTerminalSegments()
        {
            UnsplittedSegments.Clear();

            foreach(Segment segment in initialSegments)
            {
                if (segment.IsSplitted)
                {
                    GetUnsplittedSegments(segment);
                }
            }
            terminalSegments = new List<Segment>(UnsplittedSegments);
        }
    }
}
