using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    public class Cell
    {
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

        public void Move(Cell[,] field, int direction)
        {
            switch (direction)
            {
                case 1: // OK.
                    {
                        if (X - 1 >= 0)
                            X -= 1;
                        break;
                    }
                case 2:
                    {
                        if (Y + 1 < field.GetLength(0))
                            Y += 1;
                        break;
                    }
                case 3:
                    {
                        if (X + 1 < field.GetLength(1))
                            X += 1;
                        break;
                    }
                case 4: // OK.
                    {
                        if (Y - 1 >= 0)
                            Y -= 1;
                        break;
                    }
            }
        }

    }
}