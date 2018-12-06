using System.Collections.Generic;

namespace Dogno
{
    internal class Cell
    {

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Creature Creature { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public string Symbol
        {
            get
            {
                if (Creature != null)
                {
                    return Creature.Symbol;
                }
                if (Items.Count > 0)
                {
                    return Items[0].Symbol;
                }

                return ".";

            }
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}