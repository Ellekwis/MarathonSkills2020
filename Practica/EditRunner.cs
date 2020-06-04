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
    public partial class EditRunner : Form
    {
        public EditRunner()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Managearunner reg = new Managearunner();
            reg.ShowDialog();
            Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            EditRunner reg = new EditRunner();
            reg.ShowDialog();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Managearunner reg = new Managearunner();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Managearunner reg = new Managearunner();
            reg.ShowDialog();
            Close();
        }
    }
}
