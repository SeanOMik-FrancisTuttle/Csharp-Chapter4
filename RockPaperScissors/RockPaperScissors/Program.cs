using System;
using static System.Console;

namespace RockPaperScissors {
    class Program {
        public static string chooseComputer() {
            Random randomChoiceGen = new Random();
            int randomChoiceInt = randomChoiceGen.Next(1, 4);
            string randomChoice = "";
            switch (randomChoiceInt) {
                case 1:
                    randomChoice = "r";
                    break;
                case 2:
                    randomChoice = "p";
                    break;
                case 3:
                    randomChoice = "s";
                    break;
            }
            return randomChoice;
        }
        static void Main(string[] args) {
            WriteLine("Computer has chosen, enter r for rock, p for paper, and s for scissors. If you would like to stop, type exit");

            while (true) {
                string randomChoice = chooseComputer();
                string guess = ReadLine();

                if (guess.Equals(randomChoice)) {
                    WriteLine("Tie!");
                } else if (guess.Equals("r") && randomChoice.Equals("s")) { // rock vs scissors
                    WriteLine("You win, computer chose scissors!");
                } else if (guess.Equals("r") && randomChoice.Equals("p")) { // rock vs paper
                    WriteLine("You lose, computer chose paper!");
                } else if (guess.Equals("s") && randomChoice.Equals("r")) { // scissors vs rock
                    WriteLine("You lose, computer chose rock!");
                } else if (guess.Equals("s") && randomChoice.Equals("p")) { // scissors vs paper
                    WriteLine("You win, computer chose paper!");
                } else if (guess.Equals("p") && randomChoice.Equals("s")) { // paper vs scissors
                    WriteLine("You lose, computer chose scissors!");
                } else if (guess.Equals("p") && randomChoice.Equals("r")) { // paper vs rock
                    WriteLine("You win, computer chose rock!");
                } else if (guess.Equals("exit")) break;
            }
        }
    }
}
