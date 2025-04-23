using System.ComponentModel.DataAnnotations;

namespace jwt.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
