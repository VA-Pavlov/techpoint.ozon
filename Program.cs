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

        //Номер 3: Автомобильные номера
        static void numberTree()
        {
            int a = int.Parse(Console.ReadLine());
            string[] array = new string[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = findNumber(Console.ReadLine());
            }

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static string findNumber(string line)
        {
            StringBuilder newLine = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                if (i + 4 <= line.Length && char.IsLetter(line[i]) && char.IsDigit(line[i + 1]))
                {

                    if (i + 5 <= line.Length && char.IsDigit(line[i + 2]) && char.IsLetter(line[i + 3]) && char.IsLetter(line[i + 4]))
                    {
                        newLine.Append(line[i].ToString() + line[i + 1].ToString() + line[i + 2].ToString() + line[i + 3].ToString() + line[i + 4].ToString() + " ");
                        i = i + 4;
                    }
                    else if (char.IsLetter(line[i + 2]) && char.IsLetter(line[i + 3]))
                    {
                        newLine.Append(line[i].ToString() + line[i + 1].ToString() + line[i + 2].ToString() + line[i + 3].ToString() + " ");
                        i = i + 3;
                    }
                    else
                        return "-";
                }
                else
                    return "-";
            }

            return newLine.ToString();
        }



        //Номер 4: Битва за кондиционер
        static void numberFour()
        {
            int countTests = int.Parse(Console.ReadLine());
            int[][] ansvres = new int[countTests][];
            for (int q = 0; q < countTests; q++)
            {
                int valueArrays = int.Parse(Console.ReadLine());
                int[] values = new int[valueArrays];
                int leftValue = 15;
                int rightValue = 30;
                for (int i = 0; i < valueArrays; i++)
                {
                    string[] words = Console.ReadLine().Split();
                    if (words[0].Equals("<=")) rightValue = int.Parse(words[1]) < rightValue ? int.Parse(words[1]) : rightValue;
                    if (words[0].Equals(">=")) leftValue = int.Parse(words[1]) > leftValue ? int.Parse(words[1]) : leftValue;
                    values[i] = leftValue <= rightValue ? leftValue : -1;
                }
                ansvres[q] = values;
            }
            for (int i = 0; i < ansvres.Length; i++)
            {
                for (int q = 0; q < ansvres[i].Length; q++)
                {
                    Console.WriteLine(ansvres[i][q]);
                }
                Console.WriteLine();
            }
        }
}
