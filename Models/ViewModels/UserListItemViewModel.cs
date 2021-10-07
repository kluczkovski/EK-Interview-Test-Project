namespace SampleSite.Models.ViewModels
{
    public class UserListItemViewModel
    {
        public UserListItemViewModel(int id, string userName, string email, int age)
        {
            this.Id = id;
            this.UserName = userName;
            this.Email = email;
            this.Age = age;
        }

        public int Id { get; }
        public string UserName { get; }
        public string Email { get; }
        public int Age { get; }
    }
}
