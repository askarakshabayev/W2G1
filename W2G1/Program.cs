using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2G1
{
    class Student
    {
        public string name, surname;
        public double gpa;
        public Student(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + gpa + "\n";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 5/6 1/2
            string s = Console.ReadLine();
            string[] token = s.Split();
            // token[0] = "5/6"
            // token[1] = "1/2"
            string[] s1 = token[0].Split('/'); // s1['5', '6']
            string[] s2 = token[1].Split('/'); // s2['1', '2']
            Complex a = new Complex(int.Parse(s1[0]), int.Parse(s1[1]));
            Complex b = new Complex(int.Parse(s2[0]), int.Parse(s2[1]));
            Complex c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
