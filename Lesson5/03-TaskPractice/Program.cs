using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_TaskPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Task<List<Student>> task = new Task<List<Student>>(getStudents, 10);
            task.Start();
            List<Student> students = task.Result;

            foreach (Student student in students) {
                student.ConsoleWrite();
            }

            Console.ReadKey();
        }

        static Student getStudent()
        {
            string[] firstnames = {
                "Vasya",
                "Kolya",
                "Petya"
            };

            Random r = new Random();
            Student student = new Student()
            {
                Firstname = firstnames[r.Next(firstnames.Length)],
                Lastname = "Pupkin",
                Age = 20
            };

            return student;
        }

        static List<Student> getStudents(object count)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < (int)count; i++) {
                students.Add(getStudent());

                Thread.Sleep(1000);

                Console.WriteLine($"Student {students[i].Firstname} added.");
            }
            return students;
        }
    }
}
