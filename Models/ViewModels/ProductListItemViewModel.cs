namespace SampleSite.Models.ViewModels
{
    using System;

    public class ProductListItemViewModel
    {
        public ProductListItemViewModel(int id, string name, string description, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Stock = stock;
            //this.Stock = new Random().Next(1, 99);
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int Stock { get; }
    }
}
