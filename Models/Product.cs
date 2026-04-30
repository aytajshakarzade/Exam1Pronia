using Azure;

namespace Exam1Pronia.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public  List<Category> Categories { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Images> Images { get; set; }
    }
}
