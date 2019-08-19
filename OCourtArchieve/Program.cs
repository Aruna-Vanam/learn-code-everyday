using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;

namespace OCourtArchieve
{
    class Program
    {
        public static string AllCities { get; set; }
        public static string Renton { get; set; }
        public static string Pasco { get; set; }
        public static string SeaTac { get; set; }

        static void Main(string[] args)
        {
            string cities;

            //string[] differentCities = { "AllCities", "Renton", "Pasco", "SeaTac" };
            cities = ConfigurationManager.AppSettings.Get("Cities");
            //Console.WriteLine("The value of Key0: " + sAttr);
            //Testing GitHub
            
            string[] citiesList = cities.Split(',');
               
            foreach (string str in citiesList)
            {
                try
                {
                    string fileName = $"C:\\{str}.txt";
                    using (StreamWriter sw = new StreamWriter(fileName, append: true))
                    {
                        sw.WriteLine(DateTime.Now);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }

            Console.WriteLine("File Created");
            Console.Read();
        }
    }
}





            

           