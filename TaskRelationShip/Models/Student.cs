using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRelationShip.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        ICollection<Course> Courses { get; set; }
    } 
}
