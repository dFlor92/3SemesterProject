using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class SystemUserController : IDatabaseCRUD<SystemUser>
    {
        private DBSystemUser db = new DBSystemUser();
        public IEnumerable<SystemUser> All()
        {
            return db.All();
        }

        public void Create(SystemUser entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public SystemUser Read(int id)
        {
            return db.Read(id);
            
        }

        public void Update(SystemUser entity)
        {
            db.Update(entity);
        }
    }
}
