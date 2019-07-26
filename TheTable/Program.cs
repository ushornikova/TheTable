using System;

namespace TABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = new Table[10]; //ми створили змінну tables і записали у неї масив б масив присвоїли змінній
            // змінна tables  отимає зсилку на створений обєкт

            Random randNum = new Random();
            for (int i = 0; i < tables.Length; i++)
            {
                // створили рандомні ширину та висоту
                int randomHeight = randNum.Next(50, 200);
                int randomWidth = randNum.Next(50, 200);
                // створили об'єкт типу Table використовуючи конструкто
                Table randomTable = new Table(randomHeight, randomWidth);
                // записали новостворений об'єкт у масив
                tables[i] = randomTable;
                //метод викликається на обєкті tables[i] або randomTable , 
                //метод і конструктор викликаються з дужками
                tables[i].ShowData();
            }

            Console.ReadKey();
        }
    }

    public class Table //класс це новий тип
    {
        public int Height { get; set; }
        public int Width { get; set; }
        //в обект можна додати ці дві проперті,- визначила клас

        //потрібно ств 10 обєктів в тілі програми

        public Table(int height, int width //конструктор
        {
            Height = height;
            Width = width;
        }

        public void ShowData()
        {
            Console.WriteLine("Height: " + Height + ", width: " + Width);
        }
    }
}