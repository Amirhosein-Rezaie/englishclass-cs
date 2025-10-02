namespace EnglishClass
{
    partial class LevelRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelRooms));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishClassDataSet = new EnglishClass.EnglishClassDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteLvl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchlvl = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAddLvl = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRoomsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.ClassRoomsTableAdapter();
            this.levelsTableAdapter = new EnglishClass.EnglishClassDataSetTableAdapters.LevelsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اتاق ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(670, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(322, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 211);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddRoom);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 211);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "افزودن اتاق";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(91, 112);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(107, 38);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "افزودن";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(24, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 30);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classRoomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(671, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classRoomsBindingSource
            // 
            this.classRoomsBindingSource.DataMember = "ClassRooms";
            this.classRoomsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // englishClassDataSet
            // 
            this.englishClassDataSet.DataSetName = "EnglishClassDataSet";
            this.englishClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سطح ها";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(9, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(670, 221);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteLvl);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtSearchlvl);
            this.groupBox5.Location = new System.Drawing.Point(322, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 194);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "جستجو";
            // 
            // btnDeleteLvl
            // 
            this.btnDeleteLvl.BackColor = System.Drawing.Color.White;
            this.btnDeleteLvl.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteLvl.Location = new System.Drawing.Point(138, 125);
            this.btnDeleteLvl.Name = "btnDeleteLvl";
            this.btnDeleteLvl.Size = new System.Drawing.Size(93, 38);
            this.btnDeleteLvl.TabIndex = 5;
            this.btnDeleteLvl.Text = "حذف";
            this.btnDeleteLvl.UseVisualStyleBackColor = false;
            this.btnDeleteLvl.Click += new System.EventHandler(this.BtnDeleteLvl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "سطح";
            // 
            // txtSearchlvl
            // 
            this.txtSearchlvl.Location = new System.Drawing.Point(61, 89);
            this.txtSearchlvl.Name = "txtSearchlvl";
            this.txtSearchlvl.Size = new System.Drawing.Size(246, 30);
            this.txtSearchlvl.TabIndex = 3;
            this.txtSearchlvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchlvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            this.txtSearchlvl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearchlvl_KeyUp);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddLvl);
            this.groupBox6.Controls.Add(this.txtLevel);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 194);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "افزودن اتاق";
            // 
            // btnAddLvl
            // 
            this.btnAddLvl.BackColor = System.Drawing.Color.White;
            this.btnAddLvl.Location = new System.Drawing.Point(91, 112);
            this.btnAddLvl.Name = "btnAddLvl";
            this.btnAddLvl.Size = new System.Drawing.Size(107, 38);
            this.btnAddLvl.TabIndex = 2;
            this.btnAddLvl.Text = "افزودن";
            this.btnAddLvl.UseVisualStyleBackColor = false;
            this.btnAddLvl.Click += new System.EventHandler(this.BtnAddLvl_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(25, 76);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(239, 30);
            this.txtLevel.TabIndex = 0;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyGetLetter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام سطح";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.levelsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(670, 193);
            this.dataGridView2.TabIndex = 0;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namDataGridViewTextBoxColumn.DataPropertyName = "nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "سطح";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelsBindingSource
            // 
            this.levelsBindingSource.DataMember = "Levels";
            this.levelsBindingSource.DataSource = this.englishClassDataSet;
            // 
            // classRoomsTableAdapter
            // 
            this.classRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // levelsTableAdapter
            // 
            this.levelsTableAdapter.ClearBeforeFill = true;
            // 
            // LevelRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 472);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "LevelRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتاق ها";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishClassDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EnglishClassDataSet englishClassDataSet;
        private System.Windows.Forms.BindingSource classRoomsBindingSource;
        private EnglishClassDataSetTableAdapters.ClassRoomsTableAdapter classRoomsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource levelsBindingSource;
        private EnglishClassDataSetTableAdapters.LevelsTableAdapter levelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchlvl;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAddLvl;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteLvl;
    }
}