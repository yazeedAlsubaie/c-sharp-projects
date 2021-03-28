using System;
using System.Collections;
using System.Collections.Generic;

namespace myproject
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome!");
            List<Student> students = new List<Student>();
            int leave = 1;
            do
            {
                var student = new Student();
                Console.WriteLine("please enter student name");
                student.name = Console.ReadLine();
                Console.WriteLine("please enter student grade");
                student.grade = int.Parse(Console.ReadLine());
                Console.WriteLine("student information has been added");
                Console.WriteLine("if you want to add another stuednt enter 1 if not enter 0");
                students.Add(student);
                leave = int.Parse(Console.ReadLine());

            } while (leave == 1);

            for (int i = 0; i < students.Count; i++) {
                students[i].print();
            }
        }
    }
}
