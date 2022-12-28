using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobTN.Models;

namespace JobTN.Data
{
    public class JobTNContext : DbContext
    {
        public JobTNContext (DbContextOptions<JobTNContext> options)
            : base(options)
        {
        }

        public DbSet<JobTN.Models.Company> Company { get; set; } = default!;
    }
}
