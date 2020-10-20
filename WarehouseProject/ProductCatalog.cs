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

        //public List<Product> AllProducts()
        //{

        //}

        //public List<Product> ProductOutOfStock()
        //{

        //}

        public DateTime NextRestocking(Product product)
        {
            return product.NextStocking;
        }
    }
        
}
