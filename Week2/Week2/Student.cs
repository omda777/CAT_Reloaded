using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Student
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public float Grade { get; set; }

        public Student(string _name  , int _age , float _grade) 
        {
            Name = _name;
            Age = _age;
            Grade = _grade;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Name:{Name,-15}\t Age:{Age}\t Grade:{Grade}");
        }
    }

    public class PostGraduate : Student
    {
        public string ThesisTopic { get; set; }

        public PostGraduate(string _name, int _age, float _grade ,string _thesistopic): base (_name,_age,_grade)
        { 
            ThesisTopic = _thesistopic;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Name:{Name,-15}\t Age:{Age}\t Grade:{Grade}\nThesis Topic:{ThesisTopic}");
        }
    }

}
