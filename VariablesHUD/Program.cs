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
            float shieldDMGReduce = 3.0f;
            float shieldFull = 10.0f;

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            score = score + (enemyScore * scoreMultiplier);
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player killed Enemy");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            shield = shieldFull;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player found Shield!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            shield = shield - (enemyDMG / shieldDMGReduce);
            if (shield <= 0)
            {
                shield = 0;
            }
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player blocked Enemy attack with Shield!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            shield = shield - (enemyDMG / shieldDMGReduce);
            if (shield <= 0)
            {
                shield = 0;
            }
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player blocked Enemy attack with Shield!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            score = score + (enemyScore * scoreMultiplier);
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player Killed Enemy");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            shield = shield - (enemyDMG / shieldDMGReduce);
            if (shield <= 0)
            {
                shield = 0;
            }
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player blocked Enemy attack with Shield!");
            Console.WriteLine("Shield Broke!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            score = score + (enemyScore * scoreMultiplier);
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player killed Enemy!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP + healthKit;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player finds Health Kit");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            scoreMultiplier = scoreMultiplyItem;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player runs from Enemy and finds a Score Multiplier!");
            Console.WriteLine("From now on score gain will be doubled!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            HP = HP - enemyDMG;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Enemy attacked Player!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            score = score + (enemyScore * scoreMultiplier);
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player killed Enemy!");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(title + " by " + studio);
            Console.WriteLine();
            lives = lives + oneUp;
            Console.WriteLine("Score: " + score + " | HP: " + HP + " | Shield: " + shield.ToString("0.00") + " | Lives: " + lives);
            Console.WriteLine();
            Console.WriteLine("Player found a 1UP!");

            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
