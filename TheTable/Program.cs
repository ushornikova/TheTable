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

            //Table[] tableArray = new Table[2];

            //tableArray[0] = new Table("2m", "7m");
           // tableArray[1] = new Table("2m", "7m");

            int[] tableArray = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < tableArray.Length; i++)
            {
                tableArray[i] = randNum.Next(50, 200);

            }

            for (int counter = 0; counter <= 1; counter++)
            {
                Console.WriteLine(tableArray[counter].ShowData);
            }

            Console.ReadKey();
        }

        public class Table
        {
            public int Height { get; set; }
            public int Width { get; set; }          

            public int ShowData
            {
                get
                {
                    int showdata = Height;
                    //int showdata1 = Width;
                    //string showdata2 = Height + "" + Width;
                    return showdata;
                    
                }
            }

            //public int RandomNumber(int min, int max)  //не знаю як це викликати у класі прогам
            //{
            //    Random random = new Random();
            //    return random.Next(min, max);
            //}

            public Table (int height, int width)
            {
                Height = height;
                Width = width;
            }
        }
    }
}
