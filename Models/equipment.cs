using System;

public class Equipment
{
	public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    public double DailyRate { get; set; } = 0;
    public string Category { get; set; }    
    public bool Availability { get; set; }
    public Equipment(){}

}
