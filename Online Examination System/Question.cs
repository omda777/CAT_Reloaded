using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System
{


    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        public Question(string header, string body, double mark, Answer[] answers, Answer correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public abstract void Display();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}";
        }
    }

    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double mark, Answer[] answers, Answer correctAnswer)
            : base(header, body, mark, answers, correctAnswer) { }

        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }

   
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, double mark, Answer[] answers, Answer correctAnswer)
            : base(header, body, mark, answers, correctAnswer) { }

        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }

}

