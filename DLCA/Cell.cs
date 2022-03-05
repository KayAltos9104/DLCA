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

        public void Move(Cell[,] field, int direction, List<Cell> cells)
        {
            bool flag = true;

            switch (direction)
            {
                case 1:
                    foreach (Cell c in cells)
                    {
                        if (X - 1 >= 0)
                            flag = true;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    break;

                case 2:
                    foreach (Cell c in cells)
                    {
                        if (Y + 1 < field.GetLength(0))
                            flag = true;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    break;

                case 3:
                    foreach (Cell c in cells)
                    {
                        if (X + 1 < field.GetLength(1))
                            flag = true;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    break;

                case 4:
                    foreach (Cell c in cells)
                    {
                        if (Y - 1 >= 0)
                            flag = true;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    break;
            }

            //foreach (Cell c in cells)
            //{
            //    if (direction == 1 && X - 1 >= 0 ||
            //        direction == 2 && Y + 1 < field.GetLength(0) ||
            //        direction == 3 && X + 1 < field.GetLength(1) ||
            //        direction == 4 && Y - 1 >= 0)
            //    {
            //        flag = true;
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //}

            if (flag == true)
            {
                field[X, Y].SetState(0);
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
                field[X, Y].SetState(1);
            }

        }

    }
}