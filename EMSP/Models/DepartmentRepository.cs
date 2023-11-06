using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSP.Models
{
    public class DepartmentRepository : IDept
    {
        EmspdbContext db = new EmspdbContext();

        public void AddDept(Department dept){
            db.Departments.Add(dept);
            db.SaveChanges();
        }
        public void DeleteDept(int id){
            Department department = db.Departments.Find(id);
            db.Departments.Remove(department);
            db.SaveChanges();
        }
        public void EditDept(Department dept){
            Department department = db.Departments.Find(id);
            department.Name = dept.Name;
            db.SaveCahnges();
            
        }
        public Department FindDept(int id){
            var data = db.Departments.Find(id);
            return data;
            
        }
        public List<Department>GetDepartments(){
            return db.Departments.ToList();
        }

      
       

        
    }
}