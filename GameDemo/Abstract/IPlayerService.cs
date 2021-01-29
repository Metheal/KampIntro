using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
