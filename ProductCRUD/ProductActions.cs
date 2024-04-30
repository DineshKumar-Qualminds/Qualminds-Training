using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementCRUD
{
    class ProductActions
    {
        private string connectionString = "Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;";

        //Create Product
        public void CreateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Products (ProductName, Description, Price) VALUES (@ProductName, @Description, @Price)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Price", product.Price);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Product created successfully.");
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Products WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductId", id);

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
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(sql, connection);

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
            }
            return products;
        }

        //Update Product
        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Products SET ProductName = @ProductName, Description = @Description, Price = @Price WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Price", product.Price);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Delete Product
        public void DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Products WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductId", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        
    }
}
