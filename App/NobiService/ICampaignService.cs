using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NobiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICampaignService" in both code and config file together.
    [ServiceContract]
    public interface ICampaignService
    {
        [OperationContract]
        IEnumerable<Campaign> All();
        [OperationContract]
        void Create(Campaign entity);
        [OperationContract]
        Campaign Read(int id);
        [OperationContract]
        void Update(Campaign entity);
        [OperationContract]
        void Delete(int id);
    }
}
