namespace SampleSite.Services.Implementation
{
    using SampleSite.Models.Entities;
    using SampleSite.Repositories;

    public class DataSeeder : IDataSeeder
    {
        private readonly IProductRepository productRepository;
        private readonly IUserRepository userRepository;

        public DataSeeder(
            IProductRepository productRepository,
            IUserRepository userRepository)
        {
            this.productRepository = productRepository;
            this.userRepository = userRepository;
        }

        public void Seed()
        {
            if (this.productRepository.Count() == 0)
            {
                this.productRepository.Add(new Product() { Name = "test", Description = "test description", Price = 3.5M , Stock = 10});
                this.productRepository.Add(new Product() { Name = "test 2", Description = "test description 2", Price = 5M, Stock = 20 });
                this.productRepository.Add(new Product() { Name = "test 3", Description = "test description 3", Price = 7M, Stock = 30 });
                this.productRepository.Add(new Product() { Name = "test 4", Description = "test description 4", Price = 9M, Stock = 40 });
            }

            if (this.userRepository.Count() == 0)
            {
                this.userRepository.Add(new User() { UserName = "TestUser1", Email = "testuser1@test.co.uk", Age = 26 });
                this.userRepository.Add(new User() { UserName = "TestUser2", Email = "testuser2@test.co.uk", Age = 28 });
                this.userRepository.Add(new User() { UserName = "TestUser3", Email = "testuser3@test.co.uk", Age = 30 });
                this.userRepository.Add(new User() { UserName = "TestUser4", Email = "testuser4@test.co.uk", Age = 24 });
                this.userRepository.Add(new User() { UserName = "TestUser4", Email = "testuser5@test.co.uk", Age = 40 });
                this.userRepository.Add(new User() { UserName = "TestUser6", Email = "testuser6@test.co.uk", Age = 66 });
            }
        }
    }
}
