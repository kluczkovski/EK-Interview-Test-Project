namespace SampleSite.Repositories
{
    using SampleSite.Models.Entities;

    public interface IUserRepository : IRepository<User>
    {
        User GetByName(string name);
    }
}
