namespace IntersectionsProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNameSet = new System.Windows.Forms.TextBox();
            this.labelNumberOfSegments = new System.Windows.Forms.Label();
            this.textBoxNumberOfSegments = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveInDB = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureInitialSegments = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureSplittedSegments = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInitialSegments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplittedSegments)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.7193F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1682, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 587);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxNameSet, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelNumberOfSegments, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNumberOfSegments, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonGenerate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonSaveInDB, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 287);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxNameSet
            // 
            this.textBoxNameSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameSet.Location = new System.Drawing.Point(3, 191);
            this.textBoxNameSet.Name = "textBoxNameSet";
            this.textBoxNameSet.Size = new System.Drawing.Size(188, 23);
            this.textBoxNameSet.TabIndex = 6;
            // 
            // labelNumberOfSegments
            // 
            this.labelNumberOfSegments.AutoSize = true;
            this.labelNumberOfSegments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNumberOfSegments.Location = new System.Drawing.Point(3, 17);
            this.labelNumberOfSegments.Name = "labelNumberOfSegments";
            this.labelNumberOfSegments.Size = new System.Drawing.Size(188, 30);
            this.labelNumberOfSegments.TabIndex = 5;
            this.labelNumberOfSegments.Text = "Количество генерируемых линий";
            // 
            // textBoxNumberOfSegments
            // 
            this.textBoxNumberOfSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumberOfSegments.Location = new System.Drawing.Point(3, 50);
            this.textBoxNumberOfSegments.Name = "textBoxNumberOfSegments";
            this.textBoxNumberOfSegments.Size = new System.Drawing.Size(188, 23);
            this.textBoxNumberOfSegments.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerate.Location = new System.Drawing.Point(3, 97);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(188, 41);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Создать новый набор";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название набора для сохранения в базу данных";
            // 
            // buttonSaveInDB
            // 
            this.buttonSaveInDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveInDB.Location = new System.Drawing.Point(3, 238);
            this.buttonSaveInDB.Name = "buttonSaveInDB";
            this.buttonSaveInDB.Size = new System.Drawing.Size(188, 46);
            this.buttonSaveInDB.TabIndex = 4;
            this.buttonSaveInDB.Text = "Сохранить данные в базу данных";
            this.buttonSaveInDB.UseVisualStyleBackColor = true;
            this.buttonSaveInDB.Click += new System.EventHandler(this.buttonSaveInDB_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(209, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1470, 587);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureInitialSegments);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1462, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Начальные отрезки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureInitialSegments
            // 
            this.pictureInitialSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureInitialSegments.Location = new System.Drawing.Point(3, 3);
            this.pictureInitialSegments.Name = "pictureInitialSegments";
            this.pictureInitialSegments.Size = new System.Drawing.Size(1456, 553);
            this.pictureInitialSegments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInitialSegments.TabIndex = 0;
            this.pictureInitialSegments.TabStop = false;
            this.pictureInitialSegments.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureInitialSegments_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureSplittedSegments);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1462, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разделенные отрезки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureSplittedSegments
            // 
            this.pictureSplittedSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureSplittedSegments.Location = new System.Drawing.Point(3, 3);
            this.pictureSplittedSegments.Name = "pictureSplittedSegments";
            this.pictureSplittedSegments.Size = new System.Drawing.Size(1456, 553);
            this.pictureSplittedSegments.TabIndex = 0;
            this.pictureSplittedSegments.TabStop = false;
            this.pictureSplittedSegments.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureSplittedSegments_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInitialSegments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplittedSegments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSaveInDB;
        private Button buttonGenerate;
        private TextBox textBoxNumberOfSegments;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureInitialSegments;
        private TabPage tabPage2;
        private PictureBox pictureSplittedSegments;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelNumberOfSegments;
        private TextBox textBoxNameSet;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
    }
}