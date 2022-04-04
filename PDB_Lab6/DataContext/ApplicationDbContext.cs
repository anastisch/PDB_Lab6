using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PDB_Lab6.Models;

namespace PDB_Lab6.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "Myconnection")
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}