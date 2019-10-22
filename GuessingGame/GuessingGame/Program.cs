using System;
using static System.Console;

namespace GuessingGame {
    class Program {
        static void Main(string[] args) {
            Random randomNumberGen = new Random();
            int randomNumber = randomNumberGen.Next(1, 11);

            WriteLine("Guess the random number: ");
            while (true) {
                int guessed = Convert.ToInt32(ReadLine());
                if (guessed == randomNumber) {
                    WriteLine("Correct");
                    break;
                } else if (guessed > randomNumber) {
                    WriteLine("Too high");
                    WriteLine("Guess the random number: ");
                } else if (guessed < randomNumber) {
                    WriteLine("Too low");
                    WriteLine("Guess the random number: ");
                }
            }
        }
    }
}
