using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mozgva.ViewModels
{
    public class ProductViewModel
    {
        public int? Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string CardImageFileName { get; set; }
    }
}
