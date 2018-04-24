using Core;
using System;
using System.Runtime.Serialization;

namespace Core
{ 
    [DataContract]
    public class Session
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime Duration { get; set; }

        [DataMember]
        public SystemUser SystemUser { get; set; }

        [DataMember]
        public Lead Lead { get; set; }
        
        public Session(int id, DateTime date, DateTime duration, SystemUser systemUser, Lead lead)
        {
            this.Id = id;
            this.Date = date;
            this.Duration = duration;
            this.SystemUser = SystemUser;
            this.Lead = lead;
        }
    }
}
