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
    public partial class MySponsorship : Form
    {
        public MySponsorship()
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

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MySponsorship reg = new MySponsorship();
            reg.ShowDialog();
            Close();
        }
    }
}
