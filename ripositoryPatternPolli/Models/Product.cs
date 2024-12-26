using System.ComponentModel.DataAnnotations;

namespace ripositoryPatternPolli.Models
{
    public class Product
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Please enter item name")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Please enter description")]
        public string Description { get; set; }


        [Required(ErrorMessage ="Please enter Price")]
        public decimal Price { get; set; }

    }
}
