/*
 Find the mystery number
 */
using System;

int life = 5;
int min = 0;
int max = 100;
int mystery = 0;

Random random = new Random();
mystery = random.Next(min, max);

Console.WriteLine(mystery.ToString());
