using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        //Navogation Properties
        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
