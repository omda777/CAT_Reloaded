using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum SecurityLevel
    {
        guest, 
        Developer,
        secretary ,
        DBA
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary {  get; set; }
        public Gender Gender { get; set; }  
        public SecurityLevel SecurityLevel { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id , string name , int salary ,Gender gender ,SecurityLevel level ,DateTime hiredate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            SecurityLevel = level;
            HireDate = hiredate;
        }

        public override string ToString()
        {
            return $"Name:{Name,-12}\nID:{Id}\nSalary:{String.Format("{0:C}", Salary)}\n" +
                $"Gender:{Gender}\nSecurity level:{SecurityLevel}\nHireDate:{HireDate}\n";
        }

    }
}
