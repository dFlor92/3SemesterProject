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
     public class SessionService : ISessionService
    {
        private SessionController controller = new SessionController();

        public IEnumerable<Session> All()
        {
            return controller.All();
        }

        public void Create(Session entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public Session Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(Session entity)
        {
            controller.Update(entity);
        }
    }
}
