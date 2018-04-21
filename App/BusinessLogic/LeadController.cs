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
        DBLead dbLead = new DBLead();

        public IEnumerable<Lead> All()
        {
            return dbLead.All();
        }

        public void Create(Lead entity)
        {
            dbLead.Create(entity);
        }

        public void Delete(int id)
        {
            dbLead.Delete(id);
        }

        public Lead Read(int id)
        {
            return dbLead.Read(id);
        }

        public void Update(Lead entity)
        {
            dbLead.Update(entity);
        }
    }
}
