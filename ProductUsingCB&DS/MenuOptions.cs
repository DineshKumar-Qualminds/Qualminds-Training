using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUsingCB_DS
{
    public class MenuOptions
    {
        // Declare class variables
        DbHelper dbHelper = new DbHelper();
        DataSet data;
        DataTable productDataTable;

        // Constructor to initialize class variables
        public MenuOptions()
        {
            // Fill the dataset with data from the database
            data = dbHelper.FillDataSet();
            // Get the product data table from the dataset
            productDataTable = data.Tables[0];

            /* // Set the ProductId column as the primary key
             productDataTable.PrimaryKey = new DataColumn[] { productDataTable.Columns["ProductID"] };*/
        }

        // Display the main menu options
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

        // Handle user input based on the selected option
        public void HandleUserInput()
        {
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
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




        // Create a new product
        public void CreateProduct()
        {
            // Create a new row in the product data table
            DataRow newRow = productDataTable.NewRow();

            // Prompt user for product details
            Console.Write("Enter Product Name:");
            newRow["ProductName"] = Console.ReadLine();

            Console.Write("Enter Product Description:");
            newRow["Description"] = Console.ReadLine();

            Console.Write("Enter Product Price:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid input for Price.");
                return;
            }
            newRow["Price"] = price;

            // Generate a new ProductID
            int newProductId = GetNewProductId();
            newRow["ProductID"] = newProductId;

            // Add the new row to the product data table
            productDataTable.Rows.Add(newRow);
            // Update the database with the new data
            dbHelper.UpdateDatabase(data);
            Console.WriteLine("Added Successfully");
            // Display the new ProductID
            Console.WriteLine("Product added with ID: " + newProductId);
        }




        // Get the next available ProductID
        private int GetNewProductId()
        {
            // Find the maximum ProductID in the DataTable and increment it
            int maxProductId = productDataTable.AsEnumerable()
                .Select(row => row.Field<int>("ProductID"))
                .DefaultIfEmpty(0)
                .Max();

            return maxProductId + 1;
        }



        // Delete a product based on the ProductID
        public void DeleteProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            // Find the row with the given ProductID
            DataRow[] deleteRows = productDataTable.Select($"ProductID = {ID}");
            if (deleteRows.Length > 0)
            {
                // Delete the row from the product data table
                deleteRows[0].Delete();
                // Update the database with the new data
                dbHelper.UpdateDatabase(data);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }




        //Delete a product based on the ProductID using Find Method

        /* public void DeleteProduct()
        {
     Console.Write("Enter Product ID:");
     if (!int.TryParse(Console.ReadLine(), out int ID))
     {
         Console.WriteLine("Invalid input for Product Id.");
         return;
     }

     DataRow deleteRow = productDataTable.Rows.Find(ID);

     if (deleteRow != null)
     {
         deleteRow.Delete();
         dbHelper.UpdateDatabase(data);
         Console.WriteLine("Deleted Successfully");
     }
     else
     {
         Console.WriteLine("Row not found");
     }
 }
*/




        // Update product details based on the ProductID
        public void UpdateProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            // Find the row with the given ProductID
            DataRow updateRow = productDataTable.Select($"ProductID = {ID}").FirstOrDefault();

            if (updateRow != null)
            {
                // Prompt user for new product details
                Console.Write("Enter New Product Name:");
                updateRow["ProductName"] = Console.ReadLine();

                Console.Write("Enter New Product Description:");
                updateRow["Description"] = Console.ReadLine();

                Console.Write("Enter New Product Price:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Invalid input for Price.");
                    return;
                }
                updateRow["Price"] = price;

                // Update the database with the new data
                dbHelper.UpdateDatabase(data);
                Console.WriteLine("Updated Successfully");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }




        // Read product details based on the ProductID
        public void ReadProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            // Find the row with the given ProductID
            DataRow getRow = productDataTable.Select($"ProductID = {ID}").FirstOrDefault();

            if (getRow != null)
            {
                // Display the product details
                Console.WriteLine($"ID: {getRow["ProductID"]}, Name: {getRow["ProductName"]}, Description: {getRow["Description"]}, Price: {getRow["Price"]}");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }




        // Display all products in the product data table
        public void DisplayAllProducts()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("| ID    | Name              | Description                     | Price   |");
            Console.WriteLine("--------------------------------------------------------------------------");

            foreach (DataRow row in productDataTable.Rows)
            {
                // Display each product's details
                Console.WriteLine($"| {row["ProductID"],-6} | {row["ProductName"],-16} | {row["Description"],-28} | {row["Price"],-7} |");
            }

            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
