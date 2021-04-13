using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name="Category Name")]
        public String Name { get; set; }
    }
}
