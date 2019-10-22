using System;
using static System.Console;

namespace Lottery {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int num1 = random.Next(1, 4);
            int num2 = random.Next(1, 4);
            int num3 = random.Next(1, 4);

            WriteLine("The random numbers are: " + num1 + ", " + num2 + ", " + num3);

            WriteLine("Enter the first guessed number: ");
            int guessed1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter the second guessed number: ");
            int guessed2 = Convert.ToInt32(ReadLine());
            WriteLine("Enter the third guessed number: ");
            int guessed3 = Convert.ToInt32(ReadLine());

            int winnings = 0;

            // Guessed1 checks
            bool guess1Order = false;
            bool guessedCorrect1 = false;
            if (guessed1 == num1 || guessed1 == num2 || guessed1 == num3) {
                if (guessed1 == num1) {
                    WriteLine("GUESS1 ORDER");
                    guess1Order = true;
                } else {
                    WriteLine("GUESS1 CORRECT");
                    guessedCorrect1 = true;
                    winnings += 10;
                }
            }

            // Guessed2 checks
            bool guess2Order = false;
            bool guessedCorrect2 = false;
            if (guessed2 == num1 || guessed2 == num2 || guessed2 == num3) {
                if (guessed2 == num2) {
                    WriteLine("GUESS2 ORDER");
                    guess2Order = true;
                } else {
                    WriteLine("GUESS2 CORRECT");
                    guessedCorrect2 = true;
                    winnings += 10;
                }
            }

            // Guessed3 checks
            bool guess3Order = false;
            bool guessedCorrect3 = false;
            if (guessed3 == num1 || guessed3 == num2 || guessed3 == num3) {
                if (guessed3 == num3) {
                    WriteLine("GUESS3 ORDER");
                    guess3Order = true;
                } else {
                    WriteLine("GUESS3 CORRECT");
                    guessedCorrect2 = true;
                    winnings += 10;
                }
            }

            if (guess1Order && guess2Order && guess3Order) {
                winnings += 10000;
            } else if (guessedCorrect1 && guessedCorrect2 && guessedCorrect3) {
                winnings += 1000;
            }

            WriteLine("You won: " + winnings.ToString("C") + " | The random numbers were: " + num1 + ", " + num2 + ", " + num3);
        }
    }
}
