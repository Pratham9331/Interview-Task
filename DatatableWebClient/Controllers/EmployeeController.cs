using DatatableWebClient.Models;
using Microsoft.AspNetCore.Mvc;

using System.Data;
using System.Data.SqlClient;

namespace DatatableWebClient.Controllers
{
    public class EmployeeController : Controller
    {
        string con = "Data Source=Prathamesh ;Initial Catalog=AnkushTask; Integrated Security=True";
        public IActionResult Index()
        {
            List<EmployeeModel> em = new List<EmployeeModel>();
            
            SqlConnection conn = new SqlConnection(con);
            try
            {
                string command = "usp_GetAllEmp";

                
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.CommandType =CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        em.Add(new EmployeeModel()
                        {
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            Gender = reader.GetString("Gender"),
                            MobileNumber = reader.GetString("MobileNumber"),
                            ProfileImage = reader.GetString("ProfileImage")
                        });
                    }
                }
            }
            
            catch(Exception ex)
            {

            }
            finally { if (conn != null ) { conn.Close(); } }
            return View(em);
        }
    }
}
