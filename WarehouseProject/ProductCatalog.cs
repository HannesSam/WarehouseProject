using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class ProductCatalog
    {
        private List<Product> Products { get; set; }

        public ProductCatalog(List<Product> _products)
        {
            this.Products = _products;
        }

        public void AddProduct(Product newProduct)
        {
            this.Products.Add(newProduct);
        }

        //public IEnumerable<Product> AllProducts()
        //{

        //}

        //public IEnumerable<Product> ProductOutOfStock(Product product)
        //{

        //}

        public DateTime NextRestocking(Product product)
        {
            return product.NextStocking;
        }
    }
        
}
