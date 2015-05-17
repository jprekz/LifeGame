using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    class LifeGame
    {
        public Cells Cells;
        Cells nextCells;
        Cells bufCells;

        public bool[,] DrawFlags;

        int cellsX;
        int cellsY;

        public int CellsX
        {
            get
            {
                return cellsX;
            }
        }
        public int CellsY
        {
            get
            {
                return cellsY;
            }
        }

        public LifeGame(int x,int y)
        {
            cellsX = x;
            cellsY = y;

            Cells = new Cells(cellsX,cellsY);
            nextCells = new Cells(cellsX,cellsY);
            DrawFlags = new bool[cellsX, cellsY];
            for (var j = 0; j < cellsY; j++)
            {
                for (var i = 0; i < cellsX; i++)
                {
                    Cells[i, j] = 0;
                    DrawFlags[i, j] = true;
                }
            }
            
        }

        public void CellsRndInit(decimal num)
        {
            Random rnd = new Random();
            for (var j = 0; j < cellsY; j++)
            {
                for (var i = 0; i < cellsX; i++)
                {
                    if (rnd.Next(100) >= num*100) //たぶん動く
                    {
                        Cells[i, j] = 0;
                    }
                    else
                    {
                        Cells[i, j] = 1;
                    }
                }
            }
        }

        public void CellsMatrixInit(int[] matrix)
        {
            for (var j = 0; j < CellsY; j++)
            {
                for (var i = 0; i < cellsX; i++)
                {
                    Cells[i, j] = matrix[(j * cellsX) + i];
                }
            }
            return;
        }

        public void OnFrame()
        {
            for (var j = 0; j < cellsY; j++)
            {
                for (var i = 0; i < cellsX; i++)
                {
                    if (Cells[i, j] == 0)
                    {
                        if (CellsCount(i, j) == 3)
                        {
                            nextCells[i, j] = 1;
                            DrawFlags[i, j] = true;
                        }
                        else
                        {
                            nextCells[i, j] = 0;
                            DrawFlags[i, j] = false;
                        }
                    }
                    else
                    {
                        if (CellsCount(i, j) == 2 || CellsCount(i,j) == 3)
                        {
                            nextCells[i, j] = 1;
                            DrawFlags[i, j] = false;
                        }
                        else
                        {
                            nextCells[i, j] = 0;
                            DrawFlags[i, j] = true;
                        }
                    }
                }
            }

            bufCells = Cells;
            Cells = nextCells;
            nextCells = bufCells;
        }

        int CellsCount(int x, int y)
        {
            return Cells[x - 1, y - 1] +
                Cells[x, y - 1] +
                Cells[x + 1, y - 1] +
                Cells[x - 1, y] +
                Cells[x + 1, y] +
                Cells[x - 1, y + 1] +
                Cells[x, y + 1] +
                Cells[x + 1, y + 1];
        }

        // CellsLoop プロパティ
        // True…ループする False…ループしない
        bool cellsLoop;
        public bool CellsLoop
        {
            get
            {
                return cellsLoop;
            }
            set
            {
                if (value == true)
                {
                    Cells.MatrixLoop = true;
                    nextCells.MatrixLoop = true;
                }
                else
                {
                    Cells.MatrixLoop = false;
                    nextCells.MatrixLoop = false;
                }
                cellsLoop = value;
            }
        }

    }
}
