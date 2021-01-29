using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public List<Game> games = new List<Game> { }; // deneme amacli public birakildi
        public void Save(Game game)
        {
            if (!games.Contains(game))
            {
                games.Add(game);
                Console.WriteLine("A new game added to inventory: " + game.Name);
            }
            else
            {
                Console.WriteLine("Game is already in the inventory!");
            }
        }

        public void Delete(Game game)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
                Console.WriteLine("An existing game has been removed: " + game.Name);
            }
            else
            {
                Console.WriteLine("Game not found in the inventory!");
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine("An existing game has been updated: " + game.Name);
        }
    }
}
