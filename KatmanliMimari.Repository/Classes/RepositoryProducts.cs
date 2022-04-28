using KatmanliMimari.Core;
using KatmanliMimari.Dal;
using KatmanliMimari.Entity;
using KatmanliMimari.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Repository.Classes
{
   public class RepositoryProducts: BaseRepository<Products>, IRepositoryProducts
    {
        public RepositoryProducts(SirketContext db) : base(db)
        {

        }
    }
}
