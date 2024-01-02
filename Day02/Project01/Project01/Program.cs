using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Ifoway Interview Process");
            try
            {
                Student student = new Student();
                student.Selected += PassedStudents;
                student.Selected += ExcellentStudents;
                student.Rejected += FailedStudents;
                student.StudentId = 20111;
                student.StudentName = "Test";
                student.City = "Durg";
                student.TotalMarks = 78;
                if (student.TotalMarks < 95)
                {
                    student.Selected-=ExcellentStudents;
                }
                bool confirm = false;
                string result0 = student.CalculateResultRef(student.TotalMarks, ref confirm);
                string result1 = student.CalculateResultOut(student.TotalMarks, out confirm);
                Console.WriteLine(result0);
                Console.WriteLine(result1);
                Console.WriteLine(confirm);
                student.InterviewRounds("Round-1");
                student.InterviewRounds("Round-1","Round-2");
                student.InterviewRounds("Round-1","Round-2","ROund-3","Round-4");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        private static void PassedStudents()
        {
            Console.WriteLine("Record Stored in Oracle DataBase");
        }
        private static void ExcellentStudents()
        {
            Console.WriteLine("Record Stored in  DB2 Database!");
        }
        private static void FailedStudents() {
            Console.WriteLine("Record Stored in MySQQL Server Database");
        }
    }
}
