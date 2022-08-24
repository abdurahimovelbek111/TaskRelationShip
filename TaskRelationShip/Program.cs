// See https://aka.ms/new-console-template for more information
Console.Write("N=");
int n=int.Parse(Console.ReadLine());
int haftsoni = 364/7,x=0,k=0;
SortedList<int,int> list = new SortedList<int,int>();
if(n>=1 && n<=500000)
{
    for (int i = 1; i < 101; i++)
    {
        for (int j = 1; j < 101; j++)
        {
            if(7*i+21*j==n/haftsoni)
            {
                x = i;
                k = j;
                list.Add(x, k);
            }
        }
    }
    int l=0;
    foreach (var item in list)
    {
        if(list.Count-1==l)
        {
            x = item.Key;
            k= item.Value;
        }
        l++;
    }
    Console.WriteLine($"{x} {k}");
}










#region
/*using TaskRelationShip.Context;
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
Console.WriteLine("Zor");*/
#endregion

