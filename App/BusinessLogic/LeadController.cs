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
            throw new NotImplementedException();
        }

        public void Create(Lead entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Lead Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Lead entity)
        {
            throw new NotImplementedException();
        }
    }
}
