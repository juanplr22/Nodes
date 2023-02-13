using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nodes.Entities;

namespace Nodes.Data
{
    public class ApidDbContext : DbContext
    {
        public ApidDbContext(DbContextOptions<ApidDbContext> options) : base(options)
        {
        }

        public DbSet<NodesTree> Nodos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new Initializer(modelBuilder).Seed();
        }
    }
}
