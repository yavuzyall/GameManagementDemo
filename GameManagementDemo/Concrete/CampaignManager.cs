using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            //DB'ye kampanya ekleme kodları.
            Console.WriteLine("{0} isimli kampanya sisteme başarıyla eklendi.",campaign.CampaignName);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            //DB'den kampanya silme kodları.
            Console.WriteLine("{0} isimli kampanya sistemden başarıyla silindi.",campaign.CampaignName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            //DB'den kampanya update etme kodları.
            Console.WriteLine("{0} isimli kampanya başarıyla değiştirildi.", campaign.CampaignName);
        }
        public void IntegrateCampaign(Game game, Campaign campaign)
        {
            //DB'den kampanya tanımlama kodları.
            Console.WriteLine("{1} isimli kampanya, {0} isimli oyun için başarıyla yürürlüğe koyuldu.",game.GameName ,campaign.CampaignName);
        }

    }
}
