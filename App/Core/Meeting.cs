using System;


namespace Core
{
    public enum Status { Accepted, Delayed, Cancelled, Scheduled, Completed };
    public enum Type { Regular, Half, Phone, Risk };
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public Agent Agent { get; set; }
        public Lead Lead { get; set; }

        public Meeting(int id, DateTime date, int type, int status, Agent agent, Lead lead)
        {
            this.Id = id;
            this.Date = date;
            this.Type = (Type)type;
            this.Status = (Status)status;
            this.Agent = agent;
            this.Lead = lead;
       
        }
    }
}
