using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StepsShoppingCart.Models;



namespace StepsShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";



            return View();
        }

        public ActionResult Shop()
        {

             IList<ProductViewModel> products = new List<ProductViewModel>();
            

         /*   //Establishing the MySQL Connection
            SqlConnection conn = new SqlConnection("server=USW2862\\SQLEXPRESS;Database=MVCShoppingCart.DAL.StoreContext;User ID=sa;Password=tfast145;Trusted_Connection=False");

            string query;
            SqlCommand SqlCommand;
            SqlDataReader reader;

            SqlDataAdapter adapter = new SqlDataAdapter();
            //Open the connection to db
            conn.Open();

            //Generating the query to fetch the contact details
            query = "SELECT ProductName,NumberOfProductsAvailable,ProductPrice FROM 'Product'";

            SqlCommand = new SqlCommand(query, conn);
            adapter.SelectCommand = new SqlCommand(query, conn);
            //execute the query
            reader = SqlCommand.ExecuteReader();
            //Assign the results 

            GridView1.DataSource = reader;

            //Bind the data
            GridView1.DataBind();
            return View(displayEmployeeViewModel);*/
            string someConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            //SqlConnection conn = new SqlConnection(someConnectionString);
            //conn.Open();
            //SqlCommand command = new SqlCommand("select * from Product", conn);
            //DataTable results = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.Fill(results, command);                
            

            // Connect to the Database          
            SqlConnection objConnection = new SqlConnection(someConnectionString);
            objConnection.Open();
            DataSet objDataSet = new DataSet("OD-Prod");
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            //  Construct the SqlStatement             
            string strCmd = "SELECT ProductName,NumberOfProductsAvailable,ProductPrice from Product";
            SqlCommand selCommand = new SqlCommand(strCmd, objConnection);
            objDataAdapter.SelectCommand = selCommand;

            objDataAdapter.Fill(objDataSet, "product");
            
            
            for (int i = 0; i < objDataSet.Tables["product"].Rows.Count; i++)
			{
			    ProductViewModel productViewModel = new ProductViewModel();
                productViewModel.ProductName = objDataSet.Tables["product"].Rows[i].Field<string>("ProductName");
                products.Add(productViewModel);
			}
            return View(products);
         }


       //public IEnumerable<ProductViewModel> GetProducts()
       //{               
       //     using (var conn = new SqlConnection("server=USW2862\\SQLEXPRESS;Database=MVCShoppingCart.DAL.StoreContext;User ID=sa;Password=tfast145;Trusted_Connection=False"))
       //     using (var cmd = conn.CreateCommand())
       //     {
       //         conn.Open();
       //         cmd.CommandText = "SELECT * FROM Product";
       //         using (var reader = cmd.ExecuteReader())
       //         {                       
       //             while (reader.Read())
       //             {
       //                 yield return new ProductViewModel
       //                 {

       //                     ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
       //                     NumberOfProductsAvailable = reader.GetInt32(reader.GetOrdinal("NumberOfProductsAvailable")),
       //                     ProductPrice = reader.GetFloat(reader.GetOrdinal("ProductPrice")),
       //                 };
       //             };
                      
       //         }
       //     }

       // }


    }
}
