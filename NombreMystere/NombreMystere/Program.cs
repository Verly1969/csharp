/*
 Find the mystery number
 */

const int life = 10;
int remainingLife = life;
int min = 0;
int max = 100;
int numberTimes = 1;

Random random = new Random();
int mystery = random.Next(min, max);

void singularPlurial(int life)
{
    if (life == 1)
    {
        Console.WriteLine($"You have {life} life left");
    }
    else
    {
        Console.WriteLine($"You have {life} lifes left");
    }
}

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

        singularPlurial(remainingLife);
        
    }
    else if(chosenNumber < mystery)
    {
        Console.WriteLine("Your number is too small");
        remainingLife--;
        numberTimes++;

        singularPlurial(remainingLife);
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

if(remainingLife == 0)
{
    Console.WriteLine("##############################");
    Console.WriteLine("#                            #");
    Console.WriteLine("#      Sorry, you lose !     #");
    Console.WriteLine("#                            #");
    Console.WriteLine("##############################");
    Console.WriteLine("You have no more life");
    Console.WriteLine($"You have used up the {life} lives you had.");
}

Console.WriteLine("Thanks for playing");