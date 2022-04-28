using KatmanliMimari.Core;
using KatmanliMimari.Dal;
using KatmanliMimari.Entity;
using KatmanliMimari.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Repository.Classes
{
  public class RepositoryCategories: BaseRepository<Categories> , IRepositoryCategories
    {
        public RepositoryCategories(SirketContext db): base(db)
        {

        }
    }
}
