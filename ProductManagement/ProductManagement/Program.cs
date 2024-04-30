namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var productData = new ProductDetails();

           
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create Product");
                Console.WriteLine("2. Read Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Display All Products");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter product description: ");
                            string description = Console.ReadLine();
                            decimal price;
                            bool isValidPrice = false;
                            do
                            {
                                Console.Write("Enter product price: ");
                                if (!decimal.TryParse(Console.ReadLine(), out price))
                                {
                                    Console.WriteLine("Invalid price format. Please enter a valid number.");
                                }
                                else if (price < 0)
                                {
                                    Console.WriteLine("Price cannot be negative. Please enter a valid price.");
                                }
                                else
                                {
                                    isValidPrice = true;
                                }
                            } while (!isValidPrice);

                            Console.Write("Enter product image URL: ");

                            string image = Console.ReadLine();

                            Product newProduct = new Product
                            {
                                ProductName = name,
                                Description = description,
                                Price = price,
                                ProductImage = image
                            };
                            
                            

                            productData.CreateProduct(newProduct);
                            Console.WriteLine("Product created successfully.");
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        // Read Product
                        Console.Write("Enter product ID to read: ");
                        int idToRead;
                        if (!int.TryParse(Console.ReadLine(), out idToRead))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        var product = productData.GetProductById(idToRead);
                        if (product == null)
                        {
                            Console.WriteLine("Product not found.");
                        }
                        else
                        {
                            Console.WriteLine($"Product ID: {product.ProductId}");
                            Console.WriteLine($"Name: {product.ProductName}");
                            Console.WriteLine($"Description: {product.Description}");
                            Console.WriteLine($"Price: {product.Price}");
                            Console.WriteLine($"Image: {product.ProductImage}");
                        }
                        break;

                    case 3:
                        // Update Product
                        Console.Write("Enter product ID to update: ");
                        int idToUpdate;
                        if (!int.TryParse(Console.ReadLine(), out idToUpdate))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        var productToUpdate = productData.GetProductById(idToUpdate);
                        if (productToUpdate == null)
                        {
                            Console.WriteLine("Product not found.");
                            break;
                        }

                        Console.WriteLine($"Selected product: ID: {productToUpdate.ProductId}, Name: {productToUpdate.ProductName}, Description: {productToUpdate.Description}, Price: {productToUpdate.Price}, Image: {productToUpdate.ProductImage}");

                        Console.WriteLine("Select field to update:");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Description");
                        Console.WriteLine("3. Price");
                        Console.WriteLine("4. Image");
                        Console.Write("Enter your choice: ");
                        int fieldChoice;
                        if (!int.TryParse(Console.ReadLine(), out fieldChoice) || fieldChoice < 1 || fieldChoice > 4)
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                        }

                        switch (fieldChoice)
                        {
                            case 1:
                                Console.Write("Enter new name: ");
                                string newName = Console.ReadLine();
                                productToUpdate.ProductName = newName;
                                /*Console.WriteLine("Name updated successfully.");*/
                                break;
                            case 2:
                                Console.Write("Enter new description: ");
                                string newDescription = Console.ReadLine();
                                productToUpdate.Description = newDescription;
                                //productData.UpdateProduct(idToUpdate, productToUpdate.ProductName, newDescription, productToUpdate.Price, productToUpdate.ProductImage);
                                Console.WriteLine("Description updated successfully.");
                                break;
                            case 3:
                                Console.WriteLine("Enter new price:");
                                decimal newPrice;
                                while (!decimal.TryParse(Console.ReadLine(), out newPrice))
                                {
                                    Console.WriteLine("Invalid price format. Please enter a valid number for the price.");
                                }

                                productToUpdate.Price = newPrice;
                                Console.WriteLine("Price updated successfully.");
                                break;
                            case 4:
                                Console.Write("Enter new image URL: ");
                                string newImage = Console.ReadLine();
                                productToUpdate.ProductImage = newImage;
                                //productData.UpdateProduct(idToUpdate, productToUpdate.ProductName, productToUpdate.Description, productToUpdate.Price, newImage);
                                Console.WriteLine("Image updated successfully.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                        //productData.UpdateProduct(productToUpdate);
                        Console.WriteLine("Product updated successfully");
                        break;


                    case 4:
                        // Delete Product
                        Console.Write("Enter product ID to delete: ");
                        int idToDelete;
                        if (!int.TryParse(Console.ReadLine(), out idToDelete))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        productData.DeleteProduct(idToDelete);
                        Console.WriteLine("Product deleted successfully.");
                        break;

                    case 5:
                        // Display All Products
                        // Define the column widths for tabular display
                        int idWidth = 5;
                        int nameWidth = 20;
                        int descriptionWidth = 15;
                        int priceWidth = 10;
                      

                        var allProducts = productData.GetAllProducts();

                        if (allProducts.Count == 0)
                        {
                            Console.WriteLine("No products available.");
                        }
                        else
                        {
                            Console.WriteLine("All Products:");
                            Console.WriteLine($"{"ID".PadRight(idWidth)}{"Name".PadRight(nameWidth)}{"Description".PadRight(descriptionWidth)}{"Price".PadRight(priceWidth)}ProductImage");

                            foreach (var prod in allProducts)
                            {
                                Console.WriteLine($"{prod.ProductId.ToString().PadRight(idWidth)}{prod.ProductName.PadRight(nameWidth)}{prod.Description.PadRight(descriptionWidth)}{prod.Price.ToString().PadRight(priceWidth)}{prod.ProductImage}");
                            }
                          
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}