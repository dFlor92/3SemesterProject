using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogic;
using Core;
using DataAccesLayer;

namespace NobiService
{
    public class LeadService : ILeadService
    {
        private LeadController controller = new LeadController();

        public IEnumerable<Lead> All()
        {
            return controller.All();
        }
        public IEnumerable<Lead> AllUncalledLeads()
        {
            return controller.AllUncalledLeads();
        }

        public void Create(Lead entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public Lead Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(Lead entity)
        {
            controller.Update(entity);
        }
    }
}
