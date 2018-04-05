using System;


enum Status { Accepted, Delayed, Cancelled, Scheduled, Completed };

public class Meeting
{
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public readonly Status status;

	public Meeting(DateTime date, string type, Status status)
	{
        this.Date = date;
        this.Type = type;
        
	}

    public Meeting(DateTime date, string type, string status, Agent agent, Lead lead)
    {
        this.Date = date;
        this.Type = type;
        this.Status = status;
       
    }


}
