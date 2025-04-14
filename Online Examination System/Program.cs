namespace Online_Examination_System
{
    class Program
    {
        static void Main()
        {



            var q1 = new TrueFalseQuestion("Q1", "c++ is programing language ?", 2, new Answer[]
            {
            new Answer(1, "True"),
            new Answer(2, "False")
            }, new Answer(1, "True"));

            var q2 = new MCQQuestion("Q2", "What is out  2 * 5 = ?", 3, new Answer[]
            {
            new Answer(1, "3"),
            new Answer(2, "10"),
            new Answer(3, "5"),
            new Answer(4, "6")
            }, new Answer(2, "10"));
            var q3 = new MCQQuestion("Q3", "What is out  2 + 5 = ?", 3, new Answer[]
            {
            new Answer(1, "3"),
            new Answer(2, "10"),
            new Answer(3, "7"),
            new Answer(4, "6")
            }, new Answer(3, "7"));

            var q4 = new MCQQuestion("Q4", "What is out  12 / 3 = ?", 3, new Answer[]
            {
            new Answer(1, "3"),
            new Answer(2, "10"),
            new Answer(3, "5"),
            new Answer(4, "4")
            }, new Answer(4, "4"));


            var q5 = new TrueFalseQuestion("Q5", "does 2 * 2 = 4", 2, new Answer[]
            {new Answer(1, "True"),
            new Answer(2, "False")
            }, new Answer(1, "True"));


            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1. Final Exam");
            Console.WriteLine("2. Practical Exam");
            Console.Write("Enter choice (1 or 2): ");
            int examChoice = int.Parse(Console.ReadLine());

            Exam exam;
            if (examChoice == 1)
            {
                exam = new FinalExam(60, 5);
                exam.AddQuestion(q1);
                exam.AddQuestion(q2);
                exam.AddQuestion(q3);
                exam.AddQuestion(q4);
                exam.AddQuestion(q5);
            }
            else
            {
                exam = new PracticalExam(60, 3);
                exam.AddQuestion(q2);
                exam.AddQuestion(q3);
                exam.AddQuestion(q4);

            }

            var subject = new Subject(101, "Math");
            subject.CreateExam(exam);

            Console.Clear();
            Console.WriteLine($"Starting {subject.SubjectName} Exam\n");

            double totalGrade = 0;

            foreach (var question in exam.Questions)
            {
                question.Display();

                Console.Write("\nEnter the answer: ");
                if (!int.TryParse(Console.ReadLine(), out int userAnswerId))
                {
                    Console.WriteLine("Invalid input. Skipping question.\n");
                    continue;
                }

                var selectedAnswer = Array.Find(question.Answers, a => a.ID == userAnswerId);

                if (selectedAnswer == null)
                {
                    Console.WriteLine("Invalid choice. Skipping question.\n");
                }
                else if (selectedAnswer.ID == question.CorrectAnswer.ID)
                {
                    Console.WriteLine("Correct!\n");
                    totalGrade += question.Mark;
                }
                else
                {
                    Console.WriteLine($" Wrong! The correct answer is: {question.CorrectAnswer}\n");
                }
            }

            if (exam is FinalExam)
            {
                double totalPossible = 0;
                foreach (var q in exam.Questions)
                    totalPossible += q.Mark;

                Console.WriteLine($"Your total grade: {totalGrade} out of {totalPossible}");
            }

            Console.WriteLine("\nExam Finished.");
        }
    }
}
