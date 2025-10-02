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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        // variables
        public login loginForm;
        const string Title = "English Class - ";

        private void BtnEnterStds_Click(object sender, EventArgs e)
        {
            stds Stds = new stds();
            Stds.Show();
        }

        private void BtnEnterTerms_Click(object sender, EventArgs e)
        {
            terms trms = new terms();
            trms.Show();
        }

        private void BtnEnterTeachs_Click(object sender, EventArgs e)
        {
            teachs teachs = new teachs();
            teachs.Show();
        }

        private void BtnEnterBooks_Click(object sender, EventArgs e)
        {
            books books = new books();
            books.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //this.Text = Title + loginForm.username;
        }

        private void BtnEnterTeachers_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void BtnEnterRooms_Click(object sender, EventArgs e)
        {
            LevelRooms lvlrooms = new LevelRooms();
            lvlrooms.Show();
        }

        private void BtnEnterAdmins_Click(object sender, EventArgs e)
        {
            if (loginForm.username.ToLower() == "admin" && loginForm.password.ToLower() == "admin")
            {
                admins adminsForm = new admins();
                adminsForm.Show();
            }
            else
            {
                MessageBox.Show("شما به این بخش دسترسی ندارید", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
