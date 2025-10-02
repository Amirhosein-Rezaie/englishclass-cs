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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        public string Code = "";

        public void ShowAll()
        {
            this.dataStudentsTableAdapter.Fill(englishClassDataSet.DataStudents, Code);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.Text = studentsTableAdapter.SelectName(Code);

            ShowAll();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;

            if (search != "")
            {
                dataStudentsTableAdapter.FillBySearch(englishClassDataSet.DataStudents, Code, search, search, search);
            }
            else
            {
                ShowAll();
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (comboPay.SelectedIndex >= 0)
            {
                string searchCombo = comboPay.Text;

                bool searchPay;

                if (searchCombo == "پرداخت شده")
                    searchPay = true;
                else
                    searchPay = false;

                dataStudentsTableAdapter.FillByPayed(englishClassDataSet.DataStudents, Code, searchPay);
            }
        }

        private void BtnShoAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
