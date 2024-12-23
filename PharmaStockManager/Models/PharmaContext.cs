﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PharmaStockManager.Models
{
    public class PharmaContext : IdentityDbContext<IdentityUser>
    {
        public PharmaContext(DbContextOptions<PharmaContext> options) : base(options)
        {
        }

        public DbSet<Drug>? Drugs { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Transaction>? Transactions { get; set; } // Yeni eklenen Transaction DbSet'i

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Painkillers" },
                new Category { Id = 2, Name = "Antibiotics" }
            );

            // Seed data for Drugs
            modelBuilder.Entity<Drug>().HasData(
<<<<<<< Updated upstream
                new Drug { Id = 1, Name = "Aspirin", Category = "Painkillers", Quantity = 50, UnitPrice = 10.0m },
                new Drug { Id = 2, Name = "Amoxicillin", Category = "Antibiotics", Quantity = 30, UnitPrice = 20.0m }
=======
                new Drug
                {
                    Id = 1,
                    Name = "Aspirin",
                    DrugType = "Commercial",
                    ResearchNumber = "R12345",
                   
                    Category = "Painkillers",
                    Quantity = 50,
                    UnitPrice = 10.0m
                },
                new Drug
                {
                    Id = 2,
                    Name = "Amoxicillin",
                    DrugType = "Clinical",
                    ResearchNumber = "RN67890",
                    
                    Category = "Antibiotics",
                    Quantity = 30,
                    UnitPrice = 20.0m
                }
>>>>>>> Stashed changes
            );
        }
    }
}
