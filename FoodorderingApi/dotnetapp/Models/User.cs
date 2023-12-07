using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Datanotations;

namespace dotnetapp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int Password { get; set; }
        public int Email { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }//FK
    }
}