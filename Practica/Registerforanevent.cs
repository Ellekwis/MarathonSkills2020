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
    public partial class Form5 : Form
    {
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public Form5()
        {
            InitializeComponent();
            timer1.Start();
        }
        public int a1=0;
        public int a2 = 0;
        public int a3 = 0;
        public int b1=0;
        public int b2 = 0;
        public int b3 = 0;
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a1 = 145;
                label16.Text = Convert.ToString(b1+b2+b3 + a1+a2+a3);
            
            }
            else 
            {
                a1 = 0;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                a2 = 75;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
                
            }
            else
            {
                a2 = 0;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                a3 = 20;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
             
            }
            else
            {
                a3 = 0;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                b1 = 0;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1+a2+a3);
            }
            else
            {
                b1 = 0;
                label16.Text = "0";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                b2 = 20;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
            }
            else
            {
                b2 = 20;
                label16.Text = "0";
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                b3 = 45;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
            }
            else
            {
                b3 = 0;
                label16.Text = "0";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            RegistrationConfirmation reg = new RegistrationConfirmation();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
            reg.ShowDialog();
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form9 reg = new Form9();
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
