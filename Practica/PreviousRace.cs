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
    public partial class PreviousRace : Form
    {
        public PreviousRace()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MoreInformation reg = new MoreInformation();
            reg.ShowDialog();
            Close();
        }
    }
}
