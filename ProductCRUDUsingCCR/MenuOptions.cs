using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUDUsingCCR
{
    class MenuOptions
    {
        private ProductActions productActions = new ProductActions();


        public void ShowMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Product");
            Console.WriteLine("2. Read Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Display All Products");
            Console.WriteLine("6. Exit");
        }

        public void HandleUserInput()
        {
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    ReadProduct();
                    break;
                case 3:
                    UpdateProduct();
                    break;
                case 4:
                    DeleteProduct();
                    break;
                case 5:
                    DisplayAllProducts();
                    break;
                case 6:
                    Console.WriteLine("Exiting program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        private void CreateProduct()
        {
            Product product = new Product();
            Console.Write("Enter product name: ");
            product.ProductName = Console.ReadLine();
            Console.Write("Enter product description: ");
            product.Description = Console.ReadLine();


            decimal price = 0;
            bool validPrice = false;
            while (!validPrice)
            {
                Console.Write("Enter product price: ");
                string priceInput = Console.ReadLine();
                if (decimal.TryParse(priceInput, out price))
                {
                    validPrice = true;
                }
                else
                {
                    Console.WriteLine("Invalid price. Please enter a valid number.");
                }
            }
            product.Price = price;
            productActions.CreateProduct(product);
            Console.WriteLine("Product created successfully.");
        }

        private void ReadProduct()
        {
            Console.Write("Enter product ID to read: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productActions.GetProductById(id);
            if (product != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Product ID: {product.ProductId}");
                Console.WriteLine($"Name: {product.ProductName}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }


        private void UpdateProduct()
        {
            Console.Write("Enter product ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product existingProduct = productActions.GetProductById(id);
            if (existingProduct == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter new product name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new description: ");
            string newDescription = Console.ReadLine();
            Console.Write("Enter new price: ");
            decimal newPrice = decimal.Parse(Console.ReadLine());

            existingProduct.ProductName = newName;
            existingProduct.Description = newDescription;
            existingProduct.Price = newPrice;

            productActions.UpdateProduct(existingProduct);
            Console.WriteLine("Product updated successfully.");
        }

        private void DeleteProduct()
        {
            Console.Write("Enter product ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productActions.DeleteProduct(id);
            Console.WriteLine("Product deleted successfully.");
        }

        private void DisplayAllProducts()
        {
            List<Product> products = productActions.GetAllProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            else
            {
                Console.WriteLine("================================================================================");
                Console.WriteLine("| Product ID   |     Name       |        Description             |    Price    |");
                Console.WriteLine("================================================================================");
                foreach (Product product in products)
                {
                    Console.WriteLine($"| {product.ProductId,-11} | {product.ProductName,-20} | {product.Description,-25} | {product.Price,-11} |");
                }
                Console.WriteLine("================================================================================");
            }
        }

    }
}

