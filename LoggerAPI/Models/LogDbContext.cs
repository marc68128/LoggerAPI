using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAPI.Models
{
    public class LogDbContext : DbContext
    {
        public LogDbContext() : base("LogContext")
        {
            
        }

        public DbSet<Log> Logs { get; set; }
    }
}
