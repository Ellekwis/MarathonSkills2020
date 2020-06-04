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
    public partial class MainScreen : Form
    {
        static DateTime GetStartTime()
        {
        SqlConnection scc = new SqlConnection();
        string date = scc.Connection();

        return Convert.ToDateTime(date);
        }
        DateTime voteTime = GetStartTime();
        public MainScreen()
        {
            InitializeComponent();
            timer1.Start();
        }
       
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form2 reg = new Form2();
            reg.ShowDialog();
            Close();


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form6 sponsor = new Form6();
            sponsor.ShowDialog();
            Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MoreInformation moreinf = new MoreInformation();
            moreinf.ShowDialog();
            Close();
        }
        
 private void MainScreen_Load(object sender, EventArgs e) => timer1.Start();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime =voteTime  - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
       
    }
}
