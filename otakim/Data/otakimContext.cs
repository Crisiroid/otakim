using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using otakim.Models;

namespace otakim.Data
{
    public class otakimContext : DbContext
    {
        public otakimContext (DbContextOptions<otakimContext> options)
            : base(options)
        {
        }

        public DbSet<otakim.Models.Project> Projects { get; set; } = default!;
        public DbSet<otakim.Models.User> Users { get; set; } = default!;
        public DbSet<otakim.Models.Task> Tasks { get; set; }

        public DbSet<otakim.Models.Group> Groups { get; set; }
    }
}
