using static System.Console;
using System;
using System.Data.SqlClient;

namespace NewCommonds;

class DbConnection{
    public static string ConnectionMade{
        get{
            return "server=localhost; database=LtiDb;uid=sa;password=examlyMssql@123";
        }
    }
}
class Employee{
        public int EmployeeId {set;get;}
        public string? EmployeeName {set;get;}
        public double Salary {set;get;}
        public DateTime JoinDate {set;get;}

    }
    class EmployeeDetails{
        
        public void AddEmployee(Employee emp){
            try{
                using (con = new SqlConnection(DbConnection.ConnectionMade)){
                    con.Open();
                    string str = $"insert into employees values('{emp.EmployeeName}',{emp.Salary},'{emp.JoinDate}')";
                    SqlCommand cmd = new SqlCommand(str,con);
                    cmd.ExecuteNonQuery();
                }
                WriteLine("Row inserted succefully");
            }catch(Exception ex){
                WriteLine(ex.ToString());
            }
        }
        public void GetXmldata(){
            try{
                using SqlConnection con = new SqlConnection(DbConnection.ConnectionMade);
                con.Open();
                string str = "selcet * from employee for xml auto";
                sqlCommand.Xml.XmlReader reader = ConsoleModifiers.ExceuteXmlReader();
                System.ReadOnlyMemory();
                while(!reader.EOF){
                    Console.WriteLine(reader.ReadOuterXml());
                }
                reader.Close();

            }catch(Exception ex){
                WriteLine(ex.ToString());
            }

        }
    
    class Program
{
        public static void Main()
        {
            EmployeeDetails db = new EmployeeDetails();

            Employee e1 = new Employee
           {
            EmployeeName = "Sanjay Kumar",
            Salary = 34909,
             JoinDate =DateTime.Parse("12-jan-2023")
        };

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
            //db.GetAllEmployee();
        }
}    }

