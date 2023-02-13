using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nodes.Entities;

namespace Nodes.Data
{
    public class Initializer 
    {
        private readonly ModelBuilder modelBuilder;

        public Initializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<NodesTree>().HasData(
            new NodesTree { id = 1, parent = "padre", title = "one", created_At = DateTime.Now, parentNode = 0, childNode = 0, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 2, parent = "null", title = "two", created_At = DateTime.Now, parentNode = 0, childNode = 0, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 3, parent = "null", title = "three", created_At = DateTime.Now, parentNode = 0, childNode = 0, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 4, parent = "padre", title = "four", created_At = DateTime.Now, parentNode = 0, childNode = 5, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 5, parent = "hijo", title = "five", created_At = DateTime.Now, parentNode = 4, childNode = 0, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 6, parent = "padre", title = "six", created_At = DateTime.Now, parentNode = 0, childNode = 7, timeZone = "Venezuela Standard Time" },
            new NodesTree { id = 7, parent = "hijo", title = "seven", created_At = DateTime.Now, parentNode = 6, childNode = 0, timeZone = "Venezuela Standard Time" }
            ); ;

        }

    }
}
