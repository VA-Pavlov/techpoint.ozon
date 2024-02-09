using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techpoint.ozon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] array = new string[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = Console.ReadLine();
            }
        }
    }
    class Figur
    {
        int ax;
        int ay;
        int bx;
        int by;
        int cx;
        int cy;
        int dx;
        int dy;
        Figur dad;
        Figur son;
        int valueDady;
        public Figur(int ax, int ay, string[]pole)
        {
            this.ax = ax;
            this.ay = ay;
            int i=ax;
            while (pole[ay][i] == '*' && ax < pole[ax].Length)
            {
                i++;
            }
            bx = i-1;
            by = ay;
            i = ay;
            while (pole[i][ax] == '*' && ax < pole.Length)
            {
                i++;
            }
            cy = i - 1;
            cx = i - 1;
            dx = bx;
            dy = cy;
        }
    }
}
