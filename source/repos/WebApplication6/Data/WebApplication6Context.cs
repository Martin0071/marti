using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class WebApplication6Context : DbContext
    {
        public WebApplication6Context (DbContextOptions<WebApplication6Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.AdminRegModel> Person { get; set; }

        public DbSet<WebApplication6.Models.Flight> Flight { get; set; }

        public DbSet<WebApplication6.Models.AdminLogin> AdminLogin { get; set; }

        public DbSet<WebApplication6.Models.UserReserve> UserReserve { get; set; }
    }
}
