using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishClass
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        // functions of messages 
        public void MsgSuccess()
        {
            MessageBox.Show("با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MsgEmpty()
        {
            MessageBox.Show("مقادیر را وارد کنید", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MsgReptitive()
        {
            MessageBox.Show("تکراری است", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MsgNotFound()
        {
            MessageBox.Show("پیدا نشده است", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MsgSelectOne()
        {
            MessageBox.Show("برای تغییر یک آموزش را انتخاب کنید", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // funcs
        private void OnlyGetNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void OnlyGetLetter(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void ShowAllTeachers()
        {
            this.teachersTableAdapter.Fill(this.englishClassDataSet.Teachers);
        }

        // main
        private void Teachers_Load(object sender, EventArgs e)
        {
            ShowAllTeachers();
        }

        bool ValidDelete = false;
        string search;
        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            search = txtSearch.Text;

            if (search != "")
            {
                int find = teachersTableAdapter.FillBySearch(englishClassDataSet.Teachers,
                    search, search, search, search, search);
                if (find == 1)
                    ValidDelete = true;
                else
                    ValidDelete = false;
            }
            else
            {
                ShowAllTeachers();
            }
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (ValidDelete)
            {
                try
                {
                    int.Parse(txtSearch.Text);

                    int deleted = teachersTableAdapter.deleteTeacher(search, search, search, search, search);
                    if (deleted >= 1)
                    {
                        MsgSuccess();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("برای حذف کدملی یا ID وارد کنید", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MsgSelectOne();
            }
        }

        // add a new teacher
        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            string Family = txtFamily.Text;
            string Phone = txtPhone.Text;
            string Code = txtCode.Text;

            if (ID != "" && Name != "" && Family != "" && Phone != "" && Code != "")
            {
                try
                {
                    teachersTableAdapter.addTeacher(ID, Name, Family, Phone, Code);
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                    return;
                }

                MsgSuccess();

                ShowAllTeachers();
            }
            else
            {
                MsgEmpty();
            }
        }
    }
}
