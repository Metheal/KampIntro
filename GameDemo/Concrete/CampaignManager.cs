using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public Game ApplyDiscount(ref Game game, Player player)
        {
            int discountRatio;
            if (player.Points == 0)
            {
                discountRatio = 0;
            }
            else if (player.Points < 10)
            {
                discountRatio = 2 * player.Points;
            }
            else
            {
                discountRatio = 20; // maximum discount ratio
            }
            game.Price = game.Price - ((game.Price / 100) * discountRatio);
            if (discountRatio > 0)
            {
                Console.WriteLine(game.Name + " oyununda %" + discountRatio + " oraninda indirim uygulandi");
            }
            else
            {
                Console.WriteLine(game.Name + " oyununda "+ player.FirstName +
                    " " + player.LastName +" icin indirim uygulanmadi");
            }

            return game;
        }

        public void Sell(ref Game game, ref Player player)
        {
            if (game.Quantity>1)
            {
                game.Quantity--;
                Console.WriteLine(player.FirstName + " " + player.LastName + " adli oyuncu " + game.Name + " oyununu " + game.Price + " TL'ye satin aldi.\n");
                player.Points++;
            }
            else
            {
                Console.WriteLine("Oyun tukendi!");
            }
        }
        
    }
}
