using System;

namespace Dogno
{
    internal class Map
    {
        private Cell[,] cells;
        private int width;
        private int height;

        public int Width { get => width; private set => width = value; }
        public int Height { get => height; private set => height = value; }

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            cells = new Cell[width, height];



            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cells[x, y] = new Cell(x, y);
                }
            }
        }

        internal bool MoveCreature(Creature creature, int dx, int dy)
        {
            int oldX = creature.X;
            int oldY = creature.Y;

            var newX = creature.X + dx;
            var newY = creature.Y + dy;

            Cell newCell = Cell(newX, newY);

            if(newCell is null && newCell.Creature != null)
            {
                return false;
            }

            //Removes the creature from the old cell
            Cell(oldX, oldY).Creature = null;

            //Adds the creature to the new cell
            newCell.Creature = creature;

            creature.X = newX;
            creature.Y = newY;

            return true;
        }



        /// <summary>
        /// Returns a cell object from given position in the matrix
        /// </summary>
        /// <param name="x">Row</param>
        /// <param name="y">Col</param>
        /// <returns>The cell object found at the given postition</returns>
        internal Cell Cell(int x, int y)
        {
            //if(x >= 0 && x <= Width && y >= 0 && y <= Height)
            //{
            //    return cells[x, y];
            //}

            //return null;

            try
            {
                return cells[x, y];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }
    }
}