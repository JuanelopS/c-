﻿Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(101);
Console.Clear();
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
