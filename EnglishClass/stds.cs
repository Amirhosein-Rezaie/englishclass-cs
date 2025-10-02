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
    public partial class stds : Form
    {
        public stds()
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

        public void ShowAllStds()
        {
            this.studentsTableAdapter.Fill(this.englishClassDataSet.Students);
        }

        private void Stds_Load(object sender, EventArgs e)
        {
            ShowAllStds();
        }

        private void BtnAddStd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Family = txtFamily.Text;
            string Code = txtCode.Text;
            string Age = txtAge.Text;
            string ID = txtID.Text;
            string Phone = txtPhone.Text;

            if (Name != "" && Family != "" && Code != "" && Age != "" && Phone != "")
            {
                try
                {
                    studentsTableAdapter.AddStd(int.Parse(ID), Code, Name, Family, Phone, short.Parse(Age));
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                    return;
                }

                MsgSuccess();
            }
            else
            {
                MsgEmpty();
            }

            ShowAllStds();
        }

        bool ValidDeleteStd = false;
        private void TxtSearchStd_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchStd.Text;

            if (search != "")
            {
                int find = studentsTableAdapter.FillBySearch(englishClassDataSet.Students, search, search, search);
                if (find == 1)
                    ValidDeleteStd = true;
                else
                    ValidDeleteStd = false;
            }
            else
            {
                ShowAllStds();
            }
        }

        private void BtnDeleteStd_Click(object sender, EventArgs e)
        {
            if (ValidDeleteStd)
            {
                try
                {
                    int.Parse(txtSearchStd.Text);

                    int deleted = studentsTableAdapter.deleteStd(txtSearchStd.Text);

                    ShowAllStds();

                    if (deleted >= 1)
                        MsgSuccess();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("برای حذف کدملی وارد کنید", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MsgSelectOne();
            }
        }
    }
}
