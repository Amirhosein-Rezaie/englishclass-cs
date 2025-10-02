namespace EnglishClass
{
    partial class teachs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachs));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.GroupBox();
            this.PayCombo = new System.Windows.Forms.ComboBox();
            this.btnChangePay = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStdCode = new System.Windows.Forms.TextBox();
            this.txtTeachID = new System.Windows.Forms.TextBox();
            this.txtTermID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxGrades = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassGrade = new System.Windows.Forms.TextBox();
            this.dataTeachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.txtWBookGrade = new System.Windows.Forms.TextBox();
            this.txtFilmGrade = new System.Windows.Forms.TextBox();
            this.txtExamGrade = new System.Windows.Forms.TextBox();
            this.txtSBookGrade = new System.Windows.Forms.TextBox();
            this.txtVideoGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeachSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoClipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StudentsTableAdapter();
            this.teachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTeachTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.DataTeachTableAdapter();
            this.teachTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.TeachTableAdapter();
            this.teachersTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.TeachersTableAdapter();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.payBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 359);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 186);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btnShowAll);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.payBox);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "جستجو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID آموزش , نام زبان آموز , فامیلی زبان آموز";
            // 
            // payBox
            // 
            this.payBox.Controls.Add(this.PayCombo);
            this.payBox.Controls.Add(this.btnChangePay);
            this.payBox.Location = new System.Drawing.Point(9, 7);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(450, 137);
            this.payBox.TabIndex = 1;
            this.payBox.TabStop = false;
            this.payBox.Text = "وضیعت پرداخت";
            // 
            // PayCombo
            // 
            this.PayCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayCombo.FormattingEnabled = true;
            this.PayCombo.Items.AddRange(new object[] {
            "پرداخت شده",
            "پرداخت نشد"});
            this.PayCombo.Location = new System.Drawing.Point(204, 53);
            this.PayCombo.Name = "PayCombo";
            this.PayCombo.Size = new System.Drawing.Size(156, 31);
            this.PayCombo.TabIndex = 1;
            // 
            // btnChangePay
            // 
            this.btnChangePay.BackColor = System.Drawing.Color.White;
            this.btnChangePay.Location = new System.Drawing.Point(76, 52);
            this.btnChangePay.Name = "btnChangePay";
            this.btnChangePay.Size = new System.Drawing.Size(98, 32);
            this.btnChangePay.TabIndex = 0;
            this.btnChangePay.Text = "تغییر";
            this.btnChangePay.UseVisualStyleBackColor = false;
            this.btnChangePay.Click += new System.EventHandler(this.BtnChangePay_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(550, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(497, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btnRegister);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtStdCode);
            this.tabPage2.Controls.Add(this.txtTeachID);
            this.tabPage2.Controls.Add(this.txtTermID);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1252, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ثبت نام دانش آموز";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.Location = new System.Drawing.Point(3, 102);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(1246, 45);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "کدملی زبان آموز";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(807, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "ID آموزش";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد ترم";
            // 
            // txtStdCode
            // 
            this.txtStdCode.Location = new System.Drawing.Point(318, 51);
            this.txtStdCode.Name = "txtStdCode";
            this.txtStdCode.Size = new System.Drawing.Size(206, 31);
            this.txtStdCode.TabIndex = 2;
            this.txtStdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeachID
            // 
            this.txtTeachID.Location = new System.Drawing.Point(742, 51);
            this.txtTeachID.Name = "txtTeachID";
            this.txtTeachID.Size = new System.Drawing.Size(206, 31);
            this.txtTeachID.TabIndex = 0;
            this.txtTeachID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTermID
            // 
            this.txtTermID.Location = new System.Drawing.Point(530, 51);
            this.txtTermID.Name = "txtTermID";
            this.txtTermID.Size = new System.Drawing.Size(206, 31);
            this.txtTermID.TabIndex = 1;
            this.txtTermID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.groupBoxGrades);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtTeachSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1252, 150);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "نمرات";
            // 
            // groupBoxGrades
            // 
            this.groupBoxGrades.Controls.Add(this.btnChange);
            this.groupBoxGrades.Controls.Add(this.label10);
            this.groupBoxGrades.Controls.Add(this.label9);
            this.groupBoxGrades.Controls.Add(this.label8);
            this.groupBoxGrades.Controls.Add(this.label7);
            this.groupBoxGrades.Controls.Add(this.label6);
            this.groupBoxGrades.Controls.Add(this.label5);
            this.groupBoxGrades.Controls.Add(this.txtClassGrade);
            this.groupBoxGrades.Controls.Add(this.txtWBookGrade);
            this.groupBoxGrades.Controls.Add(this.txtFilmGrade);
            this.groupBoxGrades.Controls.Add(this.txtExamGrade);
            this.groupBoxGrades.Controls.Add(this.txtSBookGrade);
            this.groupBoxGrades.Controls.Add(this.txtVideoGrade);
            this.groupBoxGrades.Enabled = false;
            this.groupBoxGrades.Location = new System.Drawing.Point(8, 3);
            this.groupBoxGrades.Name = "groupBoxGrades";
            this.groupBoxGrades.Size = new System.Drawing.Size(966, 139);
            this.groupBoxGrades.TabIndex = 1;
            this.groupBoxGrades.TabStop = false;
            this.groupBoxGrades.Text = "نمرات";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChange.Location = new System.Drawing.Point(6, 98);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(954, 35);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "تغییر";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "نمره امتحان پایانی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "نمره کتاب داستان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "نمره ویدیو کلیپ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "نمره فیلم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "نمره کتاب کار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "نمره کلاسی";
            // 
            // txtClassGrade
            // 
            this.txtClassGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "ClassGrade", true));
            this.txtClassGrade.Location = new System.Drawing.Point(776, 51);
            this.txtClassGrade.Name = "txtClassGrade";
            this.txtClassGrade.Size = new System.Drawing.Size(140, 31);
            this.txtClassGrade.TabIndex = 0;
            this.txtClassGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClassGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtClassGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // dataTeachBindingSource
            // 
            this.dataTeachBindingSource.DataMember = "DataTeach";
            this.dataTeachBindingSource.DataSource = this.englishClassDataSet;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtWBookGrade
            // 
            this.txtWBookGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "WorkBook", true));
            this.txtWBookGrade.Location = new System.Drawing.Point(624, 51);
            this.txtWBookGrade.Name = "txtWBookGrade";
            this.txtWBookGrade.Size = new System.Drawing.Size(140, 31);
            this.txtWBookGrade.TabIndex = 1;
            this.txtWBookGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWBookGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtWBookGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // txtFilmGrade
            // 
            this.txtFilmGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "Film", true));
            this.txtFilmGrade.Location = new System.Drawing.Point(478, 51);
            this.txtFilmGrade.Name = "txtFilmGrade";
            this.txtFilmGrade.Size = new System.Drawing.Size(140, 31);
            this.txtFilmGrade.TabIndex = 2;
            this.txtFilmGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilmGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtFilmGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // txtExamGrade
            // 
            this.txtExamGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "FinalExam", true));
            this.txtExamGrade.Location = new System.Drawing.Point(40, 51);
            this.txtExamGrade.Name = "txtExamGrade";
            this.txtExamGrade.Size = new System.Drawing.Size(140, 31);
            this.txtExamGrade.TabIndex = 5;
            this.txtExamGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExamGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtExamGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // txtSBookGrade
            // 
            this.txtSBookGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "StoryBook", true));
            this.txtSBookGrade.Location = new System.Drawing.Point(186, 51);
            this.txtSBookGrade.Name = "txtSBookGrade";
            this.txtSBookGrade.Size = new System.Drawing.Size(140, 31);
            this.txtSBookGrade.TabIndex = 4;
            this.txtSBookGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSBookGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtSBookGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // txtVideoGrade
            // 
            this.txtVideoGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTeachBindingSource, "VideoClip", true));
            this.txtVideoGrade.Location = new System.Drawing.Point(332, 51);
            this.txtVideoGrade.Name = "txtVideoGrade";
            this.txtVideoGrade.Size = new System.Drawing.Size(140, 31);
            this.txtVideoGrade.TabIndex = 3;
            this.txtVideoGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVideoGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtVideoGrade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinMaxGrade_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1047, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID آموزش";
            // 
            // txtTeachSearch
            // 
            this.txtTeachSearch.Location = new System.Drawing.Point(980, 54);
            this.txtTeachSearch.Name = "txtTeachSearch";
            this.txtTeachSearch.Size = new System.Drawing.Size(211, 31);
            this.txtTeachSearch.TabIndex = 0;
            this.txtTeachSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeachSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtTeachSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTeachSearch_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.Teach;
            this.pictureBox1.Location = new System.Drawing.Point(312, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD1DataGridViewTextBoxColumn,
            this.termIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.classGradeDataGridViewTextBoxColumn,
            this.storyBookDataGridViewTextBoxColumn,
            this.workBookDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.videoClipDataGridViewTextBoxColumn,
            this.finalExamDataGridViewTextBoxColumn,
            this.FinalGrade,
            this.payedDataGridViewCheckBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTeachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 193);
            this.dataGridView1.TabIndex = 3;
            // 
            // iD1DataGridViewTextBoxColumn
            // 
            this.iD1DataGridViewTextBoxColumn.DataPropertyName = "ID1";
            this.iD1DataGridViewTextBoxColumn.HeaderText = "ID";
            this.iD1DataGridViewTextBoxColumn.Name = "iD1DataGridViewTextBoxColumn";
            this.iD1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termIDDataGridViewTextBoxColumn
            // 
            this.termIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.termIDDataGridViewTextBoxColumn.DataPropertyName = "Term_ID1";
            this.termIDDataGridViewTextBoxColumn.HeaderText = "Term_ID";
            this.termIDDataGridViewTextBoxColumn.Name = "termIDDataGridViewTextBoxColumn";
            this.termIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classGradeDataGridViewTextBoxColumn
            // 
            this.classGradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classGradeDataGridViewTextBoxColumn.DataPropertyName = "ClassGrade";
            this.classGradeDataGridViewTextBoxColumn.HeaderText = "ClassGrade";
            this.classGradeDataGridViewTextBoxColumn.Name = "classGradeDataGridViewTextBoxColumn";
            this.classGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storyBookDataGridViewTextBoxColumn
            // 
            this.storyBookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storyBookDataGridViewTextBoxColumn.DataPropertyName = "StoryBook";
            this.storyBookDataGridViewTextBoxColumn.HeaderText = "StoryBook";
            this.storyBookDataGridViewTextBoxColumn.Name = "storyBookDataGridViewTextBoxColumn";
            this.storyBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workBookDataGridViewTextBoxColumn
            // 
            this.workBookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workBookDataGridViewTextBoxColumn.DataPropertyName = "WorkBook";
            this.workBookDataGridViewTextBoxColumn.HeaderText = "WorkBook";
            this.workBookDataGridViewTextBoxColumn.Name = "workBookDataGridViewTextBoxColumn";
            this.workBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videoClipDataGridViewTextBoxColumn
            // 
            this.videoClipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videoClipDataGridViewTextBoxColumn.DataPropertyName = "VideoClip";
            this.videoClipDataGridViewTextBoxColumn.HeaderText = "VideoClip";
            this.videoClipDataGridViewTextBoxColumn.Name = "videoClipDataGridViewTextBoxColumn";
            this.videoClipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalExamDataGridViewTextBoxColumn
            // 
            this.finalExamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finalExamDataGridViewTextBoxColumn.DataPropertyName = "FinalExam";
            this.finalExamDataGridViewTextBoxColumn.HeaderText = "FinalExam";
            this.finalExamDataGridViewTextBoxColumn.Name = "finalExamDataGridViewTextBoxColumn";
            this.finalExamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FinalGrade
            // 
            this.FinalGrade.DataPropertyName = "FinalGrade";
            this.FinalGrade.HeaderText = "FinalGrade";
            this.FinalGrade.Name = "FinalGrade";
            this.FinalGrade.ReadOnly = true;
            // 
            // payedDataGridViewCheckBoxColumn
            // 
            this.payedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payedDataGridViewCheckBoxColumn.DataPropertyName = "Payed";
            this.payedDataGridViewCheckBoxColumn.HeaderText = "Payed";
            this.payedDataGridViewCheckBoxColumn.Name = "payedDataGridViewCheckBoxColumn";
            this.payedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachBindingSource
            // 
            this.teachBindingSource.DataMember = "Teach";
            this.teachBindingSource.DataSource = this.englishClassDataSet;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.englishClassDataSet;
            // 
            // dataTeachTableAdapter
            // 
            this.dataTeachTableAdapter.ClearBeforeFill = true;
            // 
            // teachTableAdapter
            // 
            this.teachTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.White;
            this.btnShowAll.ForeColor = System.Drawing.Color.Green;
            this.btnShowAll.Location = new System.Drawing.Point(1152, 111);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(92, 33);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "نمایش همه";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // teachs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "teachs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آموزش ها";
            this.Load += new System.EventHandler(this.Teachs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.payBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxGrades.ResumeLayout(false);
            this.groupBoxGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource dataTeachBindingSource;
        private EnglishClassDataSetTableAdapters.DataTeachTableAdapter dataTeachTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdCode;
        private System.Windows.Forms.TextBox txtTermID;
        private System.Windows.Forms.BindingSource teachBindingSource;
        private EnglishClassDataSetTableAdapters.TeachTableAdapter teachTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EnglishClassDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EnglishClassDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxGrades;
        private System.Windows.Forms.TextBox txtClassGrade;
        private System.Windows.Forms.TextBox txtWBookGrade;
        private System.Windows.Forms.TextBox txtFilmGrade;
        private System.Windows.Forms.TextBox txtVideoGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeachSearch;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExamGrade;
        private System.Windows.Forms.TextBox txtSBookGrade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTeachID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox payBox;
        private System.Windows.Forms.ComboBox PayCombo;
        private System.Windows.Forms.Button btnChangePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn iD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoClipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalGrade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowAll;
    }
}