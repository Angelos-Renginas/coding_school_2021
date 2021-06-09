using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_2_Exercises {
    class Program {
       

        static void Main(string[] args) {

            Console.WriteLine("Epsilon Net Coding School."); 
            Console.WriteLine("Session 2 Exercises! \n\n");

            DisplayMenu();

            Console.ReadLine();

        }

        static void DisplayMenu() {
            Console.WriteLine("Enter a number between 1 and 10 to go to each question, respectively.");
            Console.WriteLine("Or press 0 to exit.");

            bool zeroPressed = false;

            while (!zeroPressed) {

                Console.Write("\nEnter your number here: ");
                string questionNumber = Console.ReadLine();
                int checkIfNumberInt = -1;
            
                while (!int.TryParse(questionNumber, out checkIfNumberInt) ||Convert.ToInt32(questionNumber) > 10 || Convert.ToInt32(questionNumber) < 0   ) {
                    Console.Write("Wrong data input. Please enter a number between 1 and 10, or 0 to exit: ");
                    questionNumber = Console.ReadLine();
                }

                if (Convert.ToInt32(questionNumber) == 0) {
                    
                }

                switch (Convert.ToInt32(questionNumber)) {
                    case 1:
                        Console.WriteLine("\nYou have entered 1.");
                        Question1();
                        break;

                    case 2:
                        Console.WriteLine("\nYou have entered 2.");
                        Question2(checkIfNumberInt);
                        break;

                    case 3:
                        Console.WriteLine("\nYou have entered 3.");
                        Question3();
                        break;

                    case 4:
                        Console.WriteLine("\nYou have entered 4.");
                        Question4(checkIfNumberInt);
                        break;

                    case 5:
                        Console.WriteLine("\nYou have entered 5.");
                        Question5(checkIfNumberInt);
                        break;

                    case 6:
                        Console.WriteLine("\nYou have entered 6.");
                        Question6(checkIfNumberInt);
                        break;

                    case 7:
                        Console.WriteLine("\nYou have entered 7.");
                        Question7(checkIfNumberInt);
                        break;

                    case 8:
                        Console.WriteLine("\nYou have entered 8.");
                        Question8(checkIfNumberInt);
                        break;

                    case 9:
                        Console.WriteLine("\nYou have entered 9.");
                        Question9(checkIfNumberInt);
                        break;

                    case 10:
                        Console.WriteLine("\nYou have entered 10.");
                        Question10();
                        break;

                    case 0:
                        Console.WriteLine("EXIT.");
                        zeroPressed = true;
                        break;
                }
            }
        }

       

        static void Question1() {
            Console.WriteLine("Hello Angelos.");
        }

        static void Question2(int checkInt) {
            Console.WriteLine("Enter two numbers.");

            Console.Write("Enter your first number here: ");
            string firstNumber = Console.ReadLine();

            while (!int.TryParse(firstNumber, out checkInt) ) {
                Console.Write("Wrong data input. Please give a number: ");
                firstNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your second number here: ");
            string secondNumber = Console.ReadLine();

            while (!int.TryParse(secondNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                secondNumber = Console.ReadLine();
            }

            int sum = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
           
            Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);

            if (Convert.ToInt32(secondNumber) != 0) {

                decimal dividing = Convert.ToDecimal(firstNumber) / Convert.ToInt32(secondNumber);
                Console.WriteLine("The dividing of " + firstNumber + " and " + secondNumber + " is: " + dividing);
            }
            else {
                Console.WriteLine("Sorry. The dominator cannot be 0!");
            }
           
        }

        static void Question3() {
            Console.WriteLine("The result of \" -1 + 5 * 6 \" is: " + (-1 + (5 * 6)));
            Console.WriteLine("The result of \" 38 + 5 mod 7 \" is: " + (38 + (5 % 7)));
            Console.WriteLine("The result of \" 14 + (-3*6)/7 \" is: " + (14 + (-3 * 6)/ Convert.ToDecimal(7)));
            Console.WriteLine("The result of \" 2 + 13/6 * 6 + √7 \" is: " + (2 + (Convert.ToDouble(13) / 6) * 6 + Math.Sqrt(7)));
            Console.WriteLine("The result of \" (6^4+ 5^7)/(9 mod 4) \" is: " + (Math.Pow(6,4) + Math.Pow(5,7) / Convert.ToDouble(9 % 4)));

        }

        static void Question4(int checkInt) {
            Console.WriteLine("Enter three numbers.");

            Console.Write("Enter your first number here: ");
            string firstNumber = Console.ReadLine();

            while (!int.TryParse(firstNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                firstNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your second number here: ");
            string secondNumber = Console.ReadLine();

            while (!int.TryParse(secondNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                secondNumber = Console.ReadLine();
            }        

            Console.Write("\nEnter your third number here: ");
            string thirdNumber = Console.ReadLine();

            while (!int.TryParse(thirdNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                thirdNumber = Console.ReadLine();
            }

            int product = Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber) * Convert.ToInt32(thirdNumber);
            Console.WriteLine("The product of " + firstNumber + ", " + secondNumber + " and " + thirdNumber + " is: " + product);
        }

        static void Question5(int checkInt) {
            Console.WriteLine("Enter five numbers.");

            Console.Write("Enter your first number here: ");
            string firstNumber = Console.ReadLine();

            while (!int.TryParse(firstNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                firstNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your second number here: ");
            string secondNumber = Console.ReadLine();

            while (!int.TryParse(secondNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                secondNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your third number here: ");
            string thirdNumber = Console.ReadLine();

            while (!int.TryParse(thirdNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                thirdNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your fourth number here: ");
            string fourthNumber = Console.ReadLine();

            while (!int.TryParse(fourthNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                fourthNumber = Console.ReadLine();
            }

            Console.Write("\nEnter your fifth number here: ");
            string fifthNumber = Console.ReadLine();

            while (!int.TryParse(fifthNumber, out checkInt)) {
                Console.Write("Wrong data input. Please give a number: ");
                fifthNumber = Console.ReadLine();
            }

            double average = (Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber) + Convert.ToDouble(thirdNumber) + Convert.ToDouble(fourthNumber) + Convert.ToDouble(fifthNumber)) / 5;
            Console.WriteLine("the average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + " and " + fifthNumber + " is: " + average);
        }

        static void Question6(int checkInt) {

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            while (!int.TryParse(age, out checkInt) || Convert.ToInt32(age) < 0) {
                Console.Write("Wrong data input. Please give a positive number: ");
                age = Console.ReadLine();
            }

            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            while (!Regex.IsMatch(gender, @"^[a-zA-Z]+$")) {
                Console.Write("Your input is not a text. Please give a text: ");
                gender = Console.ReadLine();
            }

            Console.WriteLine("You are " + gender + " and look younger than " + age);

        }

        static void Question7(int checkInt) {
           
            Console.Write("Enter a number to represent seconds: ");
            string seconds = Console.ReadLine();

            while (!int.TryParse(seconds, out checkInt) || Convert.ToInt32(seconds) < 0) {
                Console.Write("Wrong data input. Please give a positive number: ");
                seconds = Console.ReadLine();
            }

            double minutes = Convert.ToDouble(seconds) /60;
            double hours = minutes / 60;
            double days = hours / 24;
            double years = days / 365;

            Console.WriteLine("You entered " + seconds + " second" + ((Convert.ToDouble(seconds) > 1) ? "s." : "." ));
            Console.WriteLine("This also is " + minutes + " minute" + ((Convert.ToDouble(minutes) > 1) ? "s, " : ", ") 
                + hours + " hour" + ((Convert.ToDouble(hours) > 1) ? "s, " : ", ")
                + days + " day" + ((Convert.ToDouble(days) > 1) ? "s, " : ", ") + "and " 
                + years + " year" + ((Convert.ToDouble(years) > 1) ? "s." : "."));


            
        }

        static void Question8(int checkInt) {
            Console.Write("Enter a number to represent seconds: ");
            string seconds = Console.ReadLine();

            while (!int.TryParse(seconds, out checkInt) || Convert.ToInt32(seconds) < 0) {
                Console.Write("Wrong data input. Please give a positive number: ");
                seconds = Console.ReadLine();
            }

            TimeSpan tSpan = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
            double totalYears = Convert.ToDouble(tSpan.Days) / 365;
            
            Console.WriteLine("You entered " + seconds + " second" + ((Convert.ToDouble(seconds) > 1) ? "s." : "."));
            Console.WriteLine("This also is " + tSpan.TotalMinutes + " minute" + ((Convert.ToDouble(tSpan.TotalMinutes) > 1) ? "s, " : ", ")
                  + tSpan.TotalHours + " hour" + ((Convert.ToDouble(tSpan.TotalHours) > 1) ? "s, " : ", ")
                  + tSpan.Days + " day" + ((Convert.ToDouble(tSpan.Days) > 1) ? "s, " : ", ") + "and "
                  + totalYears + " year" + ((totalYears > 1) ? "s." : "."));
        }

        static void Question9(int checkInt) {

            Console.Write("Give a temperature in Celsius: ");
            string celsius = Console.ReadLine();

            while (!int.TryParse(celsius, out checkInt) ) {
                Console.Write("Wrong data input. Please give a positive number: ");
                celsius = Console.ReadLine();
            }

            double kelvin = Convert.ToDouble(celsius) + 273.15;
            double fahrenheit = (Convert.ToDouble(celsius) * 9 / 5) + 32;

            Console.WriteLine("You entered " + celsius + " °C. This also is " + kelvin + " K, and " + fahrenheit + " °F.");

        }

        static void Question10() {
            Console.Write("Enter a string: ");
            string phrase = Console.ReadLine();

            while (!Regex.IsMatch(phrase, @"^[\,\. A-Za-z]+$")) {
                Console.Write("Your input is not a text. Please give a text: ");
                phrase = Console.ReadLine();
            }

            Console.WriteLine("The phrase you entered is: " + phrase + "." );
            phrase = phrase.Replace("a", "");
            Console.WriteLine("After removing \"a\", the prhase is: " + phrase);
        }
    }
}
