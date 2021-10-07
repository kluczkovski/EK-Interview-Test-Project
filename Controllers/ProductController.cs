namespace SampleSite.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using SampleSite.Models.Entities;
    using SampleSite.Models.Forms;
    using SampleSite.Models.PageModels;
    using SampleSite.Models.ViewModels;
    using SampleSite.Repositories;

    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = this.productRepository.GetAll();

            var pageModel = new ProductListPageModel();
            pageModel.Products = products.Select(x => new ProductListItemViewModel(
                x.Id,
                x.Name,
                x.Description,
                x.Price,
                x.Stock
                ));


            return View(pageModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] ProductForm productForm)
        {
            this.productRepository.Add(new Product()
            {
                Name = productForm.Name,
                Description = productForm.Description,
                Price = productForm.Price,
                Stock = productForm.Stock
            });

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = this.productRepository.GetById(id);

            var pageModel = new UpdateProductPageModel()
            {
                ProductForm = new ProductForm()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock
                }
            };

            return View(pageModel);
        }

        [HttpPost]
        public IActionResult Update([FromForm] ProductForm productForm)
        {
            var product = this.productRepository.GetById(productForm.Id);
            product.Name = productForm.Name;
            product.Description = productForm.Description;
            product.Price = productForm.Price;
            product.Stock = productForm.Stock;

            this.productRepository.Update(product);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = this.productRepository.GetById(id);
            this.productRepository.Remove(product);

            return RedirectToAction("Index");
        }
    }
}
