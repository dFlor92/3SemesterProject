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
    public interface ISystemUserService
    {
        [OperationContract]
        IEnumerable<SystemUser> All();
        [OperationContract]
        void Create(SystemUser entity);
        [OperationContract]
        SystemUser Read(int id);
        [OperationContract]
        void Update(SystemUser entity);
        [OperationContract]
        void Delete(int id);
    }
}
