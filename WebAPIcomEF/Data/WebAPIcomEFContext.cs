using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIcomEF.Models;

namespace WebAPIcomEF.Data
{
    public class WebAPIcomEFContext : DbContext
    {
        public WebAPIcomEFContext (DbContextOptions<WebAPIcomEFContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIcomEF.Models.Animal> Animal { get; set; } = default!;

        public DbSet<WebAPIcomEF.Models.Customer>? Customer { get; set; }

        public DbSet<WebAPIcomEF.Models.Address> Address { get; set; }       

    }
}
