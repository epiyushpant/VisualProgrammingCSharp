using System.Data;
using Dapper;       
using Microsoft.Data.SqlClient;


/* 
 * Execure Non Query : Insert update
 * Execurte Scaler : To get one data (count )
 * Execute Reader : To get multiple value in reader  
 */ 



namespace LearnADODotnet.Models
{
    public class EmployeeDataAccessLayer
    {
        //string connectionString = "Server=PIYUSH;Initial Catalog=LearnADO;User ID=sa;Password=12345; TrustServerCertificate=True;";
        string connectionString =
"Data Source=RAJENDRA\\SQLEXPRESS;Initial Catalog=LearnADO;Integrated Security=True;TrustServerCertificate=True;";



        //To View all employees details    
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.Department = rdr["Department"].ToString();
                    employee.City = rdr["City"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
           
            

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    return con.Query<Employee>("spGetAllEmployees", commandType: CommandType.StoredProcedure).ToList();
            //}
           
        }

        //To Add new employee record    
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@City", employee.City);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            /*

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var parameters = new { Name = employee.Name, Gender = employee.Gender, Department = employee.Department, City = employee.City };
                con.Execute("spAddEmployee", parameters, commandType: CommandType.StoredProcedure);
            }
            */
        }
        

        //To Update the records of a particluar employee  
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@City", employee.City);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
            /*

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var parameters = new { EmpId = employee.EmployeeId, Name = employee.Name, Gender = employee.Gender, Department = employee.Department, City = employee.City };
                con.Execute("spUpdateEmployee", parameters, commandType: CommandType.StoredProcedure);
            }
            */
        }

        //Get the details of a particular employee  
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.Department = rdr["Department"].ToString();
                    employee.City = rdr["City"].ToString();
                }
            }
            return employee;
            
            /*

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                return con.QueryFirstOrDefault<Employee>("SELECT * FROM tblEmployee WHERE EmployeeID = @Id", new { Id = id });
            }
            */
        }

        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            /*

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Execute("spDeleteEmployee", new { EmpId = id }, commandType: CommandType.StoredProcedure);
            }
            */
        }

        public int GetTotalEmployee()
        {
            string query = "SELECT COUNT(*) FROM Employee";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


            /*using (SqlConnection con = new SqlConnection(connectionString))
            {
                return con.ExecuteScalar<int>("SELECT COUNT(*) FROM tblEmployee");
            }
            */
        }

    }
    }
