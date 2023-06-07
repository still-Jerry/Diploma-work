using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    class BusinessClass
    {
        public static List<String> UserInfoList;
        public static List<String> SelectedFromDataGridList;
        public static List<String> DuplicateСheckList;
        public static Dictionary<String, Int32[]> SeriesCountPrescriptionNumberDictionary = new Dictionary<string,int[]>();

        public static string GetRandomTextString(int n = 12, bool sp = true, bool up = true, bool pwd = false)
        {
            string text = string.Empty;
            Random rnd = new Random();
            string spec = @"!#$%&'()*+,-./:;<=>?@[\]^_`{|}~";
            string ALF = "1234567890abcdefghijklmnopqrstuvwxyz";
            string UPP = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (up) { 
                ALF+=UPP;
            }
            if (sp)
            {
                ALF += spec;
                n = pwd ? rnd.Next(8, n) : rnd.Next(1, n);

            }
            for (int i = 0; i < n; ++i)
            {
                text += ALF[rnd.Next(ALF.Length)];
            }
            return text;
        }

        public static bool ExportTable(DataTable dt, string table, string path ="")
        {
            try
            {

                string FileName = path+table + "_" + DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss");
                StreamWriter writer = new StreamWriter(FileName + ".csv", false);

                //colums
                for (int i = 0, len = dt.Columns.Count - 1; i <= len; ++i)
                {
                    if (i != len)
                        writer.Write(dt.Columns[i].ColumnName + ";");
                    else
                        writer.Write(dt.Columns[i].ColumnName);
                }

                writer.Write("\n");

                int count = dt.Rows.Count;

                //data
                foreach (DataRow dataRow in dt.Rows)
                {

                    string r = String.Join(";", dataRow.ItemArray);
                    string rez = r.Replace(',', '.');
                    writer.WriteLine(rez);
                }

                writer.Close();
                
                return true;
            }
            catch (Exception) 
            {
               
                return false; 
            }
        }
    }
}
