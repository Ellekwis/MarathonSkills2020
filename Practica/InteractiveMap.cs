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
    public partial class InteractiveMap : Form
    {
        public InteractiveMap()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            AboutMarathon reg = new AboutMarathon();
            reg.ShowDialog();
            Close();
        }

        private void LblNum1_Click(object sender, EventArgs e)
        {
            Punct1 fp1 = new Punct1();
            fp1.ShowDialog();
        }

        private void LblNum2_Click(object sender, EventArgs e)
        {
            Punct2 fp1 = new Punct2();
            fp1.ShowDialog();
        }

        private void LblNum3_Click(object sender, EventArgs e)
        {
            Punct3 fp1 = new Punct3();
            fp1.ShowDialog();
        }

        private void LblNum4_Click(object sender, EventArgs e)
        {
            Punct4 fp1 = new Punct4();
            fp1.ShowDialog();
        }

        private void LblNum5_Click(object sender, EventArgs e)
        {
            Punct5 fp1 = new Punct5();
            fp1.ShowDialog();
        }

        private void LblNum6_Click(object sender, EventArgs e)
        {
            Punct6 fp1 = new Punct6();
            fp1.ShowDialog();
        }

        private void LblNum7_Click(object sender, EventArgs e)
        {
            Punct7 fp1 = new Punct7();
            fp1.ShowDialog();
        }

        private void LblNum8_Click(object sender, EventArgs e)
        {
            Punct8 fp1 = new Punct8();
            fp1.ShowDialog();
        }
    }
}
