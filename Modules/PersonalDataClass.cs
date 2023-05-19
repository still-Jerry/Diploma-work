using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    //using BusinessClass = Modules.BusinessClass;
    //using SQLClass = Modules.SQLClass;
    class PersonalDataClass
    {
        static string saltG = "MySalt";

        public static string Hashing(string pwd, string saltU)
        {
            using (var sha256 = new SHA256Managed())
            {
                pwd = saltG + pwd + saltU;
                string chec = BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd))).Replace("-", "");
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd))).Replace("-", "");
            }
        }
        public static Boolean CheckUserEquality(String login, String pwd)
        {
            try
            {
                List<String> list = new List<String>();

                String cmd = "SELECT passwordUser, saltUser FROM `user` where loginUser = '" + login + "';";
                MySqlCommand Command = new MySqlCommand(cmd, SQLClass.Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    for (Int16 i = 0; reader.FieldCount > i; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }

                Command.Connection.Close();

                if (Hashing(pwd, list[1]) == list[0].ToUpper())
                {
                    return true;
                }
                else {
                    MessageBox.Show("Несовпадение пароля","Ошибка");
                    return false;
                }

                
            }
            catch (Exception ex){
                //MessageBox.Show(ex.Message, "Ошибка");
                MessageBox.Show("Несовпадение логина", "Ошибка");

                return false;
            }
        }
    }
}
