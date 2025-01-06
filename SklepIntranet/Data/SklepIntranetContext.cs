using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SklepIntranet.Models.CMS;

namespace SklepIntranet.Data
{
    public class SklepIntranetContext : DbContext
    {
        public SklepIntranetContext (DbContextOptions<SklepIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<SklepIntranet.Models.CMS.News> News { get; set; } = default!;
        public DbSet<SklepIntranet.Models.CMS.Page> Page { get; set; } = default!;
    }
}
