using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MachinePark.Shared.Models;

namespace MachinePark.Api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<MachinePark.Shared.Models.Machine> Machine { get; set; } = default!;
    }
}
