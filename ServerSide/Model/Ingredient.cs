using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Model
{
    public class Ingredient
    {
        public Ingredient()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Unit { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
    }
}
