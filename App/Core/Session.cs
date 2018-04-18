using System;

public class Session
{
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }

	public Session(DateTime date, TimeSpan duration)
	{
        this.Date = date;
        this.Duration = duration;
	}
}
