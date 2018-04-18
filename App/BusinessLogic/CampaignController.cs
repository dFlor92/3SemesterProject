using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class CampaignController : ICRUD<Campaign>
    {
        DBCampaign dbCampaign = new DBCampaign();

        public void Create(Campaign entity)
        {
            dbCampaign.Create(entity);
        }

        public void Delete(int id)
        {
            dbCampaign.Delete(id);
        }

        public Campaign Read(int id)
        {
            return dbCampaign.Read(id);
        }

        public void Update(Campaign entity)
        {
            dbCampaign.Update(entity);
        }
    }
}
