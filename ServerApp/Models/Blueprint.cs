using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Blueprint
    {
        public long BlueprintId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string AdditionalInfo { get; set; }
        public string ImageIcon { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}
