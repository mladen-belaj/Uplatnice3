using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uplatnice
{
    class Library
    {
        public static string url = "https://new.nikal-travel.si/getR/";
        public static string avans = "20";
        public static string brojRata = "2";
        public static string odgoda = "14";
        public static string rok = "45";

        public void ReadSettings()
        {
            using (StreamReader file = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Settings.ini"))
            {
                string line;
                String delim = "*";
                char[] delimiter = delim.ToCharArray();

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Trim().Length > 0)
                    {
                        string[] columns = line.Split(delimiter);

                        if (columns[0] == "url") url = columns[1];
                        if (columns[0] == "avans") avans = columns[1];
                        if (columns[0] == "brojRata") brojRata = columns[1];
                        if (columns[0] == "odgoda") odgoda = columns[1];
                        if (columns[0] == "rok") rok = columns[1];
                    }
                }
            }
        }

    }
}
