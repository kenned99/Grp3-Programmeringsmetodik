using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Model
{
    public class Drink
    {
        public Drink()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public List<Category> Category { get; set; }
        public string Description { get; set; }
        public string[] Ingredients { get; set; }
        public string Instructions { get; set; }
        public Byte[] Image { get; set; }
        public User Author { get; set; }

    }
}
