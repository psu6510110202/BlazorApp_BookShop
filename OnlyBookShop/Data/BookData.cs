using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyBookShop.Data
{
    public class BookData
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Author { get; set; }
        
        public int Year { get; set; }
       
        public int Price { get; set; }
        
        public string Url { get; set; }
    }
}
