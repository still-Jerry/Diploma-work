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

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    /// <summary>
    /// <CreateParams>Class for working with SQL queries</CreateParams>
    /// </summary>
    class SQLClass
    {

        public static MySqlConnection Connect()
        {
            try
            {
                string con = "host=localhost;uid=root;pwd=root;database=diploma;";
                MySqlConnection Connection = new MySqlConnection(con);
                Connection.Open();
                return Connection;
            }
            catch
            {
                MessageBox.Show("Ошибка полключения к бд", "Ошибка");

                return null;
            }
        }
       
        public static List<String> GetSelectInList(String tables, String where = "", String attributes = "*", String order = "", String join = "")
        {
            try
            {
                List<String> list = new List<String>();

                String cmd = "SELECT " + attributes + " FROM " + tables + join + where + order + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    for (Int16 i = 0; reader.FieldCount > i; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }

                Command.Connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }
        public static DataTable GetSelectInDataTable(String tables, String where = "", String attributes = "*", String order = "", String join = "")
        {
            try
            {
                String cmd = "SELECT " + attributes + " FROM " + tables +join + where + order + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataAdapter adapt = new MySqlDataAdapter(Command);
                DataTable table = new DataTable();
                adapt.Fill(table);
                //dg.DataSource = table;
                Command.ExecuteNonQuery();
                Command.Connection.Close();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }
        public static Boolean DeleteFromDataBase(String tables, String where)
        {
            try
            {
                String cmd = "Delete FROM " + tables +  where + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                Command.ExecuteNonQuery();
                Command.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }
        public static Boolean UpdateToDataBase(String tables, String attributes, String where)
        {
            try
            {
                String cmd = "UPDATE " + tables + " SET " + attributes  + where + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                Command.ExecuteNonQuery();
                Command.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }
        public static Boolean AddToDataBase(String tables,  String attributes)
        {
            try
            {
                String cmd = "INSERT INTO  " + tables + " VALUES (" + attributes + ");";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                Command.ExecuteNonQuery();
                Command.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        public static List<String> RequestInListRows(String request)
        {
            try
            {
                List<String> list = new List<String>();

                String cmd = request;
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    for (Int16 i = 0; reader.FieldCount > i; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }

                Command.Connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }

        public static List<String> TransactionAddToDataBase1(String tables1, String values1,
            String tables, String where = "", String attributes = " * ", String order = "", String join = "")
        {
            MySqlConnection con = Connect();
            MySqlTransaction transaction = con.BeginTransaction();
            MySqlCommand command = con.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = "INSERT INTO  " + tables1 + " VALUES (" + values1 + ");";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT " + attributes + " FROM " + tables1 + join + where + order + ";";
                MySqlDataReader reader = command.ExecuteReader();
                List<String> list = new List<String>();

                while (reader.Read())
                {
                    for (Int16 i = 0; reader.FieldCount > i; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }
                reader.Close();
                transaction.Commit();
                
               
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                transaction.Rollback();
                return null;
            }
            con.Close();
        }

        public static Boolean TransactionAddToDataBase2(String tables1, String values1,
        String tables, String values, String key, String where = "", String attributes = " * ", String order = "", String join = "")
        {
            MySqlConnection con = Connect();
            MySqlTransaction transaction = con.BeginTransaction();
            MySqlCommand command = con.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = "INSERT INTO  " + tables1 + " VALUES (" + values1 + ");";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT " + attributes + " FROM " + tables1 + join + where + order + ";";
                MySqlDataReader reader = command.ExecuteReader();
                List<String> list = new List<String>();

                while (reader.Read())
                {
                    for (Int16 i = 0; reader.FieldCount > i; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }
                reader.Close();
                values = values.Replace(key, list[0]);
                command.CommandText = "INSERT INTO  " + tables + " VALUES " + values + ";"; 

                command.ExecuteNonQuery();
               
                // подтверждаем транзакцию
                transaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                transaction.Rollback();
                return false;
            }
        }

        //public static void BacupExport() {
        //    string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
        //    string file = "C:\\backup.sql";
        //    using (MySqlConnection conn = new MySqlConnection(constring))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            using (MySqlBackup mb = new MySqlBackup(cmd))
        //            {
        //                cmd.Connection = conn;
        //                conn.Open();
        //                mb.ExportToFile(file);
        //                conn.Close();
        //            }
        //        }
        //    }
        //}
    }

}
