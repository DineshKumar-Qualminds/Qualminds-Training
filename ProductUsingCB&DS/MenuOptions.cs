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
        DbHelper dbHelper = new DbHelper();
        DataSet data;
        DataTable productDataTable;

        public MenuOptions()
        {
            data = dbHelper.FillDataSet();
            productDataTable = data.Tables[0];
        }



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

        public void CreateProduct()
        {
            DataRow newRow = productDataTable.NewRow();

            Console.WriteLine("Enter Product Details");
            Console.Write("Enter Product Id:");
            if (!int.TryParse(Console.ReadLine(), out int productId))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }
            newRow["ProductID"] = productId;

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

            productDataTable.Rows.Add(newRow);
            dbHelper.UpdateDatabase(data);
            Console.WriteLine("Added Successfully");
        }

        public void DeleteProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            DataRow[] deleteRows = productDataTable.Select($"ProductID = {ID}");
            if (deleteRows.Length > 0)
            {
                deleteRows[0].Delete();
                dbHelper.UpdateDatabase(data);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }


        public void UpdateProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            DataRow updateRow = productDataTable.Select($"ProductID = {ID}").FirstOrDefault();

            if (updateRow != null)
            {
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

                dbHelper.UpdateDatabase(data);
                Console.WriteLine("Updated Successfully");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }

        public void ReadProduct()
        {
            Console.Write("Enter Product ID:");
            if (!int.TryParse(Console.ReadLine(), out int ID))
            {
                Console.WriteLine("Invalid input for Product Id.");
                return;
            }

            DataRow getRow = productDataTable.Select($"ProductID = {ID}").FirstOrDefault();

            if (getRow != null)
            {
                Console.WriteLine($"ID: {getRow["ProductID"]}, Name: {getRow["ProductName"]}, Description: {getRow["Description"]}, Price: {getRow["Price"]}");
            }
            else
            {
                Console.WriteLine("Row not found");
            }
        }


        public void DisplayAllProducts()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("| ID    | Name              | Description                     | Price   |");
            Console.WriteLine("--------------------------------------------------------------------------");

            foreach (DataRow row in productDataTable.Rows)
            {
                Console.WriteLine($"| {row["ProductID"],-6} | {row["ProductName"],-16} | {row["Description"],-28} | {row["Price"],-7} |");
            }

            Console.WriteLine("--------------------------------------------------------------------------");
        }


    }

}