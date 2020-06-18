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

    public partial class Form9 : Form
    {
        public int runnerid;
        public int runnerid1
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
        public Form9()
        {
            SqlConnection scc = new SqlConnection();
            InitializeComponent();
            timer1.Start();
            //Form9 f9 = new Form9();
            MyRaceResults mrs = new MyRaceResults();
            runnerid= mrs.runnerid;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form5 reg = new Form5();
            reg.ShowDialog();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            EditRunnerProfile reg = new EditRunnerProfile();
            reg.ShowDialog();
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           
            ActiveForm.Hide();
           MyRaceResults reg = new MyRaceResults();
            reg.ShowDialog();
            Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MySponsorship reg = new MySponsorship();
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
            MainScreen reg = new MainScreen();
            reg.ShowDialog();
            Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для получения дополнительной информации пожалуйста свяжитесь с координаторами\nТЕЛЕФОН:+55 119988 7766 \nEMAIL: dean.pinilla@gmail.com\nvernon.ankeny@nster.gov\nw.bubash@manda.com","КОНТАКТЫ");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan totalTime = voteTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
    }
}
