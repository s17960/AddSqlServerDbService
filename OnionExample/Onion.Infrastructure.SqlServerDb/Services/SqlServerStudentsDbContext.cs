using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.SqlServerDb.Services
{
    public partial class SqlServerStudentsDbContext : DbContext
    {
        public SqlServerStudentsDbContext() { }

        public SqlServerStudentsDbContext(DbContextOptions<SqlServerStudentsDbContext> options)
            : base(options) { }

        public virtual DbSet<Student> Students{ get; set; }
        public virtual DbSet<StudentGroup> StudentsGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=PRO2;Integrated Security=True");
        }
    }
}
