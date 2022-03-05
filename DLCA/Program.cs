using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите размеры поля в формате 1x2");

            string[] field_sizes = Console.ReadLine().Split(new char[] { 'x', 'X' });

            int a = int.Parse(field_sizes[0]);
            int b = int.Parse(field_sizes[1]);

            Cell[,] field = new Cell[a, b];

            General.InitializeField(field);
            Render.Draw(field);

            for (int i = 0; i < 2; i++)
            {

                int d_of_cell;
                int x;
                int y;

                bool input_success;

                do
                {
                    input_success = true;
                    do
                    {
                        Input.GetDiameter(Console.ReadLine(), out d_of_cell);
                        if (d_of_cell == 2)
                            Console.WriteLine("Только нечётные диаметры!");
                    }
                    while (d_of_cell == 2);

                    Input.GetNullCoords(Console.ReadLine(), out x, out y);

                    if (y > field.GetLength(0) || x > field.GetLength(1) || (y + d_of_cell / 2) > field.GetLength(0)
                        || (x + d_of_cell / 2) > field.GetLength(1) || (y - d_of_cell / 2) < 0 || (x - d_of_cell / 2) < 0)
                    {
                        input_success = false;
                        Console.WriteLine("Выход за границы поля. Проверьте значения диаметра и заданных координат.\nЗаново введите диаметр и координаты центра клетки.");
                    }
                }
                while (input_success != true);

                General.Spawn(d_of_cell, x, y, field);
                Render.Draw(field);
            }
        }
    }
}