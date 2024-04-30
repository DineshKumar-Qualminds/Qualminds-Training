using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace ProductManagement
{
    class ProductDetails
    {
        private List<Product> products = new List<Product>();


        private static int nextId = 1;

        public Product CreateProduct(Product product)
        {
            // Ensure unique ID generation
            product.ProductId = nextId++;
            products.Add(product);
            return product;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.ProductId == id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(Product updatedProduct)
        {
            var existingProduct = GetProductById(updatedProduct.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = updatedProduct.ProductName;   
                existingProduct.Description = updatedProduct.Description;   
                existingProduct.Price = updatedProduct.Price;   
                existingProduct.ProductImage = updatedProduct.ProductImage; 
            }
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }


}
