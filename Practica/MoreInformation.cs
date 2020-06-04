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
    public partial class MoreInformation : Form
    {
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public MoreInformation()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            AboutMarathon reg = new AboutMarathon();
            reg.ShowDialog();
            Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            ListofCharities reg = new ListofCharities();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            PreviousRace reg = new PreviousRace();
            reg.ShowDialog();
            Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            BMI reg = new BMI();
            reg.ShowDialog();
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            HowLong reg = new HowLong();
            reg.ShowDialog();
            Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            BMR reg = new BMR();
            reg.ShowDialog();
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
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
