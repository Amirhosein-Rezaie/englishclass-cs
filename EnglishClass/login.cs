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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // functions of messages 
        public void MsgSuccess()
        {
            MessageBox.Show("با موفقیت افزوده شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // main

        public string username = "";
        public string password = "";

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string enter = txtEnter.Text;
            string pass = txtPassWord.Text;

            bool admin = AdminRadio.Checked;
            bool std = StdRadio.Checked;

            if (std)
            {
                if (enter != "")
                {
                    int find = studentsTableAdapter.FillByLogin(englishClassDataSet.Students, enter);

                    if (find > 0)
                    {
                        StudentForm stdForm = new StudentForm();
                        stdForm.Code = enter;
                        stdForm.ShowDialog();
                    }
                    else
                    {
                        MsgNotFound();
                    }
                }
                else
                {
                    MessageBox.Show("کد ملی خود را وارد کنید", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (admin)
            {
                if (enter != "" && pass != "")
                {
                    AdminForm main = new AdminForm();

                    int find = adminsTableAdapter.FillByLogin(englishClassDataSet.Admins, enter, enter, pass);

                    if (find > 0)
                    {
                        username = enter;
                        password = pass;
                        main.loginForm = this;
                        main.ShowDialog();
                    }
                    else
                    {
                        MsgNotFound();
                    }
                }
                else
                {
                    MsgEmpty();
                }
            }
        }

        private void StdRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (StdRadio.Checked)
            {
                txtPassWord.Enabled = false;
                ShowPass.Enabled = false;
                label1.Enabled = false;
            }
            else
            {
                txtPassWord.Enabled = true;
                ShowPass.Enabled = true;
                label1.Enabled = true;
            }
        }

        private void ShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                txtPassWord.PasswordChar = '\0';
            }
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }
    }
}
