using System;

public class Session
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }

	public Session(DateTime date, TimeSpan duration)
	{
        this.Date = date;
        this.Duration = duration;
	}
    public Session(int id, DateTime date, TimeSpan duration)
    {
        this.Id = id;
        this.Date = date;
        this.Duration = duration;
    }
}
