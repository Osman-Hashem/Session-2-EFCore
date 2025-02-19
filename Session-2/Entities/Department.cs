using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        //[ForeignKey("Manager")]
        public int EmpId { get; set; }
        public Employee Manager { get; set; } // Navigational Property 


        public List<Employee> Employees { get; set; }

    }
}
