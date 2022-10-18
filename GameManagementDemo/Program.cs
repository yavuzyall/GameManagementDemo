using System;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players { Id = 1, FirstName = "Yavuz", LastName = "Yalçın", DateOfBirth = new DateTime(2001, 12, 09), NationalityId = 45415536126 };
            Players player2 = new Players { Id = 2, FirstName = "Esma", LastName = "Balcı", DateOfBirth = new DateTime(2001, 05, 28), NationalityId = 27156424784 };
            

            PlayersManager playersManager = new PlayersManager(new MernisCheckManager());

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Yaz İndirimi", DiscountRate = 40};
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Sonbahar İndirimi", DiscountRate = 25 };
            Campaign campaign3 = new Campaign { Id = 3, CampaignName = "Kış İndirimi", DiscountRate = 35 };

            Game game1 = new Game { GameId = 1, GameName = "Grand Theft Auto San Andreas", GamePrice = 55};
            Game game2 = new Game { GameId = 2, GameName = "Counter Strike 1.6", GamePrice = 30 };
            Game game3 = new Game { GameId = 3, GameName = "Insurgency", GamePrice = 60 };

            SalesManager salesManager = new SalesManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            playersManager.Add(player2);
            playersManager.Add(player1);
            playersManager.Delete(player2);
            playersManager.Update(player1, "Ahmet", "Sonuç");
            Console.WriteLine("\n ------------ \n");
            campaignManager.AddCampaign(campaign1);
            campaignManager.AddCampaign(campaign2);
            campaignManager.IntegrateCampaign(game1 ,campaign1);
            Console.WriteLine("\n ------------ \n");
            salesManager.SellTo(game1, player1, campaign1);
            

            
        }
    }
}
