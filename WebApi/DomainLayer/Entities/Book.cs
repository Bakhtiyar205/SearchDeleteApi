using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Page { get; set; }
    }
}
