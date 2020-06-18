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
    public partial class Login : Form
    {
       public int runnerid;
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();

        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
           
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT RunnerId FROM runner WHERE Email ='" + textBox1.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string runid = command.ExecuteScalar().ToString() ;
            runnerid =Convert.ToInt32(runid);
           // conn.Close();
            Form9 f9 = new Form9();
            runnerid = f9.runnerid1;
            SqlConnection scc = new SqlConnection();
            Login l = this;
            scc.Login(textBox1.Text, textBox2.Text, l);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainScreen reg = new MainScreen();
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
