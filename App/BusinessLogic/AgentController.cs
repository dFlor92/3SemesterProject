using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class AgentController : IDatabaseCRUD<Agent>
    {
        private IDatabaseCRUD<Agent> db;

        public AgentController()
        {
            db =  new DBAgent();
        }

        public IEnumerable<Agent> All()
        {
            throw new NotImplementedException();
        }

        public void Create(Agent entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Agent Read(int id)
        {
            return db.Read(id);
        }

        public void Update(Agent entity)
        {
            throw new NotImplementedException();
        }
    }
}
