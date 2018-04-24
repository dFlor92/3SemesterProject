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
        private DBAgent db = new DBAgent();        

        public IEnumerable<Agent> All()
        {
            return db.All();
        }

        public void Create(Agent entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Agent Read(int id)
        {
            return db.Read(id);
        }

        public void Update(Agent entity)
        {
            db.Update(entity);
        }
    }
}
