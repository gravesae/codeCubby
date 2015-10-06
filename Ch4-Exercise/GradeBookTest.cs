//Angela Kuczynski
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApplication
{
    class GradeBookTest
    {
        //Main Method begins program execution
        public static void Main(string[] args)
        {
            //prompt for and read course name
            Console.WriteLine( "Please enter the course name: ");
            string course = Console.ReadLine();//set CourseName
            
            //prompt for and read instructor name
            Console.WriteLine("Please enter the instructor name: ");
            string instructor = Console.ReadLine(); //set InstructorName


            //create Gradebook object and assign to myGradeBook 
            GradeBook myGradeBook = new GradeBook(course,instructor);

            //display welcome message after specifying course name
            myGradeBook.DisplayMessage();

        }//end main
    }//end class GradeBookTest
}//end namespace GradeBookConsoleApplication
