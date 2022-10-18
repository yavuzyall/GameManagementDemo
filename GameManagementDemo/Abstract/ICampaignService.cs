using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void IntegrateCampaign(Game game,Campaign campaign);
    }
}
