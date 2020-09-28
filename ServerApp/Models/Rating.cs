using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Rating
    {
        public long RatingId { get; set; }
        public int Stars { get; set; }
        public Product Product { get; set; }

    }
}
