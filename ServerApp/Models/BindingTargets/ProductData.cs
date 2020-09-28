using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ServerApp.Models.BindingTargets
{
    public class ProductData
    {
        [Required]
        public string Category { get => Product.Category; set => Product.Category = value; }
        [Required]
        public string Subcategory { get => Product.Subcategory; set => Product.Subcategory = value; }
        [Required]
        public string Description { get => Product.Description; set => Product.Description = value; }
        [Required]
        public string AdditionalInfo { get => Product.AdditionalInfo; set => Product.AdditionalInfo = value; }
        [Required]
        public string ImageIcon { get => Product.ImageIcon; set => Product.ImageIcon = value; }
        [Required]
        public int Quantity { get => Product.Quantity; set => Product.Quantity = value; }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be at least 1")]
        public decimal Price { get => Product.Price; set => Product.Price = value; }

        public long? Blueprint
        {
            get => Product.Blueprint?.BlueprintId ?? null;
            set
            {
                if (!value.HasValue)
                {
                    Product.Blueprint = null;
                }
                else
                {
                    if (Product.Blueprint == null)
                    {
                        Product.Blueprint = new Blueprint();
                    }
                    Product.Blueprint.BlueprintId = value.Value;
                }
            }
        }

        public Product Product { get; set; } = new Product();


    }
}