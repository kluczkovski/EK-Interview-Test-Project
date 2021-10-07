using System;
using System.ComponentModel.DataAnnotations;

namespace SampleSite.Models.Entities
{
    public class Address : BaseEntity
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "The Field {0} is required.")]
        public string Address1 { get; set; } = "York Business Park";

        [Required(ErrorMessage = "The Field {0} is required.")]
        public string Address2 { get; set; } = "Great N Way";

        [Required(ErrorMessage = "The Field {0} is required.")]
        public string City { get; set; } = "York";

        [Required(ErrorMessage = "The Field {0} is required.")]
        public string Postcode { get; set; } = "YO26 6RB";

        // EF
        public User User { get; set; }

    }
}
