using System;
using Microsoft.EntityFrameworkCore;
using MinimalApiPostgreSQLEF.Models;

namespace MinimalApiPostgreSQLEF.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options) : base(options)
        {

        }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}

