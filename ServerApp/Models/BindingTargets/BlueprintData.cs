using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models.BindingTargets
{
    public class BlueprintData
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string AdditionalInfo { get; set; }
        [Required]
        public string ImageIcon { get; set; }

        public Blueprint Blueprint => new Blueprint
        {
            Title = Title,
            Summary = Summary,
            Description = Description,
            AdditionalInfo = AdditionalInfo,
            ImageIcon = ImageIcon
        };
    }
}
