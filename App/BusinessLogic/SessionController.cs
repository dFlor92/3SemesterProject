using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class SessionController : IDatabaseCRUD<Session>
    {
        DBSession dbSession = new DBSession();
        public IEnumerable<Session> All()
        {
            return dbSession.All();
        }

        public void Create(Session entity)
        {
            dbSession.Create(entity);
        }

        public void Delete(int id)
        {
            dbSession.Delete(id);
        }

        public Session Read(int id)
        {
            return dbSession.Read(id);
        }

        public void Update(Session entity)
        {
            dbSession.Update(entity);
        }
    }
}
