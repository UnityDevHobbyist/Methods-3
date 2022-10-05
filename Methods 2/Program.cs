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

            // earn points
            score = score + 50;
            // get hurt
            health = health - 25;

            ShowHUD(); // usage

            // earn points
            score = score + 0;
            // get hurt
            health = health - 5;

            ShowHUD();

            Heal(5);

            ShowHUD();

            FullRestore();

            ShowHUD();

            Console.ReadKey(true);
        }
        static void ShowHUD() // declaration
        {
            // display HUD
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
        static void FullRestore()
        {
            health = 100;
        }
        static void Heal(int healamount)
        {
            health = health + healamount;
        }
    }
}