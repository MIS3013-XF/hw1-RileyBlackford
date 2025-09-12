// HW1b Grade

// Your Name: Riley Blackford
// Did you seek help ? If yes, specify the helper or web link here: N/A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defined variables into doubles so they can be used as numbers//
            double hw;
            double participation;
            double Exam1;
            double Exam2;
            double Exam3;

            double grade;

            //Defined variables so the user can write their number for their input//
            string firstname;
            string lastname;
            string studentID;
            string homeworkst;
            string participationst;
            string Exam1st;
            string Exam2st;
            string Exam3st;

            //Defined variables so I can caluclate the overall weighted grade//
            System.Double h = .20;
            System.Double p = .15;
            System.Double E1 = .15;
            System.Double E2 = .25;
            System.Double E3 = .25;

            //This the output of what the user can see//
            Console.WriteLine("What is your first name?");
            //defining the first name so the computer can reference it again//
            firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            studentID = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homeworkst = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participation?");
            participationst = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for Exam1?");
            Exam1st = Console.ReadLine();
            Console.WriteLine("What is your overall percetange for the Exam2?");
            Exam2st = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the Exam3?");
            Exam3st = Console.ReadLine();
          

            //converted the strings into doubles//
            hw = Convert.ToDouble(homeworkst);
            participation = Convert.ToDouble(participationst);
            Exam1 = Convert.ToDouble(Exam1st);
            Exam2 = Convert.ToDouble(Exam2st);
            Exam3 = Convert.ToDouble(Exam3st);

            //Formula for grade//
            grade = ((hw*h) + (participation*p) + (Exam1*E1) + (Exam2*E2) + (Exam3*E3))/1;

            //Output name, student ID, and final grade//
            Console.WriteLine($"{firstname} {lastname} ({studentID}), your final grade is {grade}%");
            Console.ReadKey();
        }
    }
}
