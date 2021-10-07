namespace SampleSite.Models.Forms
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ProductForm
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Price")]
        [Required]
        public decimal Price { get; set; }

        [DisplayName("Stock")]
        [Required]
        public int Stock { get; set; }
    }
}
