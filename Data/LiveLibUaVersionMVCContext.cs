using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LiveLibUaVersionMVC.Models;

namespace LiveLibUaVersionMVC.Data
{
    public class LiveLibUaVersionMVCContext : DbContext
    {
        public LiveLibUaVersionMVCContext(DbContextOptions<LiveLibUaVersionMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
    }
}
