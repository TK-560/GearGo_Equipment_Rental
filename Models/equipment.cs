using System;

public class equipment
{
	public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public bool isAvailable { get; set; }
    public double DailyRate { get; set; } = 0;
    public equipment(){}
}
