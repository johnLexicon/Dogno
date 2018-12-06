using System;

namespace Dogno
{
    internal class Game
    {
        Map map;
        Hero hero;

        public Game()
        {
            map = new Map(15, 15);
            hero = new Hero();
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }
}