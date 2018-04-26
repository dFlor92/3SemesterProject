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
    public class MeetingService : IMeetingService
    {
        private MeetingController controller = new MeetingController();

        public IEnumerable<Meeting> All()
        {
            return controller.All();
        }

        public void Create(Meeting entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public Meeting Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(Meeting entity)
        {
            controller.Update(entity);
        }
    }
}
