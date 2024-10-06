namespace grade_calculator
{
    /*
     * Lennon Hare
     * IGME.201
     * Due: Oct/13/2024
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //start copy

            //varibles
            string myName = "Lennon";
            int[] grades = new int[10] { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = -200;
            //methods
            static int checkGrade(int grade)
            {
                if (grade >= 90)
                {
                    if (grade == 100) { Console.WriteLine("WOW! A perfect score!"); }
                    Console.WriteLine("This grade is an A!");
                }
                else if (grade >= 80) { Console.WriteLine("This grade is a B."); }
                else if (grade >= 70) { Console.WriteLine("This grade is a C."); }
                else if (grade >= 65) { Console.WriteLine("This grade is a D."); }
                else if (grade >= 0 ) { Console.WriteLine("This grade is a F."); }
                else { Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?"); }

                return (grade);


            }//end checkGrade method
                //________________________________

                //greetings
                Console.WriteLine("welcome " + myName + ".\nhere are your grades.");

            //grades
            average = 0;
            for (int i = 0; i < grades.Length; i++) 
            {
                Console.WriteLine("Grade " + (i+1) +": " + grades[i]);
                average += checkGrade(grades[i]);
                

            }//end for loop

            //average
            average = average / grades.Length;
           Console.WriteLine("your average grade is " + average )


            //end it off

           
            //end copy

        }//end static void main
    }//end internal class program
}// end grade_calculator

