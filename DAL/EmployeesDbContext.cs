﻿using Microsoft.EntityFrameworkCore;

namespace CRUD_WebApi.DAL {
    public class EmployeesDbContext : DbContext {
        public EmployeesDbContext() { }

        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }

        // определение структуры таблицы Employees
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Employee>(entity => {
                entity.ToTable(nameof(Employees));
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}