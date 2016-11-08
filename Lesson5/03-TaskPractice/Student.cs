using System;

namespace _03_TaskPractice
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return $" Firstname: {Firstname} \n Lastname: {Lastname} \n Age: {Age} \n";
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}