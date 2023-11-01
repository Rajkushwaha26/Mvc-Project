// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;
namespace AdoNetApp{

    class Employee{
        public int EmployeeId {set;get;}
        public string? EmployeeName {set;get;}
        public decimal Salary {set;get;}
        public DateTime JoinDate {set;get;}

    }
    class EmployeeDetails{
        public void AddEmployee(Employee emp){
            string conStr = "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            //string str = "insert into Employees values('Rajesh Kumar',49499,'12-dec-2022')";

            string str = $"insert into employees values ('{emp.EmployeeName}',{emp.Salary},'{emp.JoinDate}')";
            SqlCommand cmd = new SqlCommand(str,con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            Console.WriteLine("Row inserted succefully");
        }
        
        public void DeleteEmployee(int empid){
            string conStr = "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            

            string str = $"delete from employees where employeeid={empid}";
            SqlCommand cmd = new SqlCommand(str,con);
            int count =cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            if(count==0)
                Console.WriteLine("No such employee found");
            else
                Console.WriteLine("EmployeeDeleted succefully");    
            
        }
        public void UpdateEmployee (int empid, Employee emp){
            string conStr = "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            

            string str = $"update employees set employeename='{emp.EmployeeName}',salary={emp.Salary},joindate='{emp.JoinDate}'";

            SqlCommand cmd = new SqlCommand(str,con);
            int count =cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            if(count==0)
                Console.WriteLine("No such employee found");
            else
                Console.WriteLine("Employee Updated succefully");    
            
        }
        public void SearchEmployee(int empid){
            string conStr = "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            

            string str = $"select * from employees where employeeid={empid}";
            SqlCommand cmd = new SqlCommand(str,con);
            SqlDataReader reader = cmd.ExecuteReader();
            int count =cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            if(count==0)
                Console.WriteLine("No such employee found");
            else
                Console.WriteLine("EmployeeDeleted succefully");    
            
        }
        public void GetAllEmployee(){
            string conStr = "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string str = $"select * from employees";
            SqlCommand cmd = new SqlCommand(str,con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read()==true){
                Console.WriteLine("{0},{1},{2},{3}",reader.GetInt32(0),reader.GetString(1),reader.GetDecimal(2),reader.GetDateTime(3));
            }
            reader.Close();
        
            con.Close();
            con.Dispose();
                
            
        }
    }
    class Program{
        public static void Main()
        {
            EmployeeDetails db = new EmployeeDetails();

            //Employee e1 = new Employee
           // {
               // EmployeeName = "Sanjay Kumar",
               // Salary = 34909,
               // JoinDate =DateTime.Parse("12-jan-2023")
           // };

           // db.AddEmployee(e1);

           // db.DeleteEmployee(21);

            //Employee newemp = new Employee{
               // EmployeeName = "Raj Kumar",
               // Salary = 35670,
               // JoinDate =DateTime.Parse("17-jan-2023")
            //};
            //
            //db.UpdateEmployee(2,newemp);
            //
            //db.SearchEmployee(53);
            //
            db.GetAllEmployee();
        }
    }
}
