using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            if (!string.IsNullOrWhiteSpace(player.FirstName)
                && !string.IsNullOrWhiteSpace(player.LastName)
                && !string.IsNullOrWhiteSpace(player.Nationality)
                && player.DateOfBirth.Year < 2021
                && player.DateOfBirth.Year > 1900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
