using System.ComponentModel.DataAnnotations;

namespace Webstore.Models
{
    public class Ware
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public byte[]? Photo { get; set; }

    }
}
