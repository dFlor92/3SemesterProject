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
        private DBCampaign db = new DBCampaign();

        public IEnumerable<Campaign> All()
        {
            return db.All();
        }

        public void Create(Campaign entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Campaign Read(int id)
        {
            return db.Read(id);
        }

        public void Update(Campaign entity)
        {
            db.Update(entity);
        }
    }
}
