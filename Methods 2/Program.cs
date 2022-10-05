using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    internal class Program
    {
        // declarations
        static int score;
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods:");
            Console.WriteLine();

            // initializations
            score = 0;
            health = 100;

            ShowHUD(); // usage

            // earn points
            score = score + 500;
            // get hurt
            health = health - 10;

            ShowHUD(); // usage

            Console.ReadKey(true);
        }
        static void ShowHUD() // declaration
        {
            // display HUD
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
    }
}