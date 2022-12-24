using DemoDiary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDiary.Data
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass>options):base(options)
        { }
        public DbSet<Entries> tbldiary { get; set; }
    }
}
