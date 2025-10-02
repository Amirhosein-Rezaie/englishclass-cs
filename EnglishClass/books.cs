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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        // functions of messages 
        public void MsgEnterID()
        {
            MessageBox.Show("برای حذف ID وارد کنید", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void ShowAllStdBooks()
        {
            this.studentBooksTableAdapter.Fill(this.englishClassDataSet.StudentBooks);
        }

        public void ShowAllWorkBooks()
        {
            this.workBooksTableAdapter.Fill(this.englishClassDataSet.WorkBooks);
        }

        public void ShowAllStoryBooks()
        {
            this.storyBooksTableAdapter.Fill(this.englishClassDataSet.StoryBooks);
        }

        private void Books_Load(object sender, EventArgs e)
        {
            this.levelsTableAdapter.Fill(this.englishClassDataSet.Levels);

            ShowAllStoryBooks();

            ShowAllWorkBooks();

            ShowAllStdBooks();
        }

        // studentbooks
        private void BtnAddStdBook_Click(object sender, EventArgs e)
        {
            string name = txtNameStdBook.Text;
            string level = LevelCombo.Text;
            string ID = txtStdBookID.Text;

            if (name != "" && level != "" && ID != "")
            {
                try
                {
                    studentBooksTableAdapter.addStdBook(int.Parse(ID), name, level);
                    ShowAllStdBooks();
                    MsgSuccess();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                }
            }
            else
            {
                MsgEmpty();
            }
        }

        bool ValidDeleteStdBook = false;
        private void TxtSearchStdBook_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchStdBook.Text;

            if (search != "")
            {
                int find = studentBooksTableAdapter.FillBySearch(englishClassDataSet.StudentBooks, search, search, search);
                if (find == 1)
                    ValidDeleteStdBook = true;
                else
                    ValidDeleteStdBook = false;
            }
            else
            {
                ShowAllStdBooks();
            }
        }

        private void BtnDeleteStdBook_Click(object sender, EventArgs e)
        {
            if (ValidDeleteStdBook)
            {
                try
                {
                    int.Parse(txtSearchStdBook.Text);

                    int deleted = studentBooksTableAdapter.deleteStudentBook(txtSearchStdBook.Text);

                    if (deleted >= 1)
                        MsgSuccess();

                    ShowAllStdBooks();
                }
                catch (FormatException)
                {
                    MsgEnterID();
                }
            }
            else
            {
                MsgSelectOne();
            }
        }

        // workbooks
        bool ValidDeleteWBook = false;
        private void TxtSearchWBook_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchWBook.Text;

            if (search != "")
            {
                int find = workBooksTableAdapter.FillBySearch(englishClassDataSet.WorkBooks, search, search, search);
                if (find == 1)
                    ValidDeleteWBook = true;
                else
                    ValidDeleteWBook = false;
            }
            else
            {
                ShowAllWorkBooks();
            }
        }
        private void BtnDeleteWBook_Click(object sender, EventArgs e)
        {
            if (ValidDeleteWBook)
            {
                try
                {
                    int.Parse(txtSearchWBook.Text);

                    int deleted = workBooksTableAdapter.deleteWBook(txtSearchWBook.Text);

                    if (deleted >= 1)
                        MsgSuccess();

                    ShowAllWorkBooks();
                }
                catch (FormatException)
                {
                    MsgEnterID();
                }
            }
            else
            {
                MsgSelectOne();
            }
        }

        private void BtnAddWBook_Click(object sender, EventArgs e)
        {
            string name = txtNameWBook.Text;
            string level = LevelComboWBook.Text;
            string ID = txtIDWBook.Text;

            if (name != "" && level != "" && ID != "")
            {
                try
                {
                    workBooksTableAdapter.AddWorkBook(int.Parse(ID), name, level);
                    ShowAllWorkBooks();
                    MsgSuccess();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                }
            }
            else
            {
                MsgEmpty();
            }
        }

        // storybooks
        bool ValidDeleteSBook = false;
        private void TxtSearchSBook_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchSBook.Text;

            if (search != "")
            {
                int find = storyBooksTableAdapter.FillBySearch(englishClassDataSet.StoryBooks, search, search, search);
                if (find == 1)
                    ValidDeleteSBook = true;
                else
                    ValidDeleteSBook = false;
            }
            else
            {
                ShowAllStoryBooks();
            }
        }

        private void BtnDeleteSBook_Click(object sender, EventArgs e)
        {
            if (ValidDeleteSBook)
            {
                try
                {
                    int.Parse(txtSearchSBook.Text);

                    int deleted = storyBooksTableAdapter.deleteSBook(txtSearchSBook.Text);

                    if (deleted >= 1)
                        MsgSuccess();

                    ShowAllStoryBooks();
                }
                catch (FormatException)
                {
                    MsgEnterID();
                }
            }
            else
            {
                MsgSelectOne();
            }
        }

        private void btnAddSBook_Click(object sender, EventArgs e)
        {
            string name = txtNameSBook.Text;
            string level = LevelComboSBook.Text;
            string ID = txtIDSBook.Text;

            if (name != "" && level != "" && ID != "")
            {
                try
                {
                    storyBooksTableAdapter.AddStoryBook(int.Parse(ID), name, level);
                    ShowAllStoryBooks();
                    MsgSuccess();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                }
            }
            else
            {
                MsgEmpty();
            }
        }
    }
}
