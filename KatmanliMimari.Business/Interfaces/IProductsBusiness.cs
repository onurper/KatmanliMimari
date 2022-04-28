using KatmanliMimari.Dto;
using KatmanliMimari.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Business.Interfaces
{
   public interface IProductsBusiness
    {
        ICollection<ProductsDto> GetProducts();
        Products Find(int id);
        ICollection<Products> List();
        bool Create(Products p);
        bool Update(Products p);
        bool Delete(Products p);
        void Comit();
    }
}
