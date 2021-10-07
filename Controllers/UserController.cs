namespace SampleSite.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SampleSite.Models.Entities;
    using SampleSite.Models.Forms;
    using SampleSite.Models.PageModels;
    using SampleSite.Models.ViewModels;
    using SampleSite.Repositories;

    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IAddressRepository addressRepository;

        public UserController(IUserRepository userRepository, IAddressRepository addressRepository)
        {
            this.userRepository = userRepository;
            this.addressRepository = addressRepository;
        }

        public IActionResult Index()
        {
            var users = this.userRepository.GetAll();

            var pageModel = new UserListPageModel();
            pageModel.Users = users.Select(x => new UserListItemViewModel(
                x.Id,
                x.UserName,
                x.Email,
                x.Age));

            return View(pageModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] UserForm userForm)
        {
            this.userRepository.Add(new User()
            {
                UserName = userForm.UserName,
                Email = userForm.Email,
                Age = userForm.Age
            });


            // Get User Id
            var user = userRepository.GetByName(userForm.UserName);

            //Add default Address for the User
            var address = new Address();
            address.UserId = user.Id;
            this.addressRepository.Add(address);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = this.userRepository.GetById(id);

            var pageModel = new UpdateUserPageModel()
            {
                UserForm = new UserForm()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Age = user.Age
                }
            };

            return View(pageModel);
        }

        [HttpPost]
        public IActionResult Update([FromForm] UserForm userForm)
        {
            var user = this.userRepository.GetById(userForm.Id);
            user.UserName = userForm.UserName;
            user.Email = userForm.Email;
            user.Age = userForm.Age;

            this.userRepository.Update(user);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var user = this.userRepository.GetById(id);
            this.userRepository.Remove(user);

            return RedirectToAction("Index");
        }
    }
}
