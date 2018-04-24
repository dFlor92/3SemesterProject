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
    public interface ISessionService
    {
        [OperationContract]
        IEnumerable<Session> All();
        [OperationContract]
        void Create(Session entity);
        [OperationContract]
        Session Read(int id);
        [OperationContract]
        void Update(Session entity);
        [OperationContract]
        void Delete(int id);
    }
}
