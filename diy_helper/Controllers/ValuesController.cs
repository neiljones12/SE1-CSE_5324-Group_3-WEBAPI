using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace diy_helper.Controllers
{ 
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            SqlConnection con = new SqlConnection();
            var result = "";
            con.ConnectionString = "Data Source=diy.database.windows.net;Initial Catalog=neil;Integrated Security=False;User Id=neil;Password=P@ssw0rd123;MultipleActiveResultSets=True"; 
            con.Open();
            using (con)
            { 
                SqlCommand cmd = new SqlCommand("Select * from data", con); 
                SqlDataReader rd = cmd.ExecuteReader(); 
                while (rd.Read()) 
                {
                     result = "{data:"+Convert.ToString(rd.GetSqlValue(1))+"}";
                }
            }
            
            return result;
        }

        // GET api/values/5
        public string Get(string id)
        {
            SqlConnection con = new SqlConnection();
            var result = "";
            con.ConnectionString = "Data Source=diy.database.windows.net;Initial Catalog=neil;Integrated Security=False;User Id=neil;Password=P@ssw0rd123;MultipleActiveResultSets=True";
            con.Open();
            using (con)
            {
                string query = "";
                if(id=="users")
                {
                    query = "Select * from data Where name = 'users'";
                }
                else
                {
                    query = "Select * from data Where name = 'projects'";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    result = "{data:" + Convert.ToString(rd.GetSqlValue(1)) + "}";
                }
            }

            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
