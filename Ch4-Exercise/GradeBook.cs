//Angela Kuczynski
//Assignment 4.10
//GradeBook class with a constructor to initialize the course name and the name of the instructor
using System;

namespace GradeBookConsoleApplication
{
    class GradeBook
    {

        //auto-implemented property CourseName implicitly created an instance variable for this GradeBook's course name
        public string CourseName { get; set; } 

        //auto-implemented property InstructorName implicitly created an instance variable for this GradeBook's instructor name
        public string InstructorName { get; set; }

      //constructor initializes auto-implemented property CourseName with string supplied as argument
        public GradeBook(string course, string instructor)
        {
            CourseName = course; //set CourseName to course
            InstructorName = instructor;//set InstructorName to instructor
        }//end constructor
        
        //display a welcome message to the GradeBook user
      public void DisplayMessage()
        {
          // use auto-implemented property CourseName to get the name of the course that this GradeBook represents
            Console.WriteLine("Welcome to the grade book for {0}!", CourseName);
            Console.WriteLine("This course is presented by: {0}", InstructorName);
        }//end method DisplayMessage
    }//end class GradeBook
}//end namespace GradeBookConsoleApplication

