using Exam1Pronia.Models.Base;

namespace Exam1Pronia.Models
{
    public class Images :BaseEntity
    {
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
    }
}
