using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Core
{
    public interface IBaseRepository<T> where T:class,new()
    {
        T Find(int id);
        ICollection<T> List();
        bool Create(T entity);
        bool Update(T enitiy);
        bool Delete(T entity);
        void Comit();
        DbSet<T> Set();
    }
}
