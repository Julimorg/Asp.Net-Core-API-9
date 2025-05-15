using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // Navigation Property
        // -> Day la 1 Reference NP the hien mqh Many - 1
        // -> Nhieu Comment se co duy nhat 1 Stocks
        public int? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}