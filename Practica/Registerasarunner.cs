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
    public partial class Form4 : Form
    {
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }
        string cb2;
        string cb1;
        private void Form4_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = " SELECT CountryName FROM country";

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = reader[0].ToString();
                comboBox2.Items.Add(item);
            }
            reader.Close();
            conn.Close();

            button2.Enabled = false;
            /////////////////////////////////////////////////////
            /*
            string connStr1 = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn1 = new MySqlConnection(connStr1);
            conn.Open();
            string sql1 = " SELECT CountryName FROM country";

            MySqlCommand command1 = new MySqlCommand(sql1, conn1);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                string item1= reader1[0].ToString();
                comboBox1.Items.Add(item1);
            }
            reader1.Close();
            conn1.Close();
            */
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection();
            // Form4 f4 = this;
            string date =dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
            scc.RegRunner(textBox1.Text,textBox4.Text,textBox5.Text,textBox2.Text,comboBox1.Text,date,comboBox2.Text);
            
            ActiveForm.Hide();
            Form5 reg = new Form5();
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
        }

        bool passCheck(string password)
        {
            if (password.Length >5)
            {
                string symb = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890!@#$%^&*()_+!№?";
                if (password.IndexOfAny(symb.ToCharArray())==-1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           // passCheck(textBox2.Text);
            
            if (textBox2.Text != "")
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }

            if  (passCheck(textBox2.Text) == true)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        } 
         
        private void TextBox4_TextChanged(object sender, EventArgs e)
        { 
            if (textBox4.Text != "")
            {
                label10.Visible =  false; 
            }
            else
            {
                label10.Visible = true;
            } 
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                label12.Visible = false;
            }
            else
            {
                label12.Visible = true;
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

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb2 = Convert.ToString(comboBox2.SelectedItem);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb1 = Convert.ToString(comboBox1.SelectedItem);
        }
    }
    }

