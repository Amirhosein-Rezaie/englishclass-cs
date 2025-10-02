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
    public partial class admins : Form
    {
        public admins()
        {
            InitializeComponent();
        }

        public void ShowAllAdmins()
        {
            this.adminsTableAdapter.Fill(this.englishClassDataSet.Admins);
        }

        // funcs
        private void Admins_Load(object sender, EventArgs e)
        {
            ShowAllAdmins();
        }

        // functions of messages 
        public void MsgEnterCode()
        {
            MessageBox.Show("برای حذف کدملی وارد کنید", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

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
            MessageBox.Show("برای پاک کردن فقط یکی را انتخاب کنید", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // search admin
        bool ValidDeleteAdmin = false;
        private void TxtSearchAdmin_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchAdmin.Text;

            if (search != "")
            {
                int find = adminsTableAdapter.FillBySearch(englishClassDataSet.Admins, search, search);

                if (find == 1)
                    ValidDeleteAdmin = true;
                else
                    ValidDeleteAdmin = false;
            }
            else
            {
                ShowAllAdmins();
            }
        }

        private void BtnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (ValidDeleteAdmin)
            {
                try
                {
                    int.Parse(txtSearchAdmin.Text);

                    int deleteAdmin = adminsTableAdapter.deleteAdmin(txtSearchAdmin.Text);

                    if (deleteAdmin >= 1)
                        MsgSuccess();
                }
                catch (FormatException)
                {
                    MsgEnterCode();
                }
            }
            else
            {
                MsgSelectOne();
            }

            ShowAllAdmins();
        }

        // add a new admin
        private void BtnAddAdmin_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Code = txtCode.Text;
            string Username = txtUsername.Text;
            string Password = txtPass.Text;

            if (ID != "" && Code != "" && Username != "" && Password != "")
            {
                try
                {
                    adminsTableAdapter.AddAdmin(short.Parse(ID), Username, Code, Password);

                    MsgSuccess();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                }

                ShowAllAdmins();
            }
            else
            {
                MsgEmpty();
            }
        }
    }
}
