namespace EnglishClass
{
    partial class stds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stds));
            this.TabStds = new System.Windows.Forms.TabControl();
            this.PageSearch = new System.Windows.Forms.TabPage();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchStd = new System.Windows.Forms.TextBox();
            this.PageAddStd = new System.Windows.Forms.TabPage();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StudentsTableAdapter();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewStds = new System.Windows.Forms.DataGridView();
            this.TabStds.SuspendLayout();
            this.PageSearch.SuspendLayout();
            this.PageAddStd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStds)).BeginInit();
            this.SuspendLayout();
            // 
            // TabStds
            // 
            this.TabStds.Controls.Add(this.PageSearch);
            this.TabStds.Controls.Add(this.PageAddStd);
            this.TabStds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabStds.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabStds.Location = new System.Drawing.Point(0, 367);
            this.TabStds.Margin = new System.Windows.Forms.Padding(12);
            this.TabStds.Name = "TabStds";
            this.TabStds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabStds.RightToLeftLayout = true;
            this.TabStds.SelectedIndex = 0;
            this.TabStds.Size = new System.Drawing.Size(1131, 230);
            this.TabStds.TabIndex = 4;
            // 
            // PageSearch
            // 
            this.PageSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PageSearch.Controls.Add(this.btnDeleteStd);
            this.PageSearch.Controls.Add(this.label7);
            this.PageSearch.Controls.Add(this.txtSearchStd);
            this.PageSearch.Location = new System.Drawing.Point(4, 32);
            this.PageSearch.Margin = new System.Windows.Forms.Padding(12);
            this.PageSearch.Name = "PageSearch";
            this.PageSearch.Padding = new System.Windows.Forms.Padding(12);
            this.PageSearch.Size = new System.Drawing.Size(1123, 194);
            this.PageSearch.TabIndex = 0;
            this.PageSearch.Text = "جستجو";
            // 
            // btnDeleteStd
            // 
            this.btnDeleteStd.BackColor = System.Drawing.Color.White;
            this.btnDeleteStd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteStd.Location = new System.Drawing.Point(524, 119);
            this.btnDeleteStd.Name = "btnDeleteStd";
            this.btnDeleteStd.Size = new System.Drawing.Size(99, 34);
            this.btnDeleteStd.TabIndex = 3;
            this.btnDeleteStd.Text = "حذف";
            this.btnDeleteStd.UseVisualStyleBackColor = false;
            this.btnDeleteStd.Click += new System.EventHandler(this.BtnDeleteStd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID , نام , فامیلی , کدملی";
            // 
            // txtSearchStd
            // 
            this.txtSearchStd.Location = new System.Drawing.Point(363, 82);
            this.txtSearchStd.Name = "txtSearchStd";
            this.txtSearchStd.Size = new System.Drawing.Size(421, 30);
            this.txtSearchStd.TabIndex = 1;
            this.txtSearchStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchStd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearchStd_KeyUp);
            // 
            // PageAddStd
            // 
            this.PageAddStd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PageAddStd.Controls.Add(this.btnAddStd);
            this.PageAddStd.Controls.Add(this.label6);
            this.PageAddStd.Controls.Add(this.label5);
            this.PageAddStd.Controls.Add(this.label4);
            this.PageAddStd.Controls.Add(this.label3);
            this.PageAddStd.Controls.Add(this.label2);
            this.PageAddStd.Controls.Add(this.label1);
            this.PageAddStd.Controls.Add(this.txtAge);
            this.PageAddStd.Controls.Add(this.txtPhone);
            this.PageAddStd.Controls.Add(this.txtFamily);
            this.PageAddStd.Controls.Add(this.txtName);
            this.PageAddStd.Controls.Add(this.txtCode);
            this.PageAddStd.Controls.Add(this.txtID);
            this.PageAddStd.Location = new System.Drawing.Point(4, 32);
            this.PageAddStd.Name = "PageAddStd";
            this.PageAddStd.Size = new System.Drawing.Size(1123, 194);
            this.PageAddStd.TabIndex = 1;
            this.PageAddStd.Text = "افزودن زبان آموز";
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.White;
            this.btnAddStd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddStd.Location = new System.Drawing.Point(0, 148);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(1123, 46);
            this.btnAddStd.TabIndex = 6;
            this.btnAddStd.Text = "افزودن";
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.BtnAddStd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "سن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "شماره تلفن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "فامیلی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "کدملی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(292, 105);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 30);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(478, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 30);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(664, 105);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(180, 30);
            this.txtFamily.TabIndex = 3;
            this.txtFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 30);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(478, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(180, 30);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(664, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 30);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.Students;
            this.pictureBox1.Location = new System.Drawing.Point(200, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "سن";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentPhoneNumberDataGridViewTextBoxColumn
            // 
            this.parentPhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parentPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ParentPhoneNumber";
            this.parentPhoneNumberDataGridViewTextBoxColumn.HeaderText = "شماره تلفن";
            this.parentPhoneNumberDataGridViewTextBoxColumn.Name = "parentPhoneNumberDataGridViewTextBoxColumn";
            this.parentPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "فامیلی";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کدملی";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewStds
            // 
            this.ViewStds.AllowUserToAddRows = false;
            this.ViewStds.AllowUserToDeleteRows = false;
            this.ViewStds.AutoGenerateColumns = false;
            this.ViewStds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewStds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.parentPhoneNumberDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.ViewStds.DataSource = this.studentsBindingSource;
            this.ViewStds.Location = new System.Drawing.Point(4, 195);
            this.ViewStds.Margin = new System.Windows.Forms.Padding(12);
            this.ViewStds.Name = "ViewStds";
            this.ViewStds.ReadOnly = true;
            this.ViewStds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ViewStds.Size = new System.Drawing.Size(1123, 172);
            this.ViewStds.TabIndex = 3;
            // 
            // stds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 597);
            this.Controls.Add(this.TabStds);
            this.Controls.Add(this.ViewStds);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "stds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "زبان آموزان";
            this.Load += new System.EventHandler(this.Stds_Load);
            this.TabStds.ResumeLayout(false);
            this.PageSearch.ResumeLayout(false);
            this.PageSearch.PerformLayout();
            this.PageAddStd.ResumeLayout(false);
            this.PageAddStd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabStds;
        private System.Windows.Forms.TabPage PageSearch;
        //private System.Windows.Forms.TextBox txtSearchStd;
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EnglishClassDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox txtSearchStd;
        private System.Windows.Forms.TabPage PageAddStd;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ViewStds;
    }
}