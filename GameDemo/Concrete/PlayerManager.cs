using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        private ICitizenCheckService _citizenCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService, ICitizenCheckService citizenCheckService)
        {
            _playerCheckService = playerCheckService;
            _citizenCheckService = citizenCheckService;
        }


        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                if (_citizenCheckService.CheckIfCitizen(player))
                {
                    base.Save(player);
                }
                else
                {
                    Console.WriteLine("Sorry we only accept Turkish players at the moment.");
                    System.Environment.Exit(1);
                }  
            }
            else
            {
                Console.WriteLine("Not a valid person!");
                System.Environment.Exit(1);
            }
        }

        public override void Delete(Player player)
        {
            base.Delete(player);
        }

        public override void Update(Player player)
        {
            base.Update(player);
        }

    }
}
