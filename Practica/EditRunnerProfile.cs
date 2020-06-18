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
   
    public partial class EditRunnerProfile : Form
    {
        int runnerid;
        string Email;
        public string emai
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        static DateTime GetStartTime()
        {
            SqlConnection scc = new SqlConnection();
            string date = scc.Connection();

            return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public EditRunnerProfile()
        {
            InitializeComponent();
            Form5 f5 = new Form5();
            runnerid=f5.id1;
            timer2.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form9 reg = new Form9();
            reg.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename;
                this.openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png";
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

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection();
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
            Form5 f5 = new Form5();
            runnerid = f5.id1;
            // scc.Editrunnerprofile(emai,textBox4.Text,textBox5.Text,comboBox1.Text,date,comboBox2.Text,textBox2.Text,runnerid);
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox4.Text == "" && textBox5.Text == "" && textBox2.Text == "")
                    {

                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 0);
                    }
                    if (textBox4.Text != "" && textBox5.Text == "" && textBox2.Text == "")
                    {

                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 1);
                    }
                    if (textBox4.Text != "" && textBox5.Text != "" && textBox2.Text == "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 2);
                    }
                    if (textBox4.Text == "" && textBox5.Text != "" && textBox2.Text == "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 3);
                    }
                    if (textBox4.Text != "" && textBox5.Text != "" && textBox2.Text != "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 4);
                    }
                    if (textBox4.Text == "" && textBox5.Text == "" && textBox2.Text != "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 5);
                    }
                    if (textBox4.Text == "" && textBox5.Text != "" && textBox2.Text != "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 6);
                    }
                    if (textBox4.Text != "" && textBox5.Text == "" && textBox2.Text != "")
                    {
                        scc.Editrunnerprofile(emai, textBox4.Text, textBox5.Text, comboBox1.Text, date, comboBox2.Text, textBox2.Text, runnerid, 7);
                    }
                }
            
            else
            {
                MessageBox.Show("Какие-то поля заполнены неправильно");
            }

            ActiveForm.Hide();
           Form9 reg = new Form9();
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

        private void EditRunnerProfile_Load(object sender, EventArgs e)
        {
            label6.Text = Email;
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
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime = voteTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
    }
}
