using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager playerManager = new PlayerManager(new PlayerCheckManager(), new CitizenCheckManager());
            playerManager.Save(new Citizen{ NationalityID = "",  DateOfBirth = new DateTime(1998, 3, 28), FirstName = "Enes", LastName = "Yilmaz" });
        }
    }
}
