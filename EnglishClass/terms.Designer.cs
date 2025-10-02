namespace EnglishClass
{
    partial class terms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terms));
            this.TermsView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTermsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteTerm = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.txtCodeTeacher = new System.Windows.Forms.TextBox();
            this.txtExam = new Atf.UI.DateTimeSelector();
            this.txtStart = new Atf.UI.DateTimeSelector();
            this.btnCreateTerm = new System.Windows.Forms.Button();
            this.StoryBooksCombo = new System.Windows.Forms.ComboBox();
            this.storyBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkBooksCombo = new System.Windows.Forms.ComboBox();
            this.workBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StdBooksCombo = new System.Windows.Forms.ComboBox();
            this.studentBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LevelsCombo = new System.Windows.Forms.ComboBox();
            this.levelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsCombo = new System.Windows.Forms.ComboBox();
            this.classRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataTermsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.DataTermsTableAdapter();
            this.levelsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.LevelsTableAdapter();
            this.storyBooksTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StoryBooksTableAdapter();
            this.studentBooksTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StudentBooksTableAdapter();
            this.workBooksTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.WorkBooksTableAdapter();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.TermsTableAdapter();
            this.classRoomsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.ClassRoomsTableAdapter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.TeachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TermsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTermsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TermsView
            // 
            this.TermsView.AllowUserToAddRows = false;
            this.TermsView.AllowUserToDeleteRows = false;
            this.TermsView.AutoGenerateColumns = false;
            this.TermsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.TeacherName,
            this.levelDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finalExamDateDataGridViewTextBoxColumn,
            this.classTimeDataGridViewTextBoxColumn,
            this.classRoomDataGridViewTextBoxColumn,
            this.tuitionDataGridViewTextBoxColumn,
            this.studentBookDataGridViewTextBoxColumn,
            this.workBookDataGridViewTextBoxColumn,
            this.storyBookDataGridViewTextBoxColumn});
            this.TermsView.DataSource = this.dataTermsBindingSource;
            this.TermsView.Location = new System.Drawing.Point(4, 191);
            this.TermsView.Margin = new System.Windows.Forms.Padding(5);
            this.TermsView.Name = "TermsView";
            this.TermsView.ReadOnly = true;
            this.TermsView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TermsView.Size = new System.Drawing.Size(1247, 195);
            this.TermsView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "نام معلم";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "سطح";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalExamDateDataGridViewTextBoxColumn
            // 
            this.finalExamDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finalExamDateDataGridViewTextBoxColumn.DataPropertyName = "FinalExamDate";
            this.finalExamDateDataGridViewTextBoxColumn.HeaderText = "تاریخ امتحان";
            this.finalExamDateDataGridViewTextBoxColumn.Name = "finalExamDateDataGridViewTextBoxColumn";
            this.finalExamDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classTimeDataGridViewTextBoxColumn
            // 
            this.classTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classTimeDataGridViewTextBoxColumn.DataPropertyName = "ClassTime";
            this.classTimeDataGridViewTextBoxColumn.HeaderText = "ساعت کلاس";
            this.classTimeDataGridViewTextBoxColumn.Name = "classTimeDataGridViewTextBoxColumn";
            this.classTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classRoomDataGridViewTextBoxColumn
            // 
            this.classRoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.classRoomDataGridViewTextBoxColumn.DataPropertyName = "ClassRoom";
            this.classRoomDataGridViewTextBoxColumn.HeaderText = "شماره اتاق";
            this.classRoomDataGridViewTextBoxColumn.Name = "classRoomDataGridViewTextBoxColumn";
            this.classRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tuitionDataGridViewTextBoxColumn
            // 
            this.tuitionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tuitionDataGridViewTextBoxColumn.DataPropertyName = "Tuition";
            this.tuitionDataGridViewTextBoxColumn.HeaderText = "شهریه";
            this.tuitionDataGridViewTextBoxColumn.Name = "tuitionDataGridViewTextBoxColumn";
            this.tuitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBookDataGridViewTextBoxColumn
            // 
            this.studentBookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentBookDataGridViewTextBoxColumn.DataPropertyName = "StudentBook";
            this.studentBookDataGridViewTextBoxColumn.HeaderText = "کتاب دانش آموز";
            this.studentBookDataGridViewTextBoxColumn.Name = "studentBookDataGridViewTextBoxColumn";
            this.studentBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workBookDataGridViewTextBoxColumn
            // 
            this.workBookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workBookDataGridViewTextBoxColumn.DataPropertyName = "WorkBook";
            this.workBookDataGridViewTextBoxColumn.HeaderText = "کتاب کار";
            this.workBookDataGridViewTextBoxColumn.Name = "workBookDataGridViewTextBoxColumn";
            this.workBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storyBookDataGridViewTextBoxColumn
            // 
            this.storyBookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storyBookDataGridViewTextBoxColumn.DataPropertyName = "StoryBook";
            this.storyBookDataGridViewTextBoxColumn.HeaderText = "کتاب داستان";
            this.storyBookDataGridViewTextBoxColumn.Name = "storyBookDataGridViewTextBoxColumn";
            this.storyBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTermsBindingSource
            // 
            this.dataTermsBindingSource.DataMember = "DataTerms";
            this.dataTermsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 394);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 248);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnDeleteTerm);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "جستجو";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(568, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "ID , تاریخ شروع";
            // 
            // btnDeleteTerm
            // 
            this.btnDeleteTerm.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTerm.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteTerm.Location = new System.Drawing.Point(558, 112);
            this.btnDeleteTerm.Name = "btnDeleteTerm";
            this.btnDeleteTerm.Size = new System.Drawing.Size(133, 41);
            this.btnDeleteTerm.TabIndex = 1;
            this.btnDeleteTerm.Text = "حذف";
            this.btnDeleteTerm.UseVisualStyleBackColor = false;
            this.btnDeleteTerm.Click += new System.EventHandler(this.BtnDeleteTerm_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(415, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.txtTime);
            this.tabPage2.Controls.Add(this.txtCodeTeacher);
            this.tabPage2.Controls.Add(this.txtExam);
            this.tabPage2.Controls.Add(this.txtStart);
            this.tabPage2.Controls.Add(this.btnCreateTerm);
            this.tabPage2.Controls.Add(this.StoryBooksCombo);
            this.tabPage2.Controls.Add(this.WorkBooksCombo);
            this.tabPage2.Controls.Add(this.StdBooksCombo);
            this.tabPage2.Controls.Add(this.LevelsCombo);
            this.tabPage2.Controls.Add(this.RoomsCombo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtTuition);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "افزودن ترم";
            // 
            // txtTime
            // 
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtTime.Location = new System.Drawing.Point(245, 42);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(185, 31);
            this.txtTime.TabIndex = 12;
            // 
            // txtCodeTeacher
            // 
            this.txtCodeTeacher.Location = new System.Drawing.Point(52, 42);
            this.txtCodeTeacher.Name = "txtCodeTeacher";
            this.txtCodeTeacher.Size = new System.Drawing.Size(186, 31);
            this.txtCodeTeacher.TabIndex = 5;
            this.txtCodeTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodeTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(436, 41);
            this.txtExam.Name = "txtExam";
            this.txtExam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExam.Size = new System.Drawing.Size(186, 32);
            this.txtExam.TabIndex = 3;
            this.txtExam.UsePersianFormat = true;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(628, 40);
            this.txtStart.Name = "txtStart";
            this.txtStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStart.Size = new System.Drawing.Size(186, 32);
            this.txtStart.TabIndex = 2;
            this.txtStart.UsePersianFormat = true;
            // 
            // btnCreateTerm
            // 
            this.btnCreateTerm.BackColor = System.Drawing.Color.White;
            this.btnCreateTerm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateTerm.Location = new System.Drawing.Point(3, 159);
            this.btnCreateTerm.Name = "btnCreateTerm";
            this.btnCreateTerm.Size = new System.Drawing.Size(1244, 50);
            this.btnCreateTerm.TabIndex = 11;
            this.btnCreateTerm.Text = "ایجاد ترم";
            this.btnCreateTerm.UseVisualStyleBackColor = false;
            this.btnCreateTerm.Click += new System.EventHandler(this.BtnCreateTerm_Click);
            // 
            // StoryBooksCombo
            // 
            this.StoryBooksCombo.DataSource = this.storyBooksBindingSource;
            this.StoryBooksCombo.DisplayMember = "BookName";
            this.StoryBooksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoryBooksCombo.FormattingEnabled = true;
            this.StoryBooksCombo.Location = new System.Drawing.Point(143, 113);
            this.StoryBooksCombo.Name = "StoryBooksCombo";
            this.StoryBooksCombo.Size = new System.Drawing.Size(186, 31);
            this.StoryBooksCombo.TabIndex = 10;
            // 
            // storyBooksBindingSource
            // 
            this.storyBooksBindingSource.DataMember = "StoryBooks";
            this.storyBooksBindingSource.DataSource = this.englishClassDataSet;
            // 
            // WorkBooksCombo
            // 
            this.WorkBooksCombo.DataSource = this.workBooksBindingSource;
            this.WorkBooksCombo.DisplayMember = "BookName";
            this.WorkBooksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkBooksCombo.FormattingEnabled = true;
            this.WorkBooksCombo.Location = new System.Drawing.Point(335, 113);
            this.WorkBooksCombo.Name = "WorkBooksCombo";
            this.WorkBooksCombo.Size = new System.Drawing.Size(186, 31);
            this.WorkBooksCombo.TabIndex = 9;
            // 
            // workBooksBindingSource
            // 
            this.workBooksBindingSource.DataMember = "WorkBooks";
            this.workBooksBindingSource.DataSource = this.englishClassDataSet;
            // 
            // StdBooksCombo
            // 
            this.StdBooksCombo.DataSource = this.studentBooksBindingSource;
            this.StdBooksCombo.DisplayMember = "BookName";
            this.StdBooksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StdBooksCombo.FormattingEnabled = true;
            this.StdBooksCombo.Location = new System.Drawing.Point(527, 113);
            this.StdBooksCombo.Name = "StdBooksCombo";
            this.StdBooksCombo.Size = new System.Drawing.Size(186, 31);
            this.StdBooksCombo.TabIndex = 8;
            // 
            // studentBooksBindingSource
            // 
            this.studentBooksBindingSource.DataMember = "StudentBooks";
            this.studentBooksBindingSource.DataSource = this.englishClassDataSet;
            // 
            // LevelsCombo
            // 
            this.LevelsCombo.DataSource = this.levelsBindingSource;
            this.LevelsCombo.DisplayMember = "nam";
            this.LevelsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelsCombo.FormattingEnabled = true;
            this.LevelsCombo.Location = new System.Drawing.Point(719, 113);
            this.LevelsCombo.Name = "LevelsCombo";
            this.LevelsCombo.Size = new System.Drawing.Size(186, 31);
            this.LevelsCombo.TabIndex = 7;
            this.LevelsCombo.SelectedIndexChanged += new System.EventHandler(this.LevelsCombo_SelectedIndexChanged);
            // 
            // levelsBindingSource
            // 
            this.levelsBindingSource.DataMember = "Levels";
            this.levelsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // RoomsCombo
            // 
            this.RoomsCombo.DataSource = this.classRoomsBindingSource;
            this.RoomsCombo.DisplayMember = "ID";
            this.RoomsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomsCombo.FormattingEnabled = true;
            this.RoomsCombo.Location = new System.Drawing.Point(911, 113);
            this.RoomsCombo.Name = "RoomsCombo";
            this.RoomsCombo.Size = new System.Drawing.Size(186, 31);
            this.RoomsCombo.TabIndex = 6;
            // 
            // classRoomsBindingSource
            // 
            this.classRoomsBindingSource.DataMember = "ClassRooms";
            this.classRoomsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "کد ملی معلم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ساعت";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "کتاب داستان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "کتاب کار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "تاریخ امتحان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "کتاب زبان آموز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاریخ شروع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "سطح";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "شهریه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(967, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "شماره اتاق";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1091, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(820, 41);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(186, 31);
            this.txtTuition.TabIndex = 1;
            this.txtTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTuition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1012, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 31);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.terms;
            this.pictureBox1.Location = new System.Drawing.Point(264, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataTermsTableAdapter
            // 
            this.dataTermsTableAdapter.ClearBeforeFill = true;
            // 
            // levelsTableAdapter
            // 
            this.levelsTableAdapter.ClearBeforeFill = true;
            // 
            // storyBooksTableAdapter
            // 
            this.storyBooksTableAdapter.ClearBeforeFill = true;
            // 
            // studentBooksTableAdapter
            // 
            this.studentBooksTableAdapter.ClearBeforeFill = true;
            // 
            // workBooksTableAdapter
            // 
            this.workBooksTableAdapter.ClearBeforeFill = true;
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // classRoomsTableAdapter
            // 
            this.classRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.englishClassDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TermsView);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "terms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترم ها";
            this.Load += new System.EventHandler(this.Terms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TermsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTermsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TermsView;
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource dataTermsBindingSource;
        private EnglishClassDataSetTableAdapters.DataTermsTableAdapter dataTermsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreateTerm;
        private System.Windows.Forms.ComboBox StoryBooksCombo;
        private System.Windows.Forms.ComboBox WorkBooksCombo;
        private System.Windows.Forms.ComboBox StdBooksCombo;
        private System.Windows.Forms.ComboBox LevelsCombo;
        private System.Windows.Forms.ComboBox RoomsCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.BindingSource levelsBindingSource;
        private EnglishClassDataSetTableAdapters.LevelsTableAdapter levelsTableAdapter;
        private System.Windows.Forms.BindingSource storyBooksBindingSource;
        private EnglishClassDataSetTableAdapters.StoryBooksTableAdapter storyBooksTableAdapter;
        private System.Windows.Forms.BindingSource studentBooksBindingSource;
        private EnglishClassDataSetTableAdapters.StudentBooksTableAdapter studentBooksTableAdapter;
        private System.Windows.Forms.BindingSource workBooksBindingSource;
        private EnglishClassDataSetTableAdapters.WorkBooksTableAdapter workBooksTableAdapter;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private EnglishClassDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
        private System.Windows.Forms.BindingSource classRoomsBindingSource;
        private EnglishClassDataSetTableAdapters.ClassRoomsTableAdapter classRoomsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Atf.UI.DateTimeSelector txtStart;
        private Atf.UI.DateTimeSelector txtExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCodeTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EnglishClassDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.Button btnDeleteTerm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtTime;
    }
}