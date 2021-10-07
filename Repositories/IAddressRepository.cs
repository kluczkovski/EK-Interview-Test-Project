using System;
using System.Collections.Generic;
using SampleSite.Models.Entities;

namespace SampleSite.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetAllAddress(int id);
    }
}
