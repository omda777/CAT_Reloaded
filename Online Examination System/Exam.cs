using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System
{
    
    public abstract class Exam
    {
        public int Time { get; set; } 
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }

   
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

      
    }

    
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

      
    }
}
