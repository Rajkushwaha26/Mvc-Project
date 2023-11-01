using EfCoreDbApp.Data;
using Microsoft.EntityFrameworkCore;
//using System;
//using System.Data.SqlClient;


//MyDatabaseContext db = new MyDatabaseContext();
//   0    shownthe database contain 
// foreach(var emp in db.Employees.Include("Department")){
//     Console.WriteLine("{0},{1},{2},{3}",emp.EmployeeId,emp.EmployeeName,emp.Department.DepartmentName,emp.Salary);
// }

// 1     ADD EMPLOYEE
// Employee emp = new Employee{
//     EmployeeName = "AVNJG",
//     DepartmentId = 1,
//     Salary = 348667,
//     JoinDate = DateTime.Parse("12-dec-2023")
// };
// db.Employees.Add(emp);
// db.SaveChanges();
// Console.WriteLine("Row inserted with Id: {0} succefully",emp.EmployeeId);


//     2     TO FIND EMPLOYEE
// var emp = db.Employees.Find(13);
// if(emp!=null)
//     Console.WriteLine("{0},{1},{2}",emp.EmployeeId,emp.EmployeeName, emp.Salary);
// else
//     Console.WriteLine ("No such employee");   

//      3  TO REMOVE/DELETE EMPLOYEE 
// var emp = db.Employees.Find(3);
// if(emp!=null){

//     db.Employees.Remove(emp);
//     db.SaveChanges();
//     Console.WriteLine("deleted");
// }
// else
//     Console.WriteLine("No such Employee");

//      4 UPDATE THE DATA
// var emp = db.Employees.Find(2);
// if(emp!=null){
//     emp.EmployeeName="xfcgch";
//     emp.Salary=77879;
//     db.SaveChanges();
//     Console.WriteLine("updated");
// }else{
//     Console.WriteLine("no such employee");
// }
class program {
    static void Main()
    {
        MyDatabaseContext db  = new MyDatabaseContext();
        // add data
        Employee e1 = new Employee
        {
            EmployeeName = "raj pal",
            DepartmentId = 3,
            Salary = 178986,
            JoinDate= DateTime.Parse("16-feb-2023")
        };
        db.Entry(e1).State = EntityState.Added;
       
        // for delete a data
        // var emp1 = db.Employees.Find(2);
        // if(emp1!=null){
        //     db.Entry(emp1).State = EntityState.Deleted;
        // }else{
        //     Console.WriteLine("Not found ");
        // }
        // finding the data
        var emp2= db.Employees.Find(5);
        if(emp2!=null){
            emp2.EmployeeName="Salman khan";
            db.Entry(emp2).State=EntityState.Modified;
        }else{
            Console.WriteLine("No emlpoyee to update");
        }
            // show all 
        var empList = db.Employees.Include("Department");
        foreach(var emp in empList){

            Console.WriteLine("{0},{1},{2},{3}",emp.EmployeeId,emp.EmployeeName,emp.Salary,db.Entry(emp).State);
        }
        db.SaveChanges();

    }
}





