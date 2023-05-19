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
    class SLQClass
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
        public static void GetDataFromBD(String tables,DataGridView DataGrid1, List<String> List1, String where="", String collumn = " * ", Boolean useList = true)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        public static Boolean GetUserInfo(List<string> ust, string login, string pwd)
        {
            try
            {
                ust.Clear();
                string cmd = "SELECT * FROM db39.user where UserLogin = '" + login + "' and UserPassword = '" + pwd + "';";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    ust.Add(reader[0].ToString());
                    ust.Add(reader[1].ToString());
                    ust.Add(reader[2].ToString());
                    ust.Add(reader[3].ToString());
                    ust.Add(reader[4].ToString());
                    ust.Add(reader[5].ToString());
                    ust.Add(reader[6].ToString());
                }
                if (ust.Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

                return false;
            }
        }
        public static Boolean GetProducts(DataGridView dg, string filter, string orde, string stext)
        {
            try
            {
                dg.Rows.Clear();
                string cmd = "SELECT * FROM product;";
                //switch (filter)
                //{
                //    case ("0-9,99%"):
                //        cmd += "where (ProductDiscountAmount >= 0 and ProductDiscountAmount <10) ";
                //        break;
                //    case ("10-14,99%"):
                //        cmd += "where (ProductDiscountAmount >= 10 and ProductDiscountAmount <15) ";

                //        break;
                //    case ("15% и более"):
                //        cmd += "where (ProductDiscountAmount >= 15) ";

                //        break;
                //    default:
                //        break;
                //}
                //if (filter == "Все диапазоны")
                //{
                //    cmd += "where ( ProductName like '" + stext + "%' or ProductDescription like '" + stext + "%')";
                //}
                //else
                //{
                //    cmd += "and ( ProductName like '" + stext + "%' or ProductDescription like '" + stext + "%')";

                //}
                //switch (orde)
                //{
                //    case ("по возрастанию"):
                //        cmd += " order by ProductCost asc;";
                //        break;

                //    default:
                //        cmd += " order by ProductCost desc;";

                //        break;
                //}

                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    int cost = 9;
                    var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\";
                    if (reader[9].ToString() == "" || reader[9].ToString() == " ")
                    {
                        path += "plug.png";
                    }
                    else
                    {
                        path += reader[9].ToString();
                    }
                    dg.Rows.Add(reader[0].ToString(), Image.FromFile(path),
                        "Наименование: " + reader[1].ToString() + "\n" +
                        "Описание: " + reader[2].ToString() + "\n" +
                        "Производитель: " + reader[5].ToString() + "\n" +
                        "Цена без скидки: " + reader[8].ToString() + "\n" +
                        "Цена со скидкой: " + cost,
                        reader[9].ToString() + "%");
                    //int ct = Convert.ToInt32(reader[9].ToString());
                    //if (Convert.ToInt32(reader[9].ToString()) >= 15)
                    //{
                    //    dg.Rows[i].Cells[dg.ColumnCount - 1].Style.BackColor = Color.Chartreuse;
                    //}
                    //else
                    //{
                    //    dg.Rows[i].Cells[dg.ColumnCount - 1].Style.BackColor = Color.White;

                    //}
                    i++;
                }
                if (i > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

                return false;
            }
        }
    }

}
