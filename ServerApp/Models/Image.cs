using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Image
    {
        public long ImageId { get; set; }
        public string Alt { get; set; }
        public string ImageIcon { get; set; }

        public Product Product { get; set; }

    }
}
