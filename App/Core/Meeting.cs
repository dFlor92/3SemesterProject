using System;
using System.Runtime.Serialization;

namespace Core
{
    public enum MeetingStatus { Accepted, Delayed, Cancelled, Scheduled, Completed };
    public enum Type { Regular, Half, Phone, Risk };
    [DataContract]
    public class Meeting
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public MeetingStatus Status { get; set; }

        [DataMember]
        public Type Type { get; set; }

        [DataMember]
        public Agent Agent { get; set; }

        [DataMember]
        public Session Session { get; set; }

        public Meeting(int id, DateTime date, Type type, MeetingStatus status, Agent agent, Session session)
        {
            this.Id = id;
            this.Date = date;
            this.Type = type;
            this.Status = status;
            this.Agent = agent;
            this.Session = session;

        }
    }
}
