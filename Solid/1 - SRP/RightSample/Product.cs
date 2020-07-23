using System;

namespace RightSample
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsValid() => (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description));
    }
}