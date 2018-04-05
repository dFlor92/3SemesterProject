using System;

public class Lead
{
    public string Name { get; set; }
    public string Telephone { get; set; }
    public string Address { get; set; }

	public Lead(string name, string telephone, string address)
	{
        this.Name = name;
        this.Telephone = telephone;
        this.Address = address;
	}
}
