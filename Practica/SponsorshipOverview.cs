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
    public partial class SponsorshipOverview : Form
    {
        public SponsorshipOverview()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            CoordinatorMenu reg = new CoordinatorMenu();
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
    }
}
