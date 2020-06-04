using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica
{
    public partial class Form6 : Form
    {
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public Form6()
        {
            InitializeComponent();
            SqlConnection runners = new SqlConnection();
            Form6 sf = this;
            runners.Runners(sf);
            timer1.Start();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label21.Text = "$50";
        }
        int p; 
        private void Button1_Click(object sender, EventArgs e)
        {
           // string a = Convert.ToString(textBox7.Text);
           // int c =Convert.ToInt32(a);
           // textBox7.Text = Convert.ToString(c - 1);
           if (textBox7.Text == "")
            {
                p = 0;
            }
            else
            {
                p = Convert.ToInt32(textBox7.Text);

            }
           if (p==0)
            {

            }
            else
            {
                p -= 10;
                textBox7.Text = Convert.ToString(p);
            }
           
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
           if (textBox7.Text == "")
            {
                p = 0;
                p += 10;
                textBox7.Text = Convert.ToString(p);
            }
           else
            {
                p = Convert.ToInt32(textBox7.Text);
                p += 10;
                textBox7.Text = Convert.ToString(p);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text==""|| textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
               
                 MessageBox.Show("Не все поля заполнены, либо сумма пожертвования равна нулю");
            }
            else
            {
                string str;
                string[] str1;
                str = comboBox1.Text;
                str1 = str.Split(' ');
                SqlConnection scc = new SqlConnection();
                Form6 sp = this;
                scc.SponsorReg(sp, str1[2], textBox4.Text, textBox7.Text);

                Sponsorship sc = new Sponsorship(comboBox1.Text, label18.Text, label21.Text);
                ActiveForm.Hide();
                //Sponsorship reg = new Sponsorship();
                sc.ShowDialog();
                Close(); 
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MainScreen newForm = new MainScreen();
            newForm.Show();
            this.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 16;

            string cardnumber;
            int length;
            if (textBox2.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
                cardnumber = textBox2.Text;
                length = cardnumber.Length;

            }

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)&&number!=8)
            {
                e.Handled = true;
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                p = 0;
                label21.Text ="$0";
            }
            else
            {
                p = Convert.ToInt32(textBox7.Text);
                label21.Text = "$" + textBox7.Text;
            }
        }
         string cb;
            string [] cbmas;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cb = comboBox1.Text;
            cbmas = cb.Split(' ');
            SqlConnection cb1 = new SqlConnection();
            Form6 sr = this;
            cb1.Charity(sr, cbmas[2]);
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
            if (textBox7.Text == "")
            {
                label16.Visible = true;
            }
            else
                label16.Visible = false;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 2;
            if (textBox7.Text == "")
            {
                label17.Visible = true;
            }
            else
                label17.Visible = false;
            if (textBox7.Text == "")
            {
                label13.Visible = true;
            }
            else
                label13.Visible = false;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label15.Visible = true;
            }
            else
                label15.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label16.Visible = true;
            }
            else
                label16.Visible = false;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label10.Visible = true;
            }
            else
                label10.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime = voteTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
    }
}
