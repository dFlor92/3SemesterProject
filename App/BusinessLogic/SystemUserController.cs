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
        public IEnumerable<SystemUser> All()
        {
            throw new NotImplementedException();
        }

        public void Create(SystemUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SystemUser Read(int id)
        {
            throw new NotImplementedException();
            
        }

        public void Update(SystemUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
