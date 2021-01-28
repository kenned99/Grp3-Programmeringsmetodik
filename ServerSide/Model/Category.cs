using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Model
{
    public class Category
    {
        public Category()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; } = null!;
    }
}
