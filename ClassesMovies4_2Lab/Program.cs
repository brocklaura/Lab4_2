using System;
using System.Collections.Generic;

namespace ClassesMovies4_2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Movies> movies = new List<Movies>();

            movies.Add(new Movies("The Lion King", "Animation"));
            movies.Add(new Movies("Prisoners", "Thriller"));
            movies.Add(new Movies("Step Brothers", "Comedy"));
            movies.Add(new Movies("Mean Girls", "Comedy"));
            movies.Add(new Movies("Aladdin", "Animation"));
            movies.Add(new Movies("Saw", "Thriller"));
            movies.Add(new Movies("Get Out", "Thriller"));
            movies.Add(new Movies("Big Head", "Comedy "));
            movies.Add(new Movies("Pocahontas", "Animation"));
            movies.Add(new Movies("Cinderella", "Animation"));
            do
            {
                Console.WriteLine("Hello Movie-Goer, please enter which of the three categories you'd like to see: ");
                Console.WriteLine("Animation, Comedy, Thriller");

                input = Console.ReadLine();

                foreach (Movies m in movies)
                {
                    if (m.Category.Contains(input))
                    {
                        Console.WriteLine(m);
                    }
                    
                }

                if (input != "Animation" && input != "Comedy" && input != "Thriller")
                {
                    Console.WriteLine("Invalid choice! Please enter an option listed above");
                }

            } while (UserContinue());
        }

        static bool UserContinue()
        {
            Console.WriteLine("Would you like to continue (y/n)?: ");
            string cont = Console.ReadLine();
            
            if (cont == "y" || cont == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
