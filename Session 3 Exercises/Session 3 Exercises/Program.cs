using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercises {

    public class Program {

        static void Main(string[] args) {

            Console.WriteLine("Epsilon Net Coding School.");
            Console.WriteLine("Session 3 Exercises! \n\n");


            //------------ Question 1 ----------
            Question1();

            //------------ Question 2 ----------
            Question2();

            //------------ Question 3 ----------
            Question3();

            //------------ Question 4 ----------
            Question4();

            //------------ Question 5 ----------
            Question5();

            //------------ Question 6 ----------
            Question6();


            Console.ReadLine();

        }

        public static void Question1() {

            Console.WriteLine("Question 1:");
            string phrase = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            Console.WriteLine("The phrase is: {0}", phrase);

            string[] wordsArray = phrase.Split(' ');

            string longestWord = "";
            foreach (string item in wordsArray) {
                if (item.Length > longestWord.Length)
                    longestWord = item;
            }


            longestWord = longestWord.ToUpper();
            Console.WriteLine("The longest word is {0}.\n", longestWord);

            Console.WriteLine("--".PadRight(50, '-'));
        }

        public static void Question2() {

            Console.WriteLine("\nQuestion 2:");

            Console.Write("Please enter a string: ");
            string input2 = Console.ReadLine();

            char[] charArray = input2.ToCharArray();
            string reversedString = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--) {
                reversedString += charArray[i];
            }

            Console.WriteLine("The reversed string is: {0} \n", reversedString);


            Console.WriteLine("--".PadRight(50, '-'));

        }

        public static void Question3() {
            Console.WriteLine("\nQuestion 3:");

            Console.Write("Please enter a positive number: ");
            int input3 = Convert.ToInt32(IsAPositiveNumber());

            Console.WriteLine("\nPress \'1\' if you want to compute the sum of 1,...,{0},", input3);
            Console.Write("or press \'2\' if you want to compute the product of 1,...,{0}: \n", input3);

            int chooseSumProduct = Convert.ToInt32(IsOneOrTwo());

            switch (chooseSumProduct) {
                case 1:
                    int sum = 0;
                    for (int i = 1; i <= input3; i++) {
                        sum += i;
                    }
                    Console.WriteLine("The sum of 0,....,{0} is: {1} \n", input3, sum);
                    break;

                case 2:
                    int product = 1;
                    for (int i = 1; i <= input3; i++) {
                        product *= i;
                    }
                    Console.WriteLine("The product of 0,....,{0} is: {1} \n", input3, product);
                    break;
            }

            Console.WriteLine("--".PadRight(50, '-'));

        }


        public static void Question4() {

            Console.WriteLine("\nQuestion 4:");

            Console.Write("Please enter a positive number: ");
            int input4 = Convert.ToInt32(IsAPositiveNumber());

            string primeNumbers = string.Empty;

            for (int i = 1; i <= input4; i++) {
                int timesDevided = 0;
                for (int j = i; j >= 1; j--) {
                    if (i % j == 0) {
                        timesDevided++;
                    }
                }
                if (timesDevided == 2) {
                    primeNumbers += i + " ";
                }
            }

            Console.WriteLine("All the prime numbers from 1 to {0} are:", input4);
            Console.WriteLine(primeNumbers + "\n");
            Console.WriteLine("--".PadRight(50, '-'));

        }

        public static void Question5() {

            Console.WriteLine("\nQuestion 5:");

            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };

            foreach (int array1Item in array1) {

                foreach (int array2Item in array2) {

                    Console.WriteLine("{0} * {1} = {2}", array1Item, array2Item, array1Item * array2Item);

                }

                Console.WriteLine();

            }

            Console.WriteLine("--".PadRight(50, '-'));

        }

        public static void Question6() {

            Console.WriteLine("\nQuestion 6:");

            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Array.Sort(array);

            Console.WriteLine("The array in ascending order is:");

            foreach (int number in array) {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("--".PadRight(50, '-'));

        }

        public static string IsAPositiveNumber() {
            int check = -1;
            string number = Console.ReadLine();

            while (!int.TryParse(number, out check) || Convert.ToInt32(number) < 1) {
                Console.Write("Wrong data input. Please give a positive number: ");
                number = Console.ReadLine();
            }

            return number;
        }


        public static string IsOneOrTwo() {
            int check = -1;
            string number = Console.ReadLine();

            while (!int.TryParse(number, out check) || Convert.ToInt32(number) < 1 || Convert.ToInt32(number) > 2) {
                Console.Write("Wrong data input. Please enter \'1\' for the sum, or \'2\' for the product: ");
                number = Console.ReadLine();
            }

            return number;
        }
    }
}
