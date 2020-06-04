using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Practica
{
    public class SqlConnection
    {
        public string Connection()
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT Date From eventdate";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string name = command.ExecuteScalar().ToString();
            conn.Close();
            return name;
        }
        public void Runners(Form6 sf)
        {

            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            // string sql = "SELECT runner.RunnerId, user.FirstName, user.LastName FROM user JOIN runner ON user.Email = runner.Email AND SELECT runner.CountryCode, country.CountryName, country.CountryCode FROM runner JOIN country ON runner.CountryCode = country.CountryName";
            string sql = "SELECT runner.RunnerId, user.FirstName, user.LastName,country.CountryName FROM user JOIN runner ON user.Email = runner.Email JOIN country ON runner.CountryCode = country.CountryCode";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                sf.comboBox1.Items.Add(reader[1].ToString() + " " + reader[2].ToString() + " " + reader[0].ToString() + " (" + reader[3].ToString() + ")");
            }
            reader.Close();
            conn.Close();
        }
        public void Charity(Form6 sr, string str)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CharityName FROM registration JOIN charity ON registration.CharityId = Charity.CharityId WHERE registration.RunnerId = " + str;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                sr.label18.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ListOfCharReader(ListofCharities loc)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CharityLogo, CharityName, CharityDescription FROM charity";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                loc.imgAdd(reader[0].ToString(), reader[1].ToString() + ":" + reader[2].ToString());
                i++;
            }
            reader.Close();
            conn.Close();
        }
        public void Login(string email, string password, Login lg)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT Password, Email,Roleid FROM user";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            bool pas = false;
            bool ema = false;
            while (reader.Read())
            {
                if (reader[1].ToString() == email)
                {
                    ema = true;
                    pas = true;
                    if (reader[0].ToString() == password)
                     {
                        if (reader[2].ToString() == "R")
                         {
                            lg.Hide();
                            Form9 reg = new Form9();
                            reg.ShowDialog();
                            lg.Close();
                         }
                        else
                        {
                            if (reader[2].ToString() == "A")
                            {
                                lg.Hide();
                                AdministratorMenu reg = new AdministratorMenu();
                                reg.ShowDialog();
                                lg.Close();
                            }
                            else
                            {
                                if (reader[2].ToString() == "C")
                                {
                                    lg.Hide();
                                    CoordinatorMenu reg = new CoordinatorMenu();
                                    reg.ShowDialog();
                                    lg.Close();
                                }
                            }
                        }
                    }
                }
                
            }
            if (ema = false)
            {
                MessageBox.Show("Неверный Email");
            }
            else
            {
                if (pas=false)
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            
        }
        public void SponsorReg(Form6 sp,string runid, string spname, string amount)
        {
            string connStr = "Server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = " SELECT RegistrationId FROM registration WHERE RunnerId = " + runid;

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            string regid = "";

            while (reader.Read())
            {
                regid = reader[0].ToString();
            }
            string sql1 = "INSERT INTO sponsorship(SponsorName,RegistrationId,Amount) VALUES('" + spname + "', '" + regid + "', '" + amount + "')";
            reader.Close();
            command = new MySqlCommand(sql1, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }
        public void RegRunner(string email, string firstname, string lastname, string password, string gender, string dateBirth, string countryName)
        {
            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CountryCode FROM country WHERE CountryName = '" + countryName + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string countCode = command.ExecuteScalar().ToString();
            string sql1 = "INSERT INTO user(Email,Password,FirstName,LastName,RoleId) VALUES('" + email + "', '" + password + "', '" + firstname + "', '" + lastname + "', 'R')";
            string sql2 = "INSERT INTO runner(Email,Gender,DateOfBirth,CountryCode) VALUES('" + email + "', '" + gender + "', '" + dateBirth + "', '" + countCode + "')";
            command = new MySqlCommand(sql1, conn);
            command.ExecuteNonQuery();
            command = new MySqlCommand(sql2, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }

}
