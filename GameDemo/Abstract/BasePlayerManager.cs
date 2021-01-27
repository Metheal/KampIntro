using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Save(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName);
            Console.WriteLine("Player saved successfully!");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName);
            Console.WriteLine("Player dedleted successfully!");
        }
    }
}
