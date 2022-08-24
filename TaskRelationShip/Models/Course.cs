using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRelationShip.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public Course()
        {
            Students = new HashSet<Student>();
        }

        ICollection<Student> Students { get; set; }
    }
}
