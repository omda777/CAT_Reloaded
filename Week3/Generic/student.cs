using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class student
    {
        public Dictionary<string, float> students;
        public student() => students = new Dictionary<string, float>();

        public void add (string name, float grad)
        {
            students.Add(name, grad); 
        }

        public float find(string name)
        {
            return students.ContainsKey(name) ? students[name] : -1;
        }

        public void display(string name)
        {
            if(students.ContainsKey(name))
            {
                Console.WriteLine($"{name} => {students[name]}");
            }
           else
            {
                Console.WriteLine("student does not exsist");
            }
        }
    }
}
