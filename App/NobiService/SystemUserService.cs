using BusinessLogic;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NobiService
{
    public class SystemUserService : ISystemUserService
    {
        private SystemUserController controller = new SystemUserController();

        public IEnumerable<SystemUser> All()
        {
            return controller.All();
        }

        public void Create(SystemUser entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public SystemUser Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(SystemUser entity)
        {
            controller.Update(entity);
        }
    }
}
