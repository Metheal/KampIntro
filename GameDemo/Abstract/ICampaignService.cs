using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface ICampaignService
    {
        void Sell(Game game, Player player);
        Game ApplyDiscount(Game game, Player player);
    }
}
