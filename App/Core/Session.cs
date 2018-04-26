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
        public DateTime Start { get; set; }

        [DataMember]
        public DateTime End { get; set; }

        public TimeSpan Duration { get { return End - Start; } set { } }

        [DataMember]
        public SystemUser SystemUser { get; set; }

        [DataMember]
        public Lead Lead { get; set; }
        
        public Session(int id, DateTime start, DateTime end, SystemUser systemUser, Lead lead)
        {
            this.Id = id;
            this.Start = start;
            this.End = end;
            this.SystemUser = SystemUser;
            this.Lead = lead;
        }
    }
}
