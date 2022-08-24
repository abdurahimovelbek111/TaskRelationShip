// See https://aka.ms/new-console-template for more information
using TaskRelationShip.Context;
using TaskRelationShip.Models;

Console.WriteLine("Hello, World!");
SchoolContext _db = new SchoolContext();
Console.Write("Name :");
string name=Console.ReadLine();
Console.Write("CourseName :");
string courseName = Console.ReadLine();
Console.Write("Description :");
string description=Console.ReadLine();
Student student = new Student();
student.Name = name;
Course course = new Course();
course.Description = description;
course.CourseName = courseName;
_db.Students.Add(student);
_db.SaveChanges();
_db.Courses.Add(course);
_db.SaveChanges();
StudentCourse studentCourse=new StudentCourse();
studentCourse.StudentId = student.StudentId;
studentCourse.CourseId = course.CourseId;
_db.StudentCourses.Add(studentCourse);
_db.SaveChanges();
Console.WriteLine("Zor");
