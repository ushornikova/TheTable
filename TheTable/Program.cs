using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Table[] tableArray = new Table[2];

            tableArray[0] = new Table("2m", "7m");
            tableArray[1] = new Table("2m", "7m");


            for (int counter = 0; counter <= 1; counter++)
            {
                Console.WriteLine(tableArray[counter].ShowData);
            }

            Console.ReadKey();
        }

        public class Table
        {
            public string Height { get; set; }
            public string Width { get; set; }          

            public string ShowData
            {
                get
                {
                    string showdata = Height + "" + Width + "";
                    return showdata;
                }
            }

            public int RandomNumber(int min, int max)  //не знаю як це викликати у класі прогам
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            public Table (string height, string width)
            {
                Height = height;
                Width = width;
            }
        }
    }
}
