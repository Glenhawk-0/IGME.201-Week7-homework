namespace grade_calculator
{
    /*
     * Lennon Hare
     * IGME.201
     * Due: Oct/13/2024
     */
    internal class Program
    {
     //global methods
        static int checkGrade(int grade)
        {//start check grade
            if (grade >= 90)
            {
                if (grade == 100) { Console.WriteLine("WOW! A perfect score!"); }
                Console.WriteLine("This grade is an A!");
            }
            else if (grade >= 80) { Console.WriteLine("This grade is a B."); }
            else if (grade >= 70) { Console.WriteLine("This grade is a C."); }
            else if (grade >= 65) { Console.WriteLine("This grade is a D."); }
            else if (grade >= 0) { Console.WriteLine("This grade is a F."); }
            else { Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?"); }

            return (grade);
        }//end check grade

        static void Main(string[] args)
        {

            //varibles
            string myName = "Lennon";
            int[] grades = new int[10] { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = -200;
            //________________________________

            //greetings
            Console.WriteLine("welcome " + myName + ".\nhere are your grades.");

            //grades
            average = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("\nGrade " + (i + 1) + ": " + grades[i]);
                average += checkGrade(grades[i]);
            }//end for loop

            //average
            average = (average / grades.Length);
            Console.WriteLine("\nyour average grade is " + average);


            //end it off
            Console.WriteLine("\n-------------\n We have displayed all of " + myName + "'s grades");
            

        }//end static void main
    }//end internal class program
}// end grade_calculator

