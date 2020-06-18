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
        int runnerid1;
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
        public int runnerid(string email)
        {
            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT RunnerId FROM runner WHERE Email= '"+email+"'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command = new MySqlCommand(sql, conn);
            int id =Convert.ToInt32(command.ExecuteScalar());
            return id;
        }
        public void Regevent (string regdatetime, string racekit,string cost, string sponsortarget,string charityname,int id1)
        {
            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CharityId FROM charity WHERE CharityName= '"+ charityname +"'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string charicode =Convert.ToString(command.ExecuteScalar());

            string sql1 = "INSERT INTO registration(RegistrationDateTime, RaceKitOptionId,Cost,SponsorshipTarget,RunnerId,RegistrationStatusId,CharityId) VALUES('"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + racekit + "','" + cost+ "','" + sponsortarget + "'," + id1 + ",'" + 1 + "','" + charicode + "')";
            command = new MySqlCommand(sql1, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void Editrunnerprofile(string email,string name, string lastname, string gender, string dateBirth, string country, string password,int runner,int type)
        {
            /*
            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT CountryCode FROM country WHERE CountryName = '" + country + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string countcode = command.ExecuteScalar().ToString();
            string sql1 = "UPDATE runner SET Gender = '" + gender + "',DateOfBirth = '" + dateBirth + "',CountryCode = '" + countcode + "'WHERE RunnerId = '" + runner+ "' ";
            string sql2 = "UPDATE user SET Password = '" + password + "',FirstName = '" + name + "',LastName = '" + lastname + "' WHERE Email = '" + email + "'";
            command = new MySqlCommand(sql1, conn);
            command.ExecuteNonQuery();
            command = new MySqlCommand(sql2, conn);
            command.ExecuteNonQuery();
            conn.Close();
            */
            string connStr = "server=localhost;user=root;database=pafenov;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sqlcount = "SELECT CountryCode FROM country WHERE CountryName ='" + country + "'";
            MySqlCommand command = new MySqlCommand(sqlcount, conn);
            string countCode = command.ExecuteScalar().ToString();

            if (type == 0)
            {

                string sql = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "' CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            if (type == 1)
            {
                string sql2 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "', CountryCode = '" + countCode + "'WHERE RunnerId =" +runner;
                command = new MySqlCommand(sql2, conn);
                command.ExecuteNonQuery();
                string sql3 = "UPDATE user SET FirstName = '" + name + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql3, conn);
                command.ExecuteNonQuery();
            }
            if (type == 2)
            {
                string sql4 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "',  CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql4, conn);
                command.ExecuteNonQuery();
                string sql5 = "UPDATE user SET FirstName = '" + name + "', LastName = '" + lastname + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql5, conn);
                command.ExecuteNonQuery();
            }
            if (type == 3)
            {
                string sql6 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "', CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql6, conn);
                command.ExecuteNonQuery();
                string sql7 = "UPDATE user SET LastName ='" + lastname + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql7, conn);
                command.ExecuteNonQuery();
            }
            if (type == 4)
            {
                string sql8 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "', CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql8, conn);
                command.ExecuteNonQuery();
                string sql9 = "UPDATE user SET Password = '" + password + "', FirstName= '" + name + "',LastName = '" + lastname + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql9, conn);
                command.ExecuteNonQuery();
            }
            if (type == 5)
            {
                string sql9 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + name + "', CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql9, conn);
                command.ExecuteNonQuery();
                string sql10 = "UPDATE user SET Password = '" + password + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql10, conn);
                command.ExecuteNonQuery();
            }
            if (type == 6)
            {
                string sql8 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "', CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql8, conn);
                command.ExecuteNonQuery();
                string sql9 = "UPDATE user SET Password = '" + password + "', LastName = '" + lastname + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql9, conn);
                command.ExecuteNonQuery();
            }
            if (type == 7)
            {
                string sql8 = "UPDATE runner SET Gender = '" + gender + "', DateOfBirth = '" + dateBirth + "', CountryCode = '" + countCode + "'WHERE RunnerId =" + runner;
                command = new MySqlCommand(sql8, conn);
                command.ExecuteNonQuery();
                string sql9 = "UPDATE user SET Password = '" + password + "', FirstName= '" + name + "' WHERE Email = '" + email + "'";
                command = new MySqlCommand(sql9, conn);
                command.ExecuteNonQuery();
            }



            conn.Close();
        }
        public void MyRaceResults (MyRaceResults mrf,int runid)
        {

            string connStr = "server=localhost;user=root;database=ketrar;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT Gender FROM runner WHERE RunnerId = '"+  runid+"'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string gender = command.ExecuteScalar().ToString();
            mrf.label4.Text += " " + gender;
            string sql1 = "SELECT DateOfBirth FROM runner WHERE RunnerId =  '" + runid + "'";
            command = new MySqlCommand(sql1, conn);
            DateTime date = Convert.ToDateTime(command.ExecuteScalar());

            int dt = DateTime.Now.Year - date.Year;

            if (dt < 18)
            {
                mrf.label5.Text += " до 18";
            }
            else
            {
                if (dt >= 18 && dt <= 29)
                {
                    mrf.label5.Text += " от 18 до 29";
                }
                else
                {
                    if (dt >= 30 && dt <= 39)
                    {
                        mrf.label5.Text += " от 30 до 39";
                    }
                    else
                    {
                        if (dt >= 40 && dt <= 55)
                        {
                            mrf.label5.Text += " от 40 до 55";
                        }
                        else
                        {
                            if (dt >= 56 && dt <= 70)
                            {
                                mrf.label5.Text += " от 56 до 70";
                            }
                            else
                            {
                                if (dt > 70)
                                {
                                    mrf.label5.Text += " более 70";
                                }
                            }
                        }
                    }
                }
            }

            string sql3 = "SELECT RegistrationId FROM registration WHERE RunnerId =  '" + runid + "'";
            command = new MySqlCommand(sql3, conn);

            int regid = Convert.ToInt32(command.ExecuteScalar());

            string sql4 = "SELECT marathon.CityName,marathon.YearHeld,eventtype.EventTypeName,runner.DateOfBirth, `RaceTime`, `BibNumber` FROM registrationevent JOIN event ON registrationevent.EventId = event.EventId JOIN marathon ON event.MarathonId = marathon.MarathonId JOIN eventtype ON event.EventTypeId=eventtype.EventTypeId JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId JOIN runner ON registration.RunnerId=runner.RunnerId WHERE registrationevent.RegistrationId = " + regid;

            command = new MySqlCommand(sql4, conn);

            MySqlDataReader reader = command.ExecuteReader();
            bool a = reader.HasRows;
            while (reader.Read())
            {
                string mar = reader[1].ToString() + " " + reader[0].ToString();
                string dist;
                if (reader.IsDBNull(2))
                {
                    dist = "";
                }
                else
                    dist = reader[2].ToString();
                int hour;
                int min;
                int sec;
                if (reader.IsDBNull(4))
                {
                    hour = 0;
                    min = 0;
                    sec = 0;
                }
                else
                {
                    hour = Convert.ToInt32(reader.GetValue(4)) / 3600;
                    min = (Convert.ToInt32(reader.GetValue(4)) - hour * 3600) / 60;
                    sec = Convert.ToInt32(reader.GetValue(4)) - hour * 3600 - min * 60;
                }


                ListViewItem item = new ListViewItem(new string[] { mar, dist, hour.ToString() + "h " + min.ToString() + "m " + sec.ToString() + "s", reader[5].ToString(), reader[3].ToString() });
                mrf.listView1.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
    }

}
