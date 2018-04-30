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
    public interface ILeadService
    {
        [OperationContract]
        IEnumerable<Lead> All();
        [OperationContract]
        IEnumerable<Lead> AllUncalledLeads();
        [OperationContract]
        void Create(Lead entity);
        [OperationContract]
        Lead Read(int id);
        [OperationContract]
        void Update(Lead entity);
        [OperationContract]
        void Delete(int id);
    }
}
