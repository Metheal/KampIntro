using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public List<Player> players = new List<Player> { }; // deneme amacli public birakildi
        public virtual void Save(Player player)
        {
            if (!players.Contains(player)) // simdilik sadece objenin referans degerine gore dogrulama yapiyor
            {
                players.Add(player);
                Console.WriteLine("Player created successfully: " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Player is already registered! " + player.FirstName + " " + player.LastName);
            }
        }

        public virtual void Delete(Player player)
        {
            if (players.Contains(player))
            {
                players.Remove(player);
                Console.WriteLine("Player deleted successfully: " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Player not found on the database!");
            }
        }

        public virtual void Update(Player player)
        {
            // some update commands
            Console.WriteLine("Player updated successfully: " + player.FirstName + " " + player.LastName);
        }
    }
}
