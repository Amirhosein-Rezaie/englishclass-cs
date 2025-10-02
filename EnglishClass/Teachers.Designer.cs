namespace EnglishClass
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.TeachersView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.teachersTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.TeachersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersView
            // 
            this.TeachersView.AllowUserToAddRows = false;
            this.TeachersView.AllowUserToDeleteRows = false;
            this.TeachersView.AutoGenerateColumns = false;
            this.TeachersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.TeachersView.DataSource = this.teachersBindingSource;
            this.TeachersView.Location = new System.Drawing.Point(14, 177);
            this.TeachersView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TeachersView.Name = "TeachersView";
            this.TeachersView.ReadOnly = true;
            this.TeachersView.Size = new System.Drawing.Size(880, 189);
            this.TeachersView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.englishClassDataSet;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 375);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 224);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDeleteTeacher);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "جستجو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID , نام , فامیلی , شماره تلفن , کدملی";
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(410, 109);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(83, 32);
            this.btnDeleteTeacher.TabIndex = 3;
            this.btnDeleteTeacher.Text = "حذف";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(310, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.btnAddTeacher);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCode);
            this.tabPage2.Controls.Add(this.txtFamily);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 188);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "افزودن معلم";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(446, 101);
            this.txtPhone.Mask = "09-000-000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(161, 30);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.White;
            this.btnAddTeacher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddTeacher.Location = new System.Drawing.Point(3, 143);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(868, 42);
            this.btnAddTeacher.TabIndex = 5;
            this.btnAddTeacher.Text = "افزودن";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "کدملی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "شماره تلفن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "فامیلی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(279, 101);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 30);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(210, 41);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(161, 30);
            this.txtFamily.TabIndex = 2;
            this.txtFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 30);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(544, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 30);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.teachers;
            this.pictureBox1.Location = new System.Drawing.Point(144, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TeachersView);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلم ها";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeachersView;
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EnglishClassDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}