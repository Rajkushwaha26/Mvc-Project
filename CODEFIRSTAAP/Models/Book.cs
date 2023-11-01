using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODEFIRSTAAP.Models
{
    public class Book
    {
        public int BookId {set; get;} = 0;
        public string? BookName {set; get;}
        
        public decimal Price {set; get;}
        public int Quantity {set; get;}
       
    }
}