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

    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }
    }

    public class TransactionDetail
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Amount must be in range 1 - 10")]
        public int Amount { get; set; }
        [Required]
        public int Price { get; set; }

        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
