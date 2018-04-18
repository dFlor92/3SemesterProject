using Core;
using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NobiService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Create(Shift entity);

        [OperationContract]
        Shift Read(int id);

        [OperationContract]
        void Update(Shift entity);

        [OperationContract]
        void Delete(int id);
    }
}
