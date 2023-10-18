using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaylandMontalvo_PTablas1.Models;

namespace HaylandMontalvo_PTablas1.Data
{
    public class HaylandMontalvo_PTablas1Context : DbContext
    {
        public HaylandMontalvo_PTablas1Context (DbContextOptions<HaylandMontalvo_PTablas1Context> options)
            : base(options)
        {
        }

        public DbSet<HaylandMontalvo_PTablas1.Models.Burger> Burger { get; set; } = default!;
    }
}
