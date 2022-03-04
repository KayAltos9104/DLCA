using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    public class General
    {

        public static void Start(int d_of_cell, int x, int y, Cell[,] field)
        {
            List<List<Cell>> List_Of_Cells = new List<List<Cell>>(); // Список списков для клеток (т. к. клетка состоит из нескольких Cell'ов).

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = new Cell();
                }
            }

            SpawnTheCell(d_of_cell, field, x, y, List_Of_Cells);
        }

        private static void SpawnTheCell(int d_of_cell, Cell[,] field, int x, int y, List<List<Cell>> List_Of_Cells)
        {
            int cell_num = 0;

            List_Of_Cells.Add(new List<Cell>());
            List_Of_Cells[cell_num].Add(new Cell());
            foreach (Cell c in List_Of_Cells[cell_num])
            {
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
            }

            cell_num++;
        }
    }
}