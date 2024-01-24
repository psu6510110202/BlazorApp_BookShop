using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlyBookShop.Data
{
    public class BookData
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Description can't be longer than 255 characters.")]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1990, 2024, ErrorMessage ="Year must be in range 1990 - 2024.")]
        public int Year { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage ="Price must be in range 0 - 1000.")]
        public int Price { get; set; }
        [Required]        
        public string Url { get; set; }
    }
}
