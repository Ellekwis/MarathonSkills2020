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
    public partial class AboutMarathon : Form
    {
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public AboutMarathon()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            InteractiveMap reg = new InteractiveMap();
            reg.ShowDialog();
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MoreInformation reg = new MoreInformation();
            reg.ShowDialog();
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            InteractiveMap reg = new InteractiveMap();
            reg.ShowDialog();
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime = voteTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
    }
}
