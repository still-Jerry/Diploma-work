using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    class ViewsClass
    {
        public static Boolean StateWindows = true;
        public static Boolean EnabledForm = false;
        public static Int16 MoreProductButtonState = 1;

        public static Int32 ViewTableWithPicturesOnDataGrid(DataGridView datagrid, DataTable table, Int32 j, Boolean pagination=true)
        {
            try
            {
                datagrid.Rows.Clear();
                int start, stop;
                //проерку на вс записи либо сделать погинацию?
                if (pagination)
                {
                     start = j * 5 - 5 <= 0 ? start = 0 : start = j * 5 - 5;
                     stop = 5 * j > table.Rows.Count ? stop = table.Rows.Count : stop = 5 * j;
                }
                else {
                    start = j;
                    stop = table.Rows.Count;
                }
                //table.Rows.Count
                for (int i = start; i < stop; i++)
                {
                    Image img;
                    var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\";
                    if (table.Rows[i][1].ToString() == "" || table.Rows[i][1].ToString() == " ")
                    {
                        img = Properties.Resources.plug as Bitmap;

                    }
                    else
                    {
                        try
                        {
                            path += table.Rows[i][1].ToString();
                            img = Image.FromFile(path);
                        }
                        catch(Exception ex) {
                            MessageBox.Show(ex.Message, "Ошибка");
                            img = Properties.Resources.plug as Bitmap;
                        }
                    }
                    datagrid.Rows.Add(
                        table.Rows[i][0].ToString(),
                        img,
                         table.Rows[i][2].ToString() +
                        "\n\nЦена: " + table.Rows[i][3].ToString()+" p." +
                         "\nСкидка: " + Convert.ToDouble(table.Rows[i][4]) * 100 +"%"+
                        "\nИтого: " + (Convert.ToDouble(table.Rows[i][3]) - Convert.ToDouble(table.Rows[i][3]) * Convert.ToDouble(table.Rows[i][4])) +" p."
                        );
                   
                    datagrid.Rows[datagrid.Rows.Count-1].Height = 120;
                }
                return table.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1; 
            }
        }
        
    }
}
