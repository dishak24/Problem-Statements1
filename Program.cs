using System;

namespace ProblemStatement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Problem Statement Series of C#.");

            MovieTikit movieTikit = new MovieTikit();
            movieTikit.CalculatePrize();
        }
    }
}
