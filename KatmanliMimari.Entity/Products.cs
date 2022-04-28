using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KatmanliMimari.Entity
{
 public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
    }
}
