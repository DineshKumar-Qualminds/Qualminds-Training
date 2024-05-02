using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUsingCB_DS
{
    internal class DbHelper
    {
        SqlConnection? connectionString = new SqlConnection("Data Source=QUAL-LT7M15F63\\SQLEXPRESS;Initial Catalog=ProductData;Integrated Security=True;");
      
        DataSet dataSet = new DataSet();

        SqlDataAdapter dataAdapter;

        SqlCommandBuilder commandBuilder;


        public DataSet FillDataSet()
        {
            
          
                string selectQuery = "SELECT * FROM Products";
                dataAdapter = new SqlDataAdapter(selectQuery, connectionString);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet, "Products");
            
            return dataSet; // Return the filled DataSet
        }



        public void UpdateDatabase(DataSet data)
        {

            /*dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Products", connectionString);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
*/
            dataAdapter.Update(data, "Products");
          
        }



    }
}
