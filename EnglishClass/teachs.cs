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
    public partial class teachs : Form
    {
        public teachs()
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

        public void ShowAllTeachs()
        {
            this.dataTeachTableAdapter.Fill(this.englishClassDataSet.DataTeach);
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

        private void Teachs_Load(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.englishClassDataSet.Teachers);

            this.studentsTableAdapter.Fill(this.englishClassDataSet.Students);

            ShowAllTeachs();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string TermID = txtTermID.Text;
            string StdCode = txtStdCode.Text;
            string TeachID = txtTeachID.Text;

            if (TermID != "" && StdCode != "" && TeachID != "")
            {
                int StdID;

                try
                {
                    StdID = (int)studentsTableAdapter.selectID(StdCode);
                }
                catch (System.InvalidOperationException)
                {
                    MsgNotFound();
                    return;
                }

                if (StdID != 0)
                {
                    DialogResult payed;
                    payed = MessageBox.Show("آیا شهریه پرداخت شده است ... !", "سوال ... ؟",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                    if (payed == DialogResult.Yes)
                    {
                        try
                        {
                            teachTableAdapter.register(TeachID, StdID, int.Parse(TermID), 0, 0, 0, 0, 0, 0, true);
                        }
                        catch (System.Data.OleDb.OleDbException)
                        {
                            MsgReptitive();
                            return;
                        }
                        ShowAllTeachs();
                        MsgSuccess();
                    }
                    else
                    {
                        DialogResult sure;
                        sure = MessageBox.Show("آیا مطمئن هستید ... ؟", "سوال ... ؟",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
                        if (sure == DialogResult.Yes)
                        {
                            teachTableAdapter.register(TeachID, StdID, int.Parse(TermID), 0, 0, 0, 0, 0, 0, false);
                            ShowAllTeachs();
                            MsgSuccess();
                        }
                    }
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

        private void TxtTeachSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtTeachSearch.Text;

            if (search != "")
            {
                groupBoxGrades.Enabled = true;
                int find = dataTeachTableAdapter.FillByChangeGrades(englishClassDataSet.DataTeach, search);

                if (find > 0)
                {
                    groupBoxGrades.Enabled = true;
                }
                else
                {
                    groupBoxGrades.Enabled = false;

                    foreach (object obj in groupBoxGrades.Controls)
                    {
                        if (obj is TextBox)
                        {
                            TextBox txt = (TextBox)obj;

                            txt.Clear();
                        }
                    }
                }
            }
            else
            {
                groupBoxGrades.Enabled = false;
                ShowAllTeachs();
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            string ID = txtTeachSearch.Text;

            string ClassGrade = txtClassGrade.Text;
            string sBookGrade = txtSBookGrade.Text;
            string videoGrade = txtVideoGrade.Text;
            string FilmGrade = txtFilmGrade.Text;
            string WbookGrade = txtWBookGrade.Text;
            string ExamGrade = txtExamGrade.Text;

            if (ClassGrade != "" && sBookGrade != "" && videoGrade != "" &&
                FilmGrade != "" && WbookGrade != "" && ExamGrade != "")
            {
                teachTableAdapter.UpdateGrades(int.Parse(ClassGrade), int.Parse(FilmGrade),
                    int.Parse(videoGrade), int.Parse(sBookGrade), int.Parse(WbookGrade), int.Parse(ExamGrade), ID);

                MsgSuccess();
            }
            else
            {
                MsgEmpty();
            }

            TxtTeachSearch_KeyUp(null, null);
        }

        bool ValidChangePay = false;
        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;

            if (search != "")
            {
                int find = dataTeachTableAdapter.FillBySearch(englishClassDataSet.DataTeach, search, search, search);
                if (find == 1)
                    ValidChangePay = true;
                else
                    ValidChangePay = false;
            }
            else
            {
                ShowAllTeachs();
            }
        }

        private void BtnChangePay_Click(object sender, EventArgs e)
        {
            if (ValidChangePay)
            {
                bool pay;

                if (PayCombo.Text == "پرداخت شده")
                    pay = true;
                else
                    pay = false;

                if (PayCombo.Text == "")
                {
                    MsgEmpty();
                    return;
                }

                teachTableAdapter.ChangeThePay(pay, txtSearch.Text);

                MsgSuccess();

                ShowAllTeachs();
            }
            else
            {
                MsgSelectOne();
            }
        }

        private void TxtClassGrade_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox Grade = sender as TextBox;

                string number = Grade.Text;

                if (e.KeyCode != Keys.Back)
                {
                    if (!(int.Parse(number) >= 0 && int.Parse(number) <= 40))
                    {
                        MessageBox.Show("نمره بین 1 تا 40 مجاز است");

                        Grade.Clear();
                    }
                }
            }
        }

        private void MinMaxGrade_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox Grade = sender as TextBox;

                string number = Grade.Text;

                if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter)
                {
                    int max;

                    if (Grade.Name == "txtFilmGrade" || Grade.Name == "txtVideoGrade"
                        || Grade.Name == "txtSBookGrade" || Grade.Name == "txtClassGrade")
                        max = 10;
                    else if (Grade.Name == "txtWBookGrade")
                        max = 20;
                    else
                        max = 40;

                    if (!(int.Parse(number) >= 0 && int.Parse(number) <= max))
                    {
                        MessageBox.Show($"نمره بین 0 تا {max} مجاز است", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Grade.Clear();
                    }
                }
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllTeachs();
        }
    }
}
