using Core;
using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NobiService
{
    [ServiceContract]
    public interface IAgentService 
    {
        [OperationContract]
        IEnumerable<Agent> All();
        [OperationContract]
        void Create(Agent entity);
        [OperationContract]
        Agent Read(int id);
        [OperationContract]
        void Update(Agent entity);
        [OperationContract]
        void Delete(int id);

    }
}