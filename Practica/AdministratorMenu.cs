using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class AdministratorMenu : Form
    {
        public AdministratorMenu()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
            reg.ShowDialog();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
            reg.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            UserManagment reg = new UserManagment();
            reg.ShowDialog();
            Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            ManageCharaties reg = new ManageCharaties();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            VolounteerManagment reg = new VolounteerManagment();
            reg.ShowDialog();
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form35 reg = new Form35();
            reg.ShowDialog();
            Close();
        }
    }
}
