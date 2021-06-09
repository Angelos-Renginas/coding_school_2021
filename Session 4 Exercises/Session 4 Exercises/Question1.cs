using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercises {
    class Question1 {

        public void Execute() {
            Console.WriteLine("\nQuestion 1:");

            Console.Write("Please enter a number: ");
            int decimalNumber = Convert.ToInt32(IsANumber());
            string s = string.Empty;

            string binaryNumber = decimalToBinaryRec(decimalNumber, ref s);

            Console.WriteLine("Number {0} in decimal is {1} in binary.", decimalNumber, binaryNumber);

            Console.WriteLine();
            Console.WriteLine("--".PadRight(50, '-'));

        }


        public static string IsANumber() {
            int check = -1;
            string number = Console.ReadLine();

            while (!int.TryParse(number, out check)) {
                Console.Write("Wrong data input. Please give a number: ");
                number = Console.ReadLine();
            }

            return number;
        }

        private static string decimalToBinaryRec(int decimalNumber, ref string s) {


            if (decimalNumber == 0) {
                return s;
            }

            if (decimalNumber < 0) {
                s += "-";
                decimalNumber = -decimalNumber;
            }

            decimalToBinaryRec(decimalNumber / 2, ref s);
            s += decimalNumber % 2;

            return s;
        }

    }
}
