namespace SampleSite.Repositories.Implementation
{
    using SampleSite.DbContext;
    using SampleSite.Models.Entities;

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SampleSiteDBContext sampleSiteDBContext)
            : base(sampleSiteDBContext)
        {
        }
    }
}
