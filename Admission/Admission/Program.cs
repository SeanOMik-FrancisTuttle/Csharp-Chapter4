using System;
using static System.Console;

namespace Admission {
    class Program {
        static void Main(string[] args) {
            Write("Enter Highschool Grade Point Average (GPA): ");
            double gpa = Convert.ToDouble(ReadLine());
            Write("Enter Admission Test Score: ");
            double testScore = Convert.ToDouble(ReadLine());

            if ( (gpa >= 3 && testScore >= 60) || (gpa <= 3 && testScore >= 80)) {
                WriteLine("Accept");
            } else {
                WriteLine("Reject");
            }
        }
    }
}
