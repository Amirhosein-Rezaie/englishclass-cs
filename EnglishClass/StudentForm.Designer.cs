namespace EnglishClass
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.comboPay = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyBookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoClipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyBookGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.studentsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StudentsTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStudentsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.DataStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(290, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1294, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "زبان آموز";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID آموزش , تاریخ شروع , تاریخ امتحان";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(1184, 120);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(104, 47);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "نمایش همه";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShoAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(533, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.comboPay);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو بر اساس پرداخت";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(165, 56);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(131, 37);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "جستجو پرداخت";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // comboPay
            // 
            this.comboPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPay.FormattingEnabled = true;
            this.comboPay.Items.AddRange(new object[] {
            "پرداخت شده",
            "پرداخت نشده"});
            this.comboPay.Location = new System.Drawing.Point(38, 60);
            this.comboPay.Name = "comboPay";
            this.comboPay.Size = new System.Drawing.Size(121, 31);
            this.comboPay.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentBookNameDataGridViewTextBoxColumn,
            this.workBookNameDataGridViewTextBoxColumn,
            this.storyBookNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finalExamDateDataGridViewTextBoxColumn,
            this.payedDataGridViewCheckBoxColumn,
            this.tuitionDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.Term_ID,
            this.teacherNameDataGridViewTextBoxColumn,
            this.classRoomDataGridViewTextBoxColumn,
            this.classTimeDataGridViewTextBoxColumn,
            this.classGradeDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.videoClipDataGridViewTextBoxColumn,
            this.workBookDataGridViewTextBoxColumn,
            this.storyBookGradeDataGridViewTextBoxColumn,
            this.finalExamDataGridViewTextBoxColumn,
            this.finalGradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 241);
            this.dataGridView1.TabIndex = 3;
            // 
            // studentBookNameDataGridViewTextBoxColumn
            // 
            this.studentBookNameDataGridViewTextBoxColumn.DataPropertyName = "StudentBookName";
            this.studentBookNameDataGridViewTextBoxColumn.HeaderText = "نام کتاب زبان آموز";
            this.studentBookNameDataGridViewTextBoxColumn.Name = "studentBookNameDataGridViewTextBoxColumn";
            this.studentBookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workBookNameDataGridViewTextBoxColumn
            // 
            this.workBookNameDataGridViewTextBoxColumn.DataPropertyName = "WorkBookName";
            this.workBookNameDataGridViewTextBoxColumn.HeaderText = "نام کتاب کار";
            this.workBookNameDataGridViewTextBoxColumn.Name = "workBookNameDataGridViewTextBoxColumn";
            this.workBookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storyBookNameDataGridViewTextBoxColumn
            // 
            this.storyBookNameDataGridViewTextBoxColumn.DataPropertyName = "StoryBookName";
            this.storyBookNameDataGridViewTextBoxColumn.HeaderText = "نام کتاب داستان";
            this.storyBookNameDataGridViewTextBoxColumn.Name = "storyBookNameDataGridViewTextBoxColumn";
            this.storyBookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع ترم";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalExamDateDataGridViewTextBoxColumn
            // 
            this.finalExamDateDataGridViewTextBoxColumn.DataPropertyName = "FinalExamDate";
            this.finalExamDateDataGridViewTextBoxColumn.HeaderText = "تاریخ امتحان پایانی";
            this.finalExamDateDataGridViewTextBoxColumn.Name = "finalExamDateDataGridViewTextBoxColumn";
            this.finalExamDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payedDataGridViewCheckBoxColumn
            // 
            this.payedDataGridViewCheckBoxColumn.DataPropertyName = "Payed";
            this.payedDataGridViewCheckBoxColumn.HeaderText = "پرداخت ترم";
            this.payedDataGridViewCheckBoxColumn.Name = "payedDataGridViewCheckBoxColumn";
            this.payedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tuitionDataGridViewTextBoxColumn
            // 
            this.tuitionDataGridViewTextBoxColumn.DataPropertyName = "Tuition";
            this.tuitionDataGridViewTextBoxColumn.HeaderText = "شهریه";
            this.tuitionDataGridViewTextBoxColumn.Name = "tuitionDataGridViewTextBoxColumn";
            this.tuitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "سطح";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Term_ID
            // 
            this.Term_ID.DataPropertyName = "Term_ID";
            this.Term_ID.HeaderText = "ترم";
            this.Term_ID.Name = "Term_ID";
            this.Term_ID.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "نام معلم";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classRoomDataGridViewTextBoxColumn
            // 
            this.classRoomDataGridViewTextBoxColumn.DataPropertyName = "ClassRoom";
            this.classRoomDataGridViewTextBoxColumn.HeaderText = "شماره اتاق";
            this.classRoomDataGridViewTextBoxColumn.Name = "classRoomDataGridViewTextBoxColumn";
            this.classRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classTimeDataGridViewTextBoxColumn
            // 
            this.classTimeDataGridViewTextBoxColumn.DataPropertyName = "ClassTime";
            this.classTimeDataGridViewTextBoxColumn.HeaderText = "ساعت کلاس";
            this.classTimeDataGridViewTextBoxColumn.Name = "classTimeDataGridViewTextBoxColumn";
            this.classTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classGradeDataGridViewTextBoxColumn
            // 
            this.classGradeDataGridViewTextBoxColumn.DataPropertyName = "ClassGrade";
            this.classGradeDataGridViewTextBoxColumn.HeaderText = "نمره کلاسی";
            this.classGradeDataGridViewTextBoxColumn.Name = "classGradeDataGridViewTextBoxColumn";
            this.classGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "نمره فیلم";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videoClipDataGridViewTextBoxColumn
            // 
            this.videoClipDataGridViewTextBoxColumn.DataPropertyName = "VideoClip";
            this.videoClipDataGridViewTextBoxColumn.HeaderText = "نمره ویدیو کلیپ";
            this.videoClipDataGridViewTextBoxColumn.Name = "videoClipDataGridViewTextBoxColumn";
            this.videoClipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workBookDataGridViewTextBoxColumn
            // 
            this.workBookDataGridViewTextBoxColumn.DataPropertyName = "WorkBook";
            this.workBookDataGridViewTextBoxColumn.HeaderText = "نمره کتاب کار";
            this.workBookDataGridViewTextBoxColumn.Name = "workBookDataGridViewTextBoxColumn";
            this.workBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storyBookGradeDataGridViewTextBoxColumn
            // 
            this.storyBookGradeDataGridViewTextBoxColumn.DataPropertyName = "StoryBookGrade";
            this.storyBookGradeDataGridViewTextBoxColumn.HeaderText = "نمره کتاب داستان";
            this.storyBookGradeDataGridViewTextBoxColumn.Name = "storyBookGradeDataGridViewTextBoxColumn";
            this.storyBookGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalExamDataGridViewTextBoxColumn
            // 
            this.finalExamDataGridViewTextBoxColumn.DataPropertyName = "FinalExam";
            this.finalExamDataGridViewTextBoxColumn.HeaderText = "نمره امتحان پایانی";
            this.finalExamDataGridViewTextBoxColumn.Name = "finalExamDataGridViewTextBoxColumn";
            this.finalExamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalGradeDataGridViewTextBoxColumn
            // 
            this.finalGradeDataGridViewTextBoxColumn.DataPropertyName = "FinalGrade";
            this.finalGradeDataGridViewTextBoxColumn.HeaderText = "نمره نهایی";
            this.finalGradeDataGridViewTextBoxColumn.Name = "finalGradeDataGridViewTextBoxColumn";
            this.finalGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataStudentsBindingSource
            // 
            this.dataStudentsBindingSource.DataMember = "DataStudents";
            this.dataStudentsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // dataStudentsTableAdapter
            // 
            this.dataStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EnglishClassDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn storyBookNameDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataStudentsBindingSource;
        private EnglishClassDataSetTableAdapters.DataStudentsTableAdapter dataStudentsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboPay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyBookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoClipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyBookGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}