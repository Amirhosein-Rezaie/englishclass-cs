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
    public partial class terms : Form
    {
        public terms()
        {
            InitializeComponent();
        }

        public void ShowAllTerms()
        {
            this.dataTermsTableAdapter.Fill(this.englishClassDataSet.DataTerms);
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

        // main
        private void Terms_Load(object sender, EventArgs e)
        {
            this.classRoomsTableAdapter.Fill(this.englishClassDataSet.ClassRooms);

            this.termsTableAdapter.Fill(this.englishClassDataSet.Terms);

            this.workBooksTableAdapter.Fill(this.englishClassDataSet.WorkBooks);

            this.studentBooksTableAdapter.Fill(this.englishClassDataSet.StudentBooks);

            this.storyBooksTableAdapter.Fill(this.englishClassDataSet.StoryBooks);

            this.levelsTableAdapter.Fill(this.englishClassDataSet.Levels);

            ShowAllTerms();
        }

        private void BtnCreateTerm_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string StartDate = txtStart.Text;
            string ExamDate = txtExam.Text;

            string[] value = txtTime.Value.ToString().Split(' ');
            string Time = value[1] + ' ' + value[2];

            string Room = RoomsCombo.Text;
            string lvl = LevelsCombo.Text;
            string stdBook = StdBooksCombo.Text;
            string WorkBook = WorkBooksCombo.Text;
            string StoryBook = StoryBooksCombo.Text;
            string Tuition = txtTuition.Text;
            string CodeTeacher = txtCodeTeacher.Text;

            if (StartDate != "" && ExamDate != "" && Time != "" && Room != "" &&
                lvl != "" && stdBook != "" && WorkBook != "" && StoryBook != "" && Tuition != "")
            {
                string StdBookID;
                string WorkBookID;
                string StoryBookID;
                int Teacher_ID;

                try
                {
                    StdBookID = studentBooksTableAdapter.selectID(stdBook, lvl);
                    WorkBookID = workBooksTableAdapter.selectID(WorkBook, lvl);
                    StoryBookID = storyBooksTableAdapter.selectID(StoryBook, lvl);
                    Teacher_ID = int.Parse(teachersTableAdapter.selectID(CodeTeacher));
                }
                catch (System.ArgumentNullException)
                {
                    MsgNotFound();
                    return;
                }

                if (StdBookID != "" && WorkBookID != "" && StoryBookID != "" && Teacher_ID != 0)
                {
                    try
                    {
                        termsTableAdapter.CreateTerm(ID, StdBookID, WorkBookID, StoryBookID, lvl, StartDate,
                            ExamDate, Time, int.Parse(Room), int.Parse(Tuition), Teacher_ID.ToString());

                        ShowAllTerms();
                        MsgSuccess();
                    }
                    catch (System.Data.OleDb.OleDbException)
                    {
                        MsgReptitive();
                    }
                }
                else
                {
                    MsgNotFound();
                }

                ShowAllTerms();
            }
            else
            {
                MsgEmpty();
            }

            ShowAllTerms();
        }

        private void LevelsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = LevelsCombo.Text;

            studentBooksTableAdapter.FillByLevel(englishClassDataSet.StudentBooks, search);

            workBooksTableAdapter.FillByLevel(englishClassDataSet.WorkBooks, search);

            storyBooksTableAdapter.FillByLevel(englishClassDataSet.StoryBooks, search);
        }

        bool ValidDeleteTerm = false;
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;

            if (search != "")
            {
                int findTerm = dataTermsTableAdapter.FillBySearch(englishClassDataSet.DataTerms, search, search);

                if (findTerm == 1)
                    ValidDeleteTerm = true;
                else
                    ValidDeleteTerm = false;
            }
            else
            {
                ShowAllTerms();
            }
        }

        private void BtnDeleteTerm_Click(object sender, EventArgs e)
        {
            if (ValidDeleteTerm)
            {
                try
                {
                    int.Parse(txtSearch.Text);

                    int deleted = termsTableAdapter.DeleteTerm(txtSearch.Text);

                    if (deleted >= 1)
                        MsgSuccess();

                    ShowAllTerms();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("برای حذف ID وارد کنید", "Warning",
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
