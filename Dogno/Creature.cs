namespace Dogno
{
    internal class Creature : Entity
    {
        public Creature(string symbol) : base(symbol)
        {

        }

        public int Y { get; internal set; }
        public int X { get; internal set; }
    }
}