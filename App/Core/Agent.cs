using System;

public class Agent
{
    public string Name { get; set; }
    public int Telephone { get; set; }
    public string Email { get; set; }


	public Agent(string name, int telephone, string email)
	{
        this.Name = name;
        this.Telephone = telephone;
        this.Email = email;
	}

    public Agent(string name, int telephone, string email, Campaign campaign)
    {
        this.Name = name;
        this.Telephone = telephone;
        this.Email = email;
    }
}
