using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System
{
    public class Answer 
    {
        public int ID { get; }
        public string Description { get; }
        public Answer(int id, string _description)
        {   
            ID= id;
            Description = _description;
        }
        public override string ToString() => $"{ID}. {Description}";
        
    }
}
