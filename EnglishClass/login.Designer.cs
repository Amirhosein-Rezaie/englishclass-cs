namespace EnglishClass
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StdRadio = new System.Windows.Forms.RadioButton();
            this.AdminRadio = new System.Windows.Forms.RadioButton();
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.AdminsTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.StudentsTableAdapter();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(14, 197);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(361, 31);
            this.txtEnter.TabIndex = 0;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "کدملی | نام کاربری";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(14, 430);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(361, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StdRadio);
            this.groupBox1.Controls.Add(this.AdminRadio);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(361, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع ورود";
            // 
            // StdRadio
            // 
            this.StdRadio.AutoSize = true;
            this.StdRadio.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdRadio.Location = new System.Drawing.Point(130, 50);
            this.StdRadio.Name = "StdRadio";
            this.StdRadio.Size = new System.Drawing.Size(86, 27);
            this.StdRadio.TabIndex = 1;
            this.StdRadio.Text = "زبان آموز";
            this.StdRadio.UseVisualStyleBackColor = true;
            this.StdRadio.CheckedChanged += new System.EventHandler(this.StdRadio_CheckedChanged);
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.Checked = true;
            this.AdminRadio.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRadio.Location = new System.Drawing.Point(141, 22);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(63, 27);
            this.AdminRadio.TabIndex = 0;
            this.AdminRadio.TabStop = true;
            this.AdminRadio.Text = "ادمین";
            this.AdminRadio.UseVisualStyleBackColor = true;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(14, 272);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(361, 31);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Location = new System.Drawing.Point(144, 308);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(95, 27);
            this.ShowPass.TabIndex = 2;
            this.ShowPass.Text = "نمایش رمز";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "رمز ورود";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnter);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private EnglishClassDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StdRadio;
        private System.Windows.Forms.RadioButton AdminRadio;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EnglishClassDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}