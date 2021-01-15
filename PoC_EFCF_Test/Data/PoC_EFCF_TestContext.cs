using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PoC_EFCF_Test.Models;

namespace PoC_EFCF_Test.Data
{
    public class PoC_EFCF_TestContext : DbContext
    {
        public PoC_EFCF_TestContext (DbContextOptions<PoC_EFCF_TestContext> options)
            : base(options)
        {
        }

        public DbSet<PoC_EFCF_Test.Models.Movie> Movie { get; set; }
    }
}
