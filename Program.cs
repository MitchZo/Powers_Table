using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate a table which displays the numbers 1-n, the squares of each, and the cubes of each.
            bool again = true;
            while (again)
            {
            //Ask the user for an integer
            string userInput = GetUserInput($"Please enter an integer");

            //Verify the user's integer is, in fact, an integer
            int num = VerifyInteger(userInput);

            //display the headers for the table
            CreateTableHeaders();

            //populate table with numbers from 1 to n, and their respective squares/cubes
            PopulateTable(num);

            //Ask the user if they would like to run it again
            again = RunAgain(again);
            }

        }
        public static string GetUserInput(string message)
        {
            //write the message passed in and print it
            Console.WriteLine(message);
            string userInput = Console.ReadLine();

            return userInput;
        }
        public static int VerifyInteger(string userInput)
        {
            //try to convert the string to an int and set the result to the validitiy variable
            bool isValid = int.TryParse(userInput, out int num);

            //loop to either output the int or ask the user for input again and verify it
            if (isValid)
            {
                return num;
            }
            else
            {
                userInput = GetUserInput("Not an integer. Try again.");
                return VerifyInteger(userInput);
            }
        }
        public static void CreateTableHeaders()
        {
            //prints the headers for the table
            Console.WriteLine($"Number\tsquare\tcube\n======\t======\t=======");
        }
        public static void PopulateTable(int num)
        {
            //print the numbers, squares, and cubes for every number 1-n
            for (int i = 1; i <= num; i++)
            {
                //call the method to square the number, passing it the current number
                int square = SquareNumber(i);

                //call the method to cube the number, passing it the current number
                int cube = CubeNumber(i);
                
                //print the results for each number up to and including the user's selection
            Console.WriteLine($"{i}\t{square}\t{cube}");
            }
        }
        public static int SquareNumber(int num)
        {
            num *= num;
            return num;
        }
        public static int CubeNumber(int num)
        {
            num *= num;
            num *= num;
            return num;
        }
        public static bool RunAgain(bool again)
        {
            string validInput = GetValidUserInput();
            
            if(validInput == "y" || validInput == "yes"){
                return true;
            }

            return false;
        }

        public static string GetValidUserInput()
        {
            string userResponse = GetUserInput("Would you like to run again?")
            bool validResponse = AssessUserInput(userResponse);

            while(!validResponse){
                userResponse = GetUserInput("Would you like to run again?")
                validResponse = AssessUserInput(userResponse);
            }
            
            return userResponse.ToLower();
        }
        
        public static bool AssessUserInput(string input){
            return (userResponse.ToLower() == "y" || 
                    userResponse.ToLower() == "yes" ||
                    userResponse.ToLower() == "n" || 
                    userResponse.ToLower() == "no");
        }
    }
}
