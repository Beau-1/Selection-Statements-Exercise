using System.ComponentModel;

//Exercise 1
//  Create a game where the player must guess the favorite number!

//Fork and Clone the repository - Selection Statement Exercise to your local computer.
//Instructions for forking and cloning a project can be found HERE.
    
//Create a program where the user must guess what your favorite number is:
//Inside the scope of your Main() method
//Declare and Initialize a favoriteNumber variable (your fav number)
//You could also get one from 1 - 1000 with this:
// var r = new Random();
//var favNumber = r.Next(1, 1000);
//Type Console.WriteLine(“Try to guess my favorite number”);
//Type var userInput = int.Parse(Console.ReadLine());
//Create an if-statement that if the guessed number is below the initial value, print out “too low”.
//Create an else-if statement that if the number is higher than the initial value, print out “too high”.
//Create an else statement that prints out “Nevermind”.





namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var r = new Random();
            var favoriteNumber = r.Next(1,100);
            Console.WriteLine("Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favoriteNumber) { Console.WriteLine("That's too low."); }

            else if (userInput > favoriteNumber) { Console.WriteLine("That's too high."); }

            else  { Console.WriteLine("Nevermind."); }


        }
    }
}
