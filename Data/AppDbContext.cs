﻿using Microsoft.EntityFrameworkCore;

namespace WebAppskTestVS.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Person> Persons { get; set; }
    }

  
}
