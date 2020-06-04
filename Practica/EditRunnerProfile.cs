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
    public partial class EditRunnerProfile : Form
    {
        public EditRunnerProfile()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form9 reg = new Form9();
            reg.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename;
                this.openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png";

                // openFileDialog1.ShowDialog();
                filename = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                filename = Convert.ToString(openFileDialog1.FileName);
                label16.Text = filename;
                label15.Visible = false;
            }
            else
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
           Form9 reg = new Form9();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
           Form9 reg = new Form9();
            reg.ShowDialog();
            Close();
        }
    }
}
