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
                case 4: // OK.
                    {
                        Y -= 1;
                        break;
                    }
            }
        }

    }
}