using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface ICampaignService
    {
        void Sell(ref Game game, ref Player player);
        Game ApplyDiscount(ref Game game, Player player);
    }
}
