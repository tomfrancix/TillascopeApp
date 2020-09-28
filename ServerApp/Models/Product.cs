using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Description { get; set; }
        public string AdditionalInfo { get; set; }
        public string ImageIcon { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public Blueprint Blueprint { get; set; }
        public List<Image> Images {get; set; }
        public List<Rating> Ratings {get; set; }

    }
}
