namespace SampleSite.Models.Forms
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class UserForm
    {
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }

        [DisplayName("Age")]
        [Required]
        public int Age { get; set; }
    }
}
