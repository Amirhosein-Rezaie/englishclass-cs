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
    public partial class LevelRooms : Form
    {
        public LevelRooms()
        {
            InitializeComponent();
        }

        public void ShowAllRooms()
        {
            this.classRoomsTableAdapter.Fill(this.englishClassDataSet.ClassRooms);
        }

        public void ShowAllLevels()
        {
            this.levelsTableAdapter.Fill(this.englishClassDataSet.Levels);
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

        private void Rooms_Load(object sender, EventArgs e)
        {
            ShowAllLevels();

            ShowAllRooms();
        }

        // main
        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;

            if (search != "")
            {
                classRoomsTableAdapter.FillBySearch(englishClassDataSet.ClassRooms, int.Parse(search));
            }
            else
            {
                ShowAllRooms();
            }
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;

            if (ID != "")
            {
                try
                {
                    classRoomsTableAdapter.AddRoom(int.Parse(ID));
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                    ShowAllRooms();
                    return;
                }

                ShowAllRooms();

                MsgSuccess();
            }
            else
            {
                MsgEmpty();
            }
        }

        // levels
        private void BtnAddLvl_Click(object sender, EventArgs e)
        {
            string name = txtLevel.Text;

            if (name != "")
            {
                try
                {
                    levelsTableAdapter.AddLevel(name);
                    MsgSuccess();
                }
                catch (System.Data.OleDb.OleDbException)
                {
                    MsgReptitive();
                    ShowAllLevels();
                    return;
                }
            }
            else
            {
                MsgEmpty();
            }

            ShowAllLevels();
        }

        bool ValidDeleteLvl = false;
        private void TxtSearchlvl_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearchlvl.Text;

            if (search != "")
            {
                int find = levelsTableAdapter.FillBySearch(englishClassDataSet.Levels, search);

                if (find == 1)
                    ValidDeleteLvl = true;
                else
                    ValidDeleteLvl = false;
            }
            else
            {
                ShowAllLevels();
            }
        }

        private void BtnDeleteLvl_Click(object sender, EventArgs e)
        {
            if (ValidDeleteLvl)
            {
                int deleted = levelsTableAdapter.deleteLevel(txtSearchlvl.Text);

                if (deleted >= 1)
                {
                    MsgSuccess();
                }
            }
            else
            {
                MsgSelectOne();
            }

            ShowAllLevels();
        }
    }
}
