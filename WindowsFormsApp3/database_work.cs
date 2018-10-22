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
        /// <summary>
        /// Работчик с базой данных
        /// </summary>
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
        /// <summary>
        /// Пулучить список всех компонентов из базы данных
        /// </summary>
        /// <returns>Список массивов из 3 строк [id, наименование, цена]</returns>
        public List<string[]> getfield()
        {
            List<string[]> answer = new List<string[]>(); //То, что мы вернем
            
            MySqlCommand Question = connect.CreateCommand();//Создаем экземпляр вопроса к бд
            Question.CommandText = "SELECT id, materials, price FROM components";//Пищем запрос
            try
            {
                connect.Open();
                using (DbDataReader reader = Question.ExecuteReader())//Выполняем запрос и читаем ответ
                {
                    while (reader.Read())//Пока идет кортеж
                    {
                        string[] component = new string[3]; //Создаем массив из трех строк
                        component[0] = reader.GetString(0);
                        component[1] = reader.GetString(1);
                        component[2] = reader.GetString(2);//В каждую строку накидываем свой столбец
                        answer.Add(component);//Пихаем этот массив в список
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
            return answer;//Возвращаем его
        }
        /// <summary>
        /// Получить цену компонента по id
        /// </summary>
        /// <param name="id">id компонента</param>
        /// <returns>цена компонента</returns>
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
                    while (reader.Read())//Можно не while, в ответе ДОЛЖЕН БЫТЬ только один ответ
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
        /// <summary>
        /// Получить название компонента по id
        /// </summary>
        /// <param name="id">id компонента</param>
        /// <returns>наименование компонента</returns>
        public string getname(int id)
        {
            string answer = "";
            MySqlCommand Question = connect.CreateCommand();
            Question.CommandText = "SELECT materials FROM components where id = " + id.ToString();
            try
            {
                connect.Open();
                using (DbDataReader reader = Question.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answer = reader.GetString(0);
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
        /// <summary>
        /// Обновить цену компонента
        /// </summary>
        /// <param name="id">id компонента</param>
        /// <param name="price">Новая цена (строка, пускай sql с точками разбирается)</param>
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
        /// <summary>
        /// Обновить наименование компонента
        /// </summary>
        /// <param name="id">id компонента</param>
        /// <param name="name">Новое наименование</param>
        public void updatename(int id, string name)
        {
            MySqlCommand Question = connect.CreateCommand();
            Question.CommandText = "UPDATE `bazadoors`.`components` SET `materials`='" + name + "' WHERE  `id`=" + id.ToString();
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
