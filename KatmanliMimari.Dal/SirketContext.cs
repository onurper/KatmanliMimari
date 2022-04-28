using KatmanliMimari.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Dal
{
  public class SirketContext:DbContext
    {
        public SirketContext(DbContextOptions<SirketContext> db):base(db)
        {
                
        }
        DbSet<Products> Products { get; set; }
        DbSet<Categories> Categories { get; set; }
    }
}
