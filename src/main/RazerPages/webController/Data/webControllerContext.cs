using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webController.Models;

namespace webController.Data
{
    public class webControllerContext : DbContext
    {
        public webControllerContext (DbContextOptions<webControllerContext> options)
            : base(options)
        {
        }

        public DbSet<webController.Models.NFCChip> NFCChips { get; set; } = default!;
    }
}
