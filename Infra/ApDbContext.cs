using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AgileWorks.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AgileWorks.Infra
{
    public class ApDbContext: IdentityDbContext
    {
        public ApDbContext (DbContextOptions<ApDbContext> options): base(options) { }
            
        public DbSet<TaskData> Tasks { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<TaskData>().ToTable(nameof(Tasks));
        //}
    }
}
