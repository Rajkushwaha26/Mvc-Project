using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSP.Models
{
    public class IDept
    {
        List<Department> GetDepartments();
        Department FindDept(int id);
        void AddDept(Department dept);
        void EditDept()
    }
}