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
    public partial class Form5 : Form
    {
        public int runnerid;
        public int id1
        {
            get
            {
                return runnerid;
            }
            set
            {
                runnerid = value;
            }
        }
           
        
            
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
        string racekit;
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                b1 = 0;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1+a2+a3);
                racekit = "A";
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
                racekit = "B";
            }
            else
            {
                b2 = 0;
                label16.Text = "0";
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                b3 = 45;
                label16.Text = Convert.ToString(b1 + b2 + b3 + a1 + a2 + a3);
                racekit = "C";
            }
            else
            {
                b3 = 0;
                label16.Text = "0";
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection();
            scc.Regevent(DateTime.Now.ToString(), racekit, label16.Text, textBox1.Text, comboBox1.Text,id1);
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

        private void Form5_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CharityName FROM charity";

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = reader[0].ToString();
                comboBox1.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
