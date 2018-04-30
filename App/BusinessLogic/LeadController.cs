using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{

    public class LeadController : IDatabaseCRUD<Lead>
    {
        private DBLead db = new DBLead();

        public IEnumerable<Lead> All()
        {
            return db.All();
        }

        public IEnumerable<Lead> AllUncalledLeads()
        {
            return db.AllUncalledLeads();
        }

        public void Create(Lead entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Lead Read(int id)
        {
            return db.Read(id);
        }

        public void Update(Lead entity)
        {
            db.Update(entity);
        }
    }
}
