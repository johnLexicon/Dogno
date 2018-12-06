namespace Dogno
{
    public abstract class Entity
    {
        public string Symbol { get; private set; }

        public Entity(string symbol)
        {
            Symbol = symbol;
        }
    }
}