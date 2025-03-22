﻿using Microsoft.EntityFrameworkCore;

namespace IntegrationTesting.DataModels.Models;

public class DatabaseContext : DbContext
{
    public DbSet<Command> Commands { get; set; } = null!;
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}