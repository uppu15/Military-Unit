using System;

namespace Military_Unit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 7A - Military Unit");
            Console.WriteLine("Welcome to shooting range.  Please allow yourself to let some steam out.");
            try
            {
                ShootingRange.shootingRange();
            }
            catch(Exception)
            {
                Console.WriteLine("Check your input");                
            }
        }
    }
}
