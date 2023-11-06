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
        }
        public void EditDept(Department dept){
            db.Departments.Add(dept);
        }
        public void DeleteDept(Department dept){
            db.Departments.Add(dept);
        }

        public Department FindDept(int id){
            db.Departments.Add(dept);
        }
        public void AddDept(Department dept){
            db.Departments.Add(dept);
        }

        
    }
}