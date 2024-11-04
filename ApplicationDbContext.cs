using System;
using System.Diagnostics;
using dotnet_cyberpunk_challenge_5.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_cyberpunk_challenge_5;

public class ApplicationDbContext : DbContext
{
    public DbSet<AraskaDevice> Devices { get; set; }
    public DbSet<Cluster> Clusters { get; set; }
    public DbSet<DataEvent> DataEvents { get; set; }
    public DbSet<MemoryMapping> MemoryMappings{ get; set; }
    public DbSet<Processes> Processes { get; set; }

    public string DbPath { get; set; }

    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "cyberpunk.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source = {DbPath}");
}
