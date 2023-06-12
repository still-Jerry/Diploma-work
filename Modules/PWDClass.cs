using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    class PWDClass
    {
        static string saltG = "MySalt";
        public static string Hashing(string pwd, string saltU)
        {
            using (var sha256 = new SHA256Managed())
            {
                pwd = saltG + pwd + saltU;
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd))).Replace("-", "");
            }

        }
    }
}
