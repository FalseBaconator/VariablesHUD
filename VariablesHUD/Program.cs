using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesHUD
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string studio = "Fake Bacon Games";
            string title = "Not A Real Game";
            int score = 0;
            int enemyScore = 10;
            int scoreMultiplier = 1;
            int scoreMultiplyItem = 2;
            int HP = 100;
            int HPMax = 100;
            int enemyDMG = 10;
            int healthKit = 25;
            int lives = 3;
            int loseLife = 1;
            int oneUp = 1;
            float shield = 0.0f;
            float shieldDMGReduce = 2.0f;
            float shieldFull = 10.0f;

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield + " | Lives: " + lives);

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            score = score + enemyScore * scoreMultiplier;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player killed Enemy");

            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
