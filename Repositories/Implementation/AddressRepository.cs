using System.Collections.Generic;
using System.Linq;
using SampleSite.DbContext;
using SampleSite.Models.Entities;

namespace SampleSite.Repositories.Implementation
{

    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(SampleSiteDBContext sampleSiteDBContext)
            : base(sampleSiteDBContext)
        {
        }

        public IEnumerable<Address> GetAllAddress(int id)
        {
            return context.Set<Address>().Where(x => x.UserId == id).ToList();
        }
    }
}
