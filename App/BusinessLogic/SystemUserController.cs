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
        DBSystemUser dbSystemUser = new DBSystemUser();
        public IEnumerable<SystemUser> All()
        {
            return dbSystemUser.All();
        }

        public void Create(SystemUser entity)
        {
            dbSystemUser.Create(entity);
        }

        public void Delete(int id)
        {
            dbSystemUser.Delete(id);
        }

        public SystemUser Read(int id)
        {
            return dbSystemUser.Read(id);
            
        }

        public void Update(SystemUser entity)
        {
            dbSystemUser.Update(entity);
        }
    }
}
