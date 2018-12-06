using System.Collections.Generic;

namespace Dogno
{
    internal class Cell
    {
        public Creature Creature { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}