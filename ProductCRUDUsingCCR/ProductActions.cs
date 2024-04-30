using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductCRUDUsingCCR
{
    internal class ProductActions
    {
        SqlConnection connection = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Pooling=False");
        SqlCommand? command;
        SqlDataReader? reader;


        //Create Product
        public void CreateProduct(Product product)
        {
            using (connection)
            {
                string sqlText = $"INSERT INTO Products (ProductName, Description, Price) VALUES ('{product.ProductName}', '{product.Description}', {product.Price})";
                SqlCommand command = new SqlCommand(sqlText, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error creating product: " + ex.Message);
                }
            }
        }



        //Read Product
        public Product GetProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Pooling=False"))
            {
                string sqlText = $"SELECT * FROM Products WHERE ProductId = {id}";
                using (SqlCommand command = new SqlCommand(sqlText, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductId = (int)reader["ProductId"],
                                ProductName = reader["ProductName"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = (decimal)reader["Price"]
                            };
                        }
                        return null;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error reading product: " + ex.Message);
                        return null;
                    }
                }
            }
        }


        //Update Product
        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Pooling=False"))
            {
                string sqlText = $"UPDATE Products SET ProductName = '{product.ProductName}', Description = '{product.Description}', Price = {product.Price} WHERE ProductId = {product.ProductId}";
                SqlCommand command = new SqlCommand(sqlText, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Delete Product
        public void DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Pooling=False"))
            {
                string sqlText = $"DELETE FROM Products WHERE ProductId = {id}";
                SqlCommand command = new SqlCommand(sqlText, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Display All Products
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Pooling=False"))
            {
                string sqlText = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(sqlText, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
               

                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = (int)reader["ProductId"],
                            ProductName = reader["ProductName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Price = (decimal)reader["Price"]
                        });
                    }
                    connection.Close();
                    return products;
                   
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error getting all products: " + ex.Message);
                    return null;
                }
            }
        }


    }
}
