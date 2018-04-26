using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NobiService
{
    [ServiceContract]
    public interface IMeetingService
    {
        [OperationContract]
        IEnumerable<Meeting> All();
        [OperationContract]
        void Create(Meeting entity);
        [OperationContract]
        Meeting Read(int id);
        [OperationContract]
        void Update(Meeting entity);
        [OperationContract]
        void Delete(int id);
    }
}
