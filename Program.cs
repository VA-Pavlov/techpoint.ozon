using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techpoint.ozon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberTwo();
        }

        //Номер 1: Морской бой
        static void numberOne()
        {
            int a = int.Parse(Console.ReadLine());
            string[] array = new string[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = ShipInspection(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        static string ShipInspection(string word)
        {
            int one = 0;
            int two = 0;
            int tree = 0;
            int four = 0;
            for (int i = 0; i < 19; i += 2)
            {
                switch (word[i])
                {
                    case '1':
                        four++;
                        break;
                    case '2':
                        tree++;
                        break;
                    case '3':
                        two++;
                        break;
                    case '4':
                        one++;
                        break;
                }
                if (one > 1 || two > 2 || tree > 3 || four > 4)
                    return "NO";
            }
            return "YES";
        }

        //Номер 2: Проверка даты
        static void numberTwo()
        {
            int a = int.Parse(Console.ReadLine());
            int[,] array = new int[a, 3];
            for (int i = 0; i < a; i++)
            {
                string[] words = Console.ReadLine().Split(' ');
                array[i, 0] = int.Parse(words[0]);
                array[i, 1] = int.Parse(words[1]);
                array[i, 2] = int.Parse(words[2]);
            }
            for (int i = 0; i < a; i++)
            {
                try
                {
                    DateTime dateTime = new DateTime(array[i, 2], array[i, 1], array[i, 0]);
                    Console.WriteLine("Yes");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}
