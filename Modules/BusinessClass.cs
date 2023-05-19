using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Modules
{
    class BusinessClass
    {
        public static string GetRandomTextString(int n = 12, bool sp = true, bool pwd = false)
        {
            string text = string.Empty;
            Random rnd = new Random();
            string spec = @"!#$%&'()*+,-./:;<=>?@[\]^_`{|}~";
            string ALF = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
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
    }
}
