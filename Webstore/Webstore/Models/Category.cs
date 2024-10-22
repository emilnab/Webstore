using System.ComponentModel.DataAnnotations;

namespace Webstore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        public string? Description { get; set; }

    }
}
