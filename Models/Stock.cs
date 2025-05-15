using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    //* Entity Stock
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        
        //? Navigation Property
        //? -> Day la 1 Collection NP the hien mqh 1 - Many 
        //? -> 1 Stocks thi se co nhieu Comments
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}