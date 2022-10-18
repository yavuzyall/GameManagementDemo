using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Abstract
{
    public interface ISalesService
    {
        void SellTo(Game game, Players player, Campaign campaign = null);
    }
}
