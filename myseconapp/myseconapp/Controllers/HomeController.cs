using Dapper;
using Microsoft.AspNetCore.Mvc;
using myseconapp.model;
using myseconapp.Model;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
// Change Npgsql to System.Data.SqlClient
using System.Diagnostics;

namespace mysecondapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Employee()
        {
            using (var connection = new SqlConnection("Server =DESKTOP-7E803O8\\MSSQLSERVER01; Database = Employees; Integrated Security = True;")) // Update the connection string for SQL Server
            {
                connection.Open(); // Open the SQL Server connection
                var query = "SELECT * FROM employee";

                return Ok(connection.Query<Employee>(query));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
