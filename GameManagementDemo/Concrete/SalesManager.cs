using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void SellTo(Game game, Players player, Campaign campaign = null)
        {
            if (campaign == null)
            {
                Console.WriteLine("{0} isimli oyuncu, {1} oyununu {2}TL fiyatına satın aldı.", player.FirstName, game.GameName, game.GamePrice);
            }
            else
            {
                float calculator = game.GamePrice - ((game.GamePrice * campaign.DiscountRate)/100); 
                Console.WriteLine("{0} isimli oyuncu, {1} oyununu %{2} indirimle {3}TL fiyatına satın aldı.",player.FirstName, game.GameName, campaign.DiscountRate, calculator);
            }
            
        }
    }
}
