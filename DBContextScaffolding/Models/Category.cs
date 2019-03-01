using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Lenght must be between 6 to 100 Characters")]
        public string Name { get; set; }
    }
}

