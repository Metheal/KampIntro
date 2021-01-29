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
            Player player1 = new Citizen { NationalityID = "12345678901", DateOfBirth = new DateTime(1998, 3, 28), FirstName = "Enes", LastName = "Yilmaz", Points=20 };
            Player player2 = new Citizen { NationalityID = "12345678901", DateOfBirth = new DateTime(2001, 6, 17), FirstName = "John", LastName = "Doe", Points=21 };
            Player player3 = new Citizen { NationalityID = "12345678901", DateOfBirth = new DateTime(1994, 12, 2), FirstName = "Richard", LastName = "Roe", Points=1 };
            Player player4 = new Citizen { NationalityID = "12345678901", DateOfBirth = new DateTime(1997, 8, 14), FirstName = "Walter", LastName = "White", Points=0 };
            playerManager.Save(player1);
            playerManager.Save(player2);
            playerManager.Save(player3);
            playerManager.Save(player4);


            GameManager gameManager = new GameManager();
            Game game1 = new Game { ID = 1, Name = "GTA V", Platform = "PS5", Price = 94.99, Type = "Action-Adventure", Quantity=200 };
            Game game2 = new Game { ID = 2, Name = "Cyberpunk 2077", Platform = "PC", Price = 300, Type = "Action-Role playing", Quantity=159 };
            Game game3 = new Game { ID = 3, Name = "PlayerUnknown's Battlegrounds", Platform = "PC", Price = 70, Type = "Online Battle Royale", Quantity=120 };
            Game game4 = new Game { ID = 4, Name = "The Sims 4", Platform = "XBOX", Price = 60, Type = "Life Simulation", Quantity=0 };
            gameManager.Save(game1);
            gameManager.Save(game2);
            gameManager.Save(game3);
            gameManager.Save(game4);


            CampaignManager campaignManager = new CampaignManager();
            Game discount1 = campaignManager.ApplyDiscount(ref game1, player1);
            campaignManager.Sell(ref discount1, ref player1);
            Game discount2 = campaignManager.ApplyDiscount(ref game2, player2);
            campaignManager.Sell(ref discount2, ref player2);
            Game discount3 = campaignManager.ApplyDiscount(ref game3, player3);
            campaignManager.Sell(ref discount3, ref player3);
            Game discount4 = campaignManager.ApplyDiscount(ref game4, player4);
            campaignManager.Sell(ref discount4, ref player4);


            //Console.WriteLine("Registered users: " + playerManager.players.Count);
            //foreach (var player in playerManager.players)
            //{
            //    Console.WriteLine(player.FirstName + " " + player.LastName);
            //}

            //Console.Write("games in the inventory: ");
            //foreach (var game in gameManager.games)
            //{
            //    Console.Write(game.Name + ", ");
            //}
        }
    }
}
