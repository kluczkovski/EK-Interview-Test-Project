using System.Collections.Generic;

namespace SampleSite.Models.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public IEnumerable<Address> Addresss { get; set; }
    }
}
