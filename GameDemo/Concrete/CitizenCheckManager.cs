using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CitizenCheckManager : ICitizenCheckService
    {
        public bool CheckIfCitizen(Player player)
        {
            if (player.NationalityID.Length == 11)
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
