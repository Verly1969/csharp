/*
 Find the mystery number
 */
using System;

const int life = 10;
int remainingLife = life;
int min = 0;
int max = 100;
int numberTimes = 1;

Random random = new Random();
int mystery = random.Next(min, max);

Console.WriteLine("#################################");
Console.WriteLine("#                               #");
Console.WriteLine("# Welcome to mystery number app #");
Console.WriteLine("#                               #");
Console.WriteLine("#################################");
Console.WriteLine();
Console.WriteLine($"Find the mystery number between {min} and {max}");
Console.WriteLine($"You have {life} lifes");
Console.WriteLine("Good Luck");
Console.WriteLine();

while(remainingLife > 0)
{
    Console.Write("What number did you choose ? ");
    int chosenNumber = Convert.ToInt16(Console.ReadLine());

    if(chosenNumber > mystery)
    {
        Console.WriteLine("Your number is too big");
        remainingLife--;
        numberTimes++;

        if(remainingLife == 1)
        {
            Console.WriteLine($"You have {remainingLife} life left");
        }
        else
        {
            Console.WriteLine($"You have {remainingLife} lifes left");
        }
        
    }
    else if(chosenNumber < mystery)
    {
        Console.WriteLine("Your number is too small");
        remainingLife--;
        numberTimes++;

        if (remainingLife == 1)
        {
            Console.WriteLine($"You have {remainingLife} life left");
        }
        else
        {
            Console.WriteLine($"You have {remainingLife} lifes left");
        }
    }
    else
    {
        Console.WriteLine("##############################");
        Console.WriteLine("#                            #");
        Console.WriteLine("# Congratulations, you won ! #");
        Console.WriteLine("#                            #");
        Console.WriteLine("##############################");
        Console.WriteLine($"You succeeded in {numberTimes} times");
        break;
    }
}