
using System;
using System.Data.SqlClient;
using System.Data;
namespace DisconnectedApp;
SqlCommandBuilder build;
string str;

class EmployeeDetails{

    string conStr = "server=localhost; database=LtiDb; uid=sa; password=examlyMssql@123";
        SqlConnection con = new SqlConnection(conStr);
   // con.Open();
        string str = "select employeeid, employeename, salary, joindate from employees";
        SqldDataAdapter da = new SqldDataAdapter(str,con);
        DataSet ds = new Dataset();
        build = new SqlCommandBuilder(da);
        da.Fill(ds,"dtEmployees");
    
    public void GetAllEmployees()
    {
        foreach(DataRow row in ds.Table[0].Rows ){
            Console.WriteLine("{0},{1},{2},{3}",row[0],row[1],row["salary"],row["joindate"]);
        }
}   }
    // public void AddEmployee(Employee emp){
    //     DataRow row = ds.Tables[0].NewRow();
    //     row[1]=emp.EmployeeName;
    //     row["salary"]=emp.Salary;
    //      row["joindate"]=emp.JoinDate;
    //      ds.tables[0].rows.Add(row);
    // }
        public void AddEmployee(Employee emp){
         DataRow row = ds.Tables[0].NewRow();
        row["employename"]=emp.EmployeeName;
       row["salary"]=emp.Salary;
         row["joindate"]=emp.JoinDate;
         ds.Tables[0].rows.Add(row);
         da.Update(ds.Table[0]);
         Console.WriteLine("Row inserted");
     }
     public void SearchEmployee(int empid){
        DataRow row = ds.Tables[0].Rows.Find(empid);
        if(row!=null){
            Console.WriteLine(${row["Employee"]})
        }
     }
     public void DeleteEmployee(int empid){
        DataRow? row=ds.Tables[0].Rows.Find(empid);
        if(row!=null){
            row.Delete();
            da.Update(ds.Tables[0]);

        } else{
            Console.WriteLine("no employee found");
        }
     }
     public void UpdateEmployee(int empid,Employee newemp){
        DataRow? row = ds.Tables[0].Rows.Find(empid);
        if(row!=null){
            row["emoloyeename"]=newemp.EmployeeName;
            row["salary"]=newemp.Salary;
            row["joindate"]=newemp.JoinDate;
            da.Update(ds.Tables[0]);
        }else{
            Console.WriteLine("no empl found");
        }
     }
