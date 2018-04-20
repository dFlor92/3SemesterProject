using System;
using System.Runtime.Serialization;

namespace Core
{
    public enum Status { Accepted, Delayed, Cancelled, Scheduled, Completed };
    public enum Type { Regular, Half, Phone, Risk };
    [DataContract]
    public class Meeting
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public Status Status { get; set; }
        [DataMember]
        public Type Type { get; set; }
        [DataMember]
        public Agent Agent { get; set; }
        [DataMember]
        public Session Session { get; set; }

        public Meeting(int id, DateTime date, int type, int status, Agent agent, Session session)
        {
            this.Id = id;
            this.Date = date;
            this.Type = (Type)type;
            this.Status = (Status)status;
            this.Agent = agent;
            this.Session = session;

        }

        public Meeting(int id, DateTime date, int type, int status, int agentId, int leadId)
        {
            this.Id = id;
            this.Date = date;
            this.Type = (Type)type;
            this.Status = (Status)status;
        }
    }
}
