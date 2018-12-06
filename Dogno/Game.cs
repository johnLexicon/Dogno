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
            Init();
            Draw();
            bool quit = false;
            do
            {
                //User input
                ConsoleKey key = Console.ReadKey(intercept: true).Key;

                //Act
                bool action = false;
                switch (key)
                {
                    case ConsoleKey.X:
                    case ConsoleKey.Q:
                        Console.WriteLine("Game Over");
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                        action = map.MoveCreature(creature: hero, dx: 0, dy: -1);
                        break;
                    case ConsoleKey.DownArrow:
                        action = map.MoveCreature(creature: hero, dx: 0, dy: 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        action = map.MoveCreature(creature: hero, dx: -1, dy: 0);
                        break;
                    case ConsoleKey.RightArrow:
                        action = map.MoveCreature(creature: hero, dx: 1, dy: 0);
                        break;
                    default:
                        Console.WriteLine("Not a valid option!!");
                        break;
                }

                //Draw
                Draw();

            } while (!quit);


        }

        private void Init()
        {
            map.Cell(1, 1).Creature = hero;
            hero.X = 1;
            hero.Y = 1;
            map.Cell(3, 5).Items.Add(item: new Item());
        }

        private void Draw()
        {
            Console.Clear();

            for (int y = 0; y < map.Height; y++)
            {
                string row = "";
                for (int x = 0; x < map.Width; x++)
                {
                    var cell = map.Cell(x, y);
                    var symbol = cell.Symbol;
                    row = $" {symbol}";

                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }
    }
}