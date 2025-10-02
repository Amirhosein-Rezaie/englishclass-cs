namespace EnglishClass
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.iDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisrtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnterStds = new System.Windows.Forms.Button();
            this.btnEnterTerms = new System.Windows.Forms.Button();
            this.btnEnterTeachs = new System.Windows.Forms.Button();
            this.btnEnterBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnterTeachers = new System.Windows.Forms.Button();
            this.btnEnterRooms = new System.Windows.Forms.Button();
            this.btnEnterAdmins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDataGridViewTextBoxColumn5
            // 
            this.iDDataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn5.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn5.Name = "iDDataGridViewTextBoxColumn5";
            this.iDDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // fisrtNameDataGridViewTextBoxColumn
            // 
            this.fisrtNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fisrtNameDataGridViewTextBoxColumn.DataPropertyName = "FisrtName";
            this.fisrtNameDataGridViewTextBoxColumn.HeaderText = "FisrtName";
            this.fisrtNameDataGridViewTextBoxColumn.Name = "fisrtNameDataGridViewTextBoxColumn";
            this.fisrtNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn2
            // 
            this.codeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn2.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn2.Name = "codeDataGridViewTextBoxColumn2";
            this.codeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnEnterStds
            // 
            this.btnEnterStds.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterStds.Location = new System.Drawing.Point(14, 337);
            this.btnEnterStds.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterStds.Name = "btnEnterStds";
            this.btnEnterStds.Size = new System.Drawing.Size(486, 43);
            this.btnEnterStds.TabIndex = 2;
            this.btnEnterStds.Text = "زبان آموزان";
            this.btnEnterStds.UseVisualStyleBackColor = false;
            this.btnEnterStds.Click += new System.EventHandler(this.BtnEnterStds_Click);
            // 
            // btnEnterTerms
            // 
            this.btnEnterTerms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterTerms.Location = new System.Drawing.Point(14, 282);
            this.btnEnterTerms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterTerms.Name = "btnEnterTerms";
            this.btnEnterTerms.Size = new System.Drawing.Size(486, 43);
            this.btnEnterTerms.TabIndex = 1;
            this.btnEnterTerms.Text = "ترم ها";
            this.btnEnterTerms.UseVisualStyleBackColor = false;
            this.btnEnterTerms.Click += new System.EventHandler(this.BtnEnterTerms_Click);
            // 
            // btnEnterTeachs
            // 
            this.btnEnterTeachs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterTeachs.Location = new System.Drawing.Point(14, 227);
            this.btnEnterTeachs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterTeachs.Name = "btnEnterTeachs";
            this.btnEnterTeachs.Size = new System.Drawing.Size(486, 43);
            this.btnEnterTeachs.TabIndex = 0;
            this.btnEnterTeachs.Text = "آموزش";
            this.btnEnterTeachs.UseVisualStyleBackColor = false;
            this.btnEnterTeachs.Click += new System.EventHandler(this.BtnEnterTeachs_Click);
            // 
            // btnEnterBooks
            // 
            this.btnEnterBooks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterBooks.Location = new System.Drawing.Point(14, 392);
            this.btnEnterBooks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterBooks.Name = "btnEnterBooks";
            this.btnEnterBooks.Size = new System.Drawing.Size(486, 43);
            this.btnEnterBooks.TabIndex = 3;
            this.btnEnterBooks.Text = "کتاب ها";
            this.btnEnterBooks.UseVisualStyleBackColor = false;
            this.btnEnterBooks.Click += new System.EventHandler(this.BtnEnterBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishClass.Properties.Resources.english;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnterTeachers
            // 
            this.btnEnterTeachers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterTeachers.Location = new System.Drawing.Point(14, 444);
            this.btnEnterTeachers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterTeachers.Name = "btnEnterTeachers";
            this.btnEnterTeachers.Size = new System.Drawing.Size(486, 43);
            this.btnEnterTeachers.TabIndex = 4;
            this.btnEnterTeachers.Text = "معلم ها";
            this.btnEnterTeachers.UseVisualStyleBackColor = false;
            this.btnEnterTeachers.Click += new System.EventHandler(this.BtnEnterTeachers_Click);
            // 
            // btnEnterRooms
            // 
            this.btnEnterRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterRooms.Location = new System.Drawing.Point(14, 497);
            this.btnEnterRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterRooms.Name = "btnEnterRooms";
            this.btnEnterRooms.Size = new System.Drawing.Size(486, 43);
            this.btnEnterRooms.TabIndex = 5;
            this.btnEnterRooms.Text = "اتاق ها و سطح ها";
            this.btnEnterRooms.UseVisualStyleBackColor = false;
            this.btnEnterRooms.Click += new System.EventHandler(this.BtnEnterRooms_Click);
            // 
            // btnEnterAdmins
            // 
            this.btnEnterAdmins.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnterAdmins.Location = new System.Drawing.Point(14, 552);
            this.btnEnterAdmins.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterAdmins.Name = "btnEnterAdmins";
            this.btnEnterAdmins.Size = new System.Drawing.Size(486, 43);
            this.btnEnterAdmins.TabIndex = 6;
            this.btnEnterAdmins.Text = "ادمین ها";
            this.btnEnterAdmins.UseVisualStyleBackColor = false;
            this.btnEnterAdmins.Click += new System.EventHandler(this.BtnEnterAdmins_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnterAdmins);
            this.Controls.Add(this.btnEnterRooms);
            this.Controls.Add(this.btnEnterTeachers);
            this.Controls.Add(this.btnEnterBooks);
            this.Controls.Add(this.btnEnterTeachs);
            this.Controls.Add(this.btnEnterTerms);
            this.Controls.Add(this.btnEnterStds);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Class";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EnglishClassDataSetTableAdapters.DataTeachTableAdapter dataTachTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn avatarDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisrtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnEnterStds;
        private System.Windows.Forms.Button btnEnterTerms;
        private System.Windows.Forms.Button btnEnterTeachs;
        private System.Windows.Forms.Button btnEnterBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnterTeachers;
        private System.Windows.Forms.Button btnEnterRooms;
        private System.Windows.Forms.Button btnEnterAdmins;
    }
}

