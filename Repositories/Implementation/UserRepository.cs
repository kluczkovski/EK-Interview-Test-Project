namespace SampleSite.Repositories.Implementation
{
    using SampleSite.DbContext;
    using SampleSite.Models.Entities;

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SampleSiteDBContext sampleSiteDBContext)
            : base(sampleSiteDBContext)
        {
        }

        public User GetByName(string name)
        {
            return this.Get(x => x.UserName == name);
        }
    }
}
