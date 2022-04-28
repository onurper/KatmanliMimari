using KatmanliMimari.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KatmanliMimari.Core
{
 public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly SirketContext _db;
        public BaseRepository(SirketContext db)
        {
            _db = db;
        }
        public void Comit()
        {
            _db.SaveChanges();
        }

        public bool Create(T entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public T Find(int id)
        {
            //return _db.Set<T>().Tolist(); İnterfacesiz yazılımı
            return Set().Find(id);
        }
        public T Find(string id)
        {
            //return _db.Set<T>().Tolist(); İnterfacesiz yazılımı
            return Set().Find(id);
        }


        public ICollection<T> List()
        {
           //return _db.Set<T>().Tolist(); İnterfacesiz yazılımı
           return Set().ToList();
        }

        public bool Update(T enitiy)
        {
            try
            {
                _db.Entry(enitiy).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }
    }
}
