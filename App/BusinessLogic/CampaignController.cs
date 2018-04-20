using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class CampaignController : IDatabaseCRUD<Campaign>
    {
        DBCampaign dbCampaign = new DBCampaign();

        public IEnumerable<Campaign> All()
        {
            throw new NotImplementedException();
        }

        public void Create(Campaign entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Campaign Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}
