using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    class Cells
    {
        public bool MatrixLoop;

        bool[,] matrix;

        public int GetLengthX
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int GetLengthY
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int this[int x, int y]
        {
            set
            {
                if (MatrixLoop == true)
                {
                    if (x < 0)
                    {
                        x += this.GetLengthX;
                    }
                    if (x >= this.GetLengthX)
                    {
                        x -= this.GetLengthX;
                    }
                    if (y < 0)
                    {
                        y += this.GetLengthY;
                    }
                    if (y >= this.GetLengthY)
                    {
                        y -= this.GetLengthY;
                    }

                    if ((x >= 0) && (x < this.GetLengthX) && (y >= 0) && (y < this.GetLengthY))
                    {
                        if (value == 0)
                        {
                            this.matrix[x, y] = false;
                        }
                        else
                        {
                            this.matrix[x, y] = true;
                        }
                    }
                }
                else
                {
                    if ((x >= 0) && (x < this.GetLengthX) && (y >= 0) && (y < this.GetLengthY))
                    {
                        if (value == 0)
                        {
                            this.matrix[x, y] = false;
                        }
                        else
                        {
                            this.matrix[x, y] = true;
                        }
                    }
                }
            }
            get
            {
                if (MatrixLoop == true)
                {
                    if (x < 0)
                    {
                        x += this.GetLengthX;
                    }
                    if (x >= this.GetLengthX)
                    {
                        x -= this.GetLengthX;
                    }
                    if (y < 0)
                    {
                        y += this.GetLengthY;
                    }
                    if (y >= this.GetLengthY)
                    {
                        y -= this.GetLengthY;
                    }

                    if (this.matrix[x, y] == false)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    if ((x < 0) || (x >= this.GetLengthX) || (y < 0) || (y >= this.GetLengthY))
                    {
                        return 0;
                    }
                    else
                    {
                        if (this.matrix[x, y] == false)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        public Cells(int x,int y)
        {
            matrix = new bool[x, y];
        }
    }
}
