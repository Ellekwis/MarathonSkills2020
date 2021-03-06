﻿using System;
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
    public partial class MyRaceResults : Form
    {
      public  int runnerid;
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
        public MyRaceResults()
        {
            InitializeComponent();
            timer1.Start();
            //runnerid = runnerid1;
            SqlConnection scc = new SqlConnection();
            //MyRaceResults mrf = new MyRaceResults();
            MyRaceResults mrf = this;
            scc.MyRaceResults(mrf, runnerid);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form9 reg = new Form9();
            reg.ShowDialog();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MyRaceResults reg = new MyRaceResults();
            reg.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            ActiveForm.Hide();
            PreviousRace reg = new PreviousRace();
            reg.ShowDialog();
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime = voteTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void MyRaceResults_Load(object sender, EventArgs e)
        {
           
        }
    }
}
