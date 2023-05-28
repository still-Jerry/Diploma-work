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

        public static Int32 ViewTableWithPicturesOnDataGrid(DataGridView datagrid, DataTable table,  Int16 j)
        {
            datagrid.Rows.Clear();
            try
            {
                int start = j * 5 - 5 <= 0 ? start = 0 : start = j * 5 - 5;
                int stop = 5 * j > table.Rows.Count ? stop = table.Rows.Count : stop = 5 * j;

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
                        path += table.Rows[i][1].ToString();
                        img = Image.FromFile(path);
                    }
                    datagrid.Rows.Add(
                        table.Rows[i][0].ToString(),
                        img,
                        "Наименование: " + table.Rows[i][2].ToString() +
                        "\nСтоимость: " + table.Rows[i][3].ToString() +
                        "\nРазмер скидки: " + table.Rows[i][4].ToString()
                        );
                    datagrid.Rows[datagrid.Rows.Count-1].Height = 100;
                }
                return table.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1; 
            }
        }
        //public static void ViewListWithPicturesOnTable(DataGridView datagrid, List<String> list)
        //{
        //    try
        //    {
        //        for (int i = 0; i < list.Count(); i++)
        //        {
        //            Image img;
        //            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\";
        //            if (list[1].ToString() == "" || list[1].ToString() == " ")
        //            {
        //                img=Properties.Resources.plug as Bitmap;

        //            }
        //            else
        //            {
        //                path += list[1].ToString();
        //                img = Image.FromFile(path);
        //            }
        //            datagrid.Rows.Add(
        //                list[0],
        //                img,
        //                "Наименование: " + list[2] +
        //                "\nСтоимость: " + list[3]+
        //                "\nРазмер скидки: " + list[4]
        //                );
        //            datagrid.Rows[i].Height = 100;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка");
        //    }
        //}
    }
}
