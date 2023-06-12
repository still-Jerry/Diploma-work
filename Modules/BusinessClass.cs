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

        public static bool WriteCounfig(string value, string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, false);
                writer.Write(value);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
                    var arr = dataRow.ItemArray;
                    string r = "";
                    for (int i=0; i < dataRow.ItemArray.Count(); i++){

                        if (i==dataRow.ItemArray.Count()-1){
                            r = r + dataRow.ItemArray[i].ToString().Replace(';', '.');
                        }else{
                            r = r + dataRow.ItemArray[i].ToString().Replace(';', '.') + ";";
                        }
                    
                    }
                    string rez = r.Replace(',', '.').Replace("\n", "").Replace("\r","").Replace("\t","");
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

        //public static bool ImportTable(string table, string path = "")
        //{
        //    try
        //    {
        //        string[] fileText = File.ReadAllLines(path);
        //        Boolean first = true;
        //        foreach (string strFileText in fileText) {
        //            if (first)
        //            {
        //                string collumns = "";
        //                for (int i = 0; i < strFileText.Split(';').Length; i++)
        //                {
        //                    if (i == strFileText.Split(';').Length - 1)
        //                    {
        //                        collumns = collumns + strFileText.Split(';')[i] + " text";

        //                    }
        //                    else
        //                    {
        //                        collumns = collumns + strFileText.Split(';')[i] + " text, ";

        //                    }
        //                }
        //                SQLClass.RequestInListRows("DROP TABLE IF EXISTS new_reserve;");
        //                SQLClass.RequestInListRows("CREATE TABLE new_reserve ( " + collumns + " );");
        //                first = false;
        //            }
        //            else {
        //                string values = "";
        //                for (int i = 0; i < strFileText.Split(';').Length; i++)
        //                {
        //                    if (i == strFileText.Split(';').Length - 1)
        //                    {
        //                        values = values + "'" + strFileText.Split(';')[i]+"'";
        //                    }
        //                    else
        //                    {
        //                        values = values +"'"+ strFileText.Split(';')[i] + "', ";
        //                    }
        //                }
        //                SQLClass.AddToDataBase(" new_reserve ",values);
        //            }
        //        }
        //        SQLClass.RequestInListRows("DROP TABLE IF EXISTS " + table + "_copy;");    
        //        if (SQLClass.RequestInListRows("CREATE TABLE " + table + "_copy select * from `" + table + "`;") != null) {
        //            List<String> col = SQLClass.RequestInListRows("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+table+"' AND TABLE_SCHEMA='diploma';");
        //            string colval="";
        //            for (int i = 0; i < col.Count; i++)
        //                {
        //                    if (i == col.Count - 1)
        //                    {
        //                        colval = colval +col[i];
        //                    }
        //                    else
        //                    {
        //                        colval = colval +col[i]+ ", ";
        //                    }
        //                }
        //            SQLClass.DeleteFromDataBase(table, "");
        //            if (SQLClass.RequestInListRows("INSERT INTO `" + table + "` ( " + colval + " ) select * from new_reserve;") == null)
        //            {
        //                SQLClass.RequestInListRows("INSERT INTO `" + table + "` ( " + colval + " ) select * from " + table + "_copy;");
        //                SQLClass.RequestInListRows("DROP TABLE IF EXISTS new_reserve;");
        //                return false;                   
        //            }
        //            else {
        //                SQLClass.RequestInListRows("DROP TABLE IF EXISTS new_reserve;");
        //                SQLClass.RequestInListRows("DROP TABLE IF EXISTS "+table+"_copy;");
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    { 
        //        return false; 
        //    }
        //}
        public static bool ImportTable(string table, string path = "")
        {
            try
            {
                string[] fileText = File.ReadAllLines(path);
                Boolean first = true;
                foreach (string strFileText in fileText)
                {
                    if (first)
                    {
                        string collumns = "";
                        for (int i = 0; i < strFileText.Split(';').Length; i++)
                        {
                            if (i == strFileText.Split(';').Length - 1)
                            {
                                collumns = collumns + strFileText.Split(';')[i] + " text";

                            }
                            else
                            {
                                collumns = collumns + strFileText.Split(';')[i] + " text, ";

                            }
                        }
                        SQLClass.RequestInListRows("DROP TABLE IF EXISTS new_reserve;");
                        SQLClass.RequestInListRows("CREATE TABLE new_reserve ( " + collumns + " );");
                        first = false;
                    }
                    else
                    {
                        string values = "";
                        for (int i = 0; i < strFileText.Split(';').Length; i++)
                        {
                            if (i == strFileText.Split(';').Length - 1)
                            {
                                values = values + "'" + strFileText.Split(';')[i] + "'";
                            }
                            else
                            {
                                values = values + "'" + strFileText.Split(';')[i] + "', ";
                            }
                        }
                        SQLClass.AddToDataBase(" new_reserve ", values);
                    }
                }
              
                List<String> col = SQLClass.RequestInListRows("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + table + "' AND TABLE_SCHEMA='diploma';");
                string colval = "";
                for (int i = 0; i < col.Count; i++)
                {
                    if (i == col.Count - 1)
                    {
                        colval = colval + col[i];
                    }
                    else
                    {
                        colval = colval + col[i] + ", ";
                    }
                }
                SQLClass.DeleteFromDataBase(table, "");
                if (SQLClass.RequestInListRows("INSERT INTO `" + table + "` ( " + colval + " ) select * from new_reserve;") == null)
                {
                    return false;
                }
                else
                {
                    SQLClass.RequestInListRows("DROP TABLE IF EXISTS new_reserve;");
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    
    }
}
