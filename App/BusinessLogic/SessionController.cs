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
        private DBSession db = new DBSession();
        public IEnumerable<Session> All()
        {
            return db.All();
        }

        public void Create(Session entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Session Read(int id)
        {
            return db.Read(id);
        }

        public void Update(Session entity)
        {
            db.Update(entity);
        }
    }
}
