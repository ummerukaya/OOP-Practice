using System;

namespace ThisKeyword
{
    class Student
    {
        public int id, age;
        public String name, subject;

        public Student(int id, String name, int age, String subject)
        {
            this.id = id;
            this.name = name;
            this.subject = subject;
            this.age = age;
        }

        public void showInfo()
        {
            Console.WriteLine(id + " " + name + " " + age + " " + subject);
        }
    }

    class StudentDetails
    {
        public static void Main(string[] args)
        {
            Student std1 = new Student(001, "Jack", 23, "Maths");
            Student std2 = new Student(002, "Harry", 27, "Science");
            Student std3 = new Student(003, "Steve", 23, "Programming");
            Student std4 = new Student(004, "David", 27, "English");

            std1.showInfo();
            std2.showInfo();
            std1.showInfo();
            std3.showInfo();
            std4.showInfo();
        }
    }
}
