using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    public class General
    {
        static Random rnd = new Random();
        static List<List<Cell>> List_Of_Cells = new List<List<Cell>>(); // Список списков для клеток (т. к. клетка состоит из нескольких Cell'ов).

        public static void InitializeField(Cell[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = new Cell();
                }
            }
        }

        public static void Proceed(Cell[,] field)
        {
            foreach (List<Cell> cells in List_Of_Cells)
            {
                int direction = rnd.Next(1, 5);

                if (direction == 2 || direction == 3) // В изначально сформированном списке сначала идут левые клетки. В случае движения влево всё хорошо...
                    // При движении же вправо идёт накладка и часть клеток уходит в инвиз. Чтобы избежать этого, я обращаю список при движении вправо и вниз...
                    // и всё хорошо)
                    cells.Reverse();

                foreach (Cell p_o_c in cells) // Part of cell.
                {
                    p_o_c.Move(field, direction, cells);
                }

                if (direction == 2 || direction == 3) // Если уже был разворот списка, разворачиваем его в исходное состояние, чтобы избежать проблем при...
                    // движении влево и вверх.
                    cells.Reverse();

            }
            Thread.Sleep(500);
        }

        public static void Spawn(int d_of_cell, int x, int y, Cell[,] field)
        {
            SpawnTheCell(d_of_cell, field, x, y, List_Of_Cells);
        }

        private static void SpawnTheCell(int d_of_cell, Cell[,] field, int x, int y, List<List<Cell>> List_Of_Cells)
        {
            int cell_num = 0;

            List_Of_Cells.Add(new List<Cell>());

            int r_of_cell = d_of_cell / 2;

            for (int i = y; i <= y + d_of_cell / 2; i++) // Заполнение клетки вниз.
            {
                for (int j = x - r_of_cell; j <= x + r_of_cell; j++)
                {
                    field[i, j].SetState(1);
                }
                r_of_cell--;
            }

            r_of_cell = d_of_cell / 2;

            for (int n = y; n >= y - d_of_cell / 2; n--) // Заполнение клетки выше центра.
            {
                for (int m = x - r_of_cell; m <= x + r_of_cell; m++)
                {
                    field[n, m].SetState(1);
                }
                r_of_cell--;
            }

            int num_of_part_of_cell = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[j, i].State == 1)
                    {
                        List_Of_Cells[cell_num].Add(new Cell());
                        List_Of_Cells[cell_num][num_of_part_of_cell].X = j;
                        List_Of_Cells[cell_num][num_of_part_of_cell].Y = i;
                        num_of_part_of_cell++;
                    }
                }
            }

            cell_num++;
        }
    }
}