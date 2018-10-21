using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace WindowsFormsApp3
{
    class database_work
    {
        private MySqlConnection connect;
        public database_work()
        {
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "127.0.0.1";
            mysqlCSB.Port = 3306;
            mysqlCSB.Database = "bazadoors";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "";
            mysqlCSB.CharacterSet = "utf8";
            mysqlCSB.SslMode = MySqlSslMode.None;
            connect = new MySqlConnection(mysqlCSB.ConnectionString);
        }

        public DataTable getfield()
        {
            DataTable answer=new DataTable();
            MySqlCommand Question = connect.CreateCommand();
            Question.CommandText = "SELECT id, CONCAT( RPAD(materials,50,' '), '///', price) AS materials FROM components";
            try
            {
                connect.Open();
                Question.ExecuteNonQuery();
                MySqlDataAdapter admy = new MySqlDataAdapter(Question);
                admy.Fill(answer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connect.Close();
            }
            return answer;
        }
        public float getprice(int id)
        {
            float answer = 0;
            MySqlCommand Question = connect.CreateCommand();
            Question.CommandText = "SELECT price FROM components where id = "+id.ToString();
            try
            {
                connect.Open();
                using (DbDataReader reader = Question.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answer = reader.GetFloat(0);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connect.Close();
            }
            return answer;
        }
        public void updateprice(int id, string price)
        {
            MySqlCommand Question = connect.CreateCommand();
            Question.CommandText = "UPDATE `bazadoors`.`components` SET `price`='"+ price.Replace(',','.') + "' WHERE  `id`=" + id.ToString();
            try
            {
                connect.Open();
                Question.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
