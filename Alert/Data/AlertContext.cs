using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Alert.Models
{
    public class AlertContext : DbContext
    {
        public AlertContext (DbContextOptions<AlertContext> options)
            : base(options)
        {
        }

        public DbSet<Alert.Models.DataModel> DataModel { get; set; }
    }
}
