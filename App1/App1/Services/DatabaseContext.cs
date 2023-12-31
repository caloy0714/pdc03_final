﻿
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using App1.Model;
using System.IO;

namespace App1.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AnimalModel> Animals { get; set; }
        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Animal.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}
