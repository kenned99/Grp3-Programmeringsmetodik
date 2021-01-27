using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Model
{
    public class DrinksToCategory
    {
        public DrinksToCategory()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public Drink Drink { get; set; }
        public Category Category { get; set; }
    }
}
