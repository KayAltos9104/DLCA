using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    public class Cell
    {
        static Random rnd = new Random();

        public int State { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Cell()
        {
            State = 0;
            X = 0;
            Y = 0;
        }

        public void SetState(int state)
        {
            State = state;
        }

        public void Move(Cell[,] field, int direction, List<Cell> cells, out bool flag)
        {
            bool _flag = false;

            int X_Max = cells.Max(Cell => Cell.X);
            int X_min = cells.Min(Cell => Cell.X);
            int Y_Max = cells.Max(Cell => Cell.Y);
            int Y_min = cells.Min(Cell => Cell.Y);

            if (direction == 3 && X_Max + 1 < field.GetLength(1) ||
                direction == 1 && X_min - 1 >= 0 ||
                direction == 2 && Y_Max + 1 < field.GetLength(0) ||
                direction == 4 && Y_min - 1 >= 0)
                _flag = true;
            else
                _flag = false;

            flag = _flag;

            if (flag == false)
                return;

            switch (direction)
            {
                case 1:
                    {
                        X -= 1;
                        break;
                    }
                case 2:
                    {
                        Y += 1;
                        break;
                    }
                case 3:
                    {
                        X += 1;
                        break;
                    }
                case 4:
                    {
                        Y -= 1;
                        break;
                    }
            }

        }

    }
}