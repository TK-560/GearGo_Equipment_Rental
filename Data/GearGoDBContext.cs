using System;
using Microsoft.EntityFrameworkCore;

public class GearGoDBContext: DbContext
{
	public GearGoDBContext (DbContextOptions<GearGoDBContext> options)
        : base(options) {}

    public DbSet<Equipment> Equipment => Set<Equipment>(); 
}
