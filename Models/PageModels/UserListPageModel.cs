namespace SampleSite.Models.PageModels
{
    using System.Collections.Generic;
    using SampleSite.Models.ViewModels;

    public class UserListPageModel
    {
        public IEnumerable<UserListItemViewModel> Users { get; set; }
    }
}
