namespace SampleSite.Models.PageModels
{
    using System.Collections.Generic;
    using SampleSite.Models.ViewModels;

    public class ProductListPageModel
    {
        public IEnumerable<ProductListItemViewModel> Products { get; set; }
    }
}
