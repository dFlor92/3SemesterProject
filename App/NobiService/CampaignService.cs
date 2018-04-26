using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic;
using Core;

namespace NobiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CampaignService" in both code and config file together.
    public class CampaignService : ICampaignService
    {
        private CampaignController controller;

        public CampaignService()
        {
            controller = new CampaignController();
        }
        public IEnumerable<Campaign> All()
        {
            return controller.All();
        }

        public void Create(Campaign entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public Campaign Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(Campaign entity)
        {
            controller.Update(entity);
        }
    }
}
