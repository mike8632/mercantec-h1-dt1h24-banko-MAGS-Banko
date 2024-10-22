using System;
using System.Collections.Generic;
using System.Linq;

class BankoMike
{
    static void Main()
    {
        Console.WriteLine("Indtast dit nye banko nummer mellem 1 og 90:");
        int inputNumber;
        while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 1 || inputNumber > 90)
        {
            Console.WriteLine("Du skal skrive et tal imellem 1 og 90:");
        }

        int[,] banko1 = { { 1, 26, 30, 43, 72 }, { 27, 44, 54, 73, 86, }, { 18, 29, 49, 68, 75 } };
        int[,] banko2 = { { 20, 41, 61, 71, 82 }, { 8, 12, 23, 35, 77, }, { 15, 38, 56, 78, 89 } };
        int[,] banko3 = { { 7, 43, 50, 61, 76 }, { 8, 47, 51, 77, 83, }, { 16, 24, 39, 48, 90 } };
        int[,] banko4 = { { 2, 42, 60, 72, 80 }, { 5, 36, 56, 76, 83, }, { 19, 28, 45, 68, 77 } };
        int[,] banko5 = { { 2, 11, 30, 54, 80 }, { 25, 34, 45, 75, 84, }, { 18, 35, 49, 59, 62 } };
    }
}