﻿using System;

namespace Ships
{
    internal class Program
    {
        private static readonly int[,] ships = new int[10, 10]
        {
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
        };

        private static void Main(string[] args)
        {
            var count = 0;
            var shipLength = 0;
            for (var row = 0; row < 10; row++)
            {
                for (var col = 0; col < 10; col++)
                {
                    if (ships[row, col] == 1)
                    {
                        count++;
                     ships[row, col] = 0;
                        // Check to the right 
                        for (var i = col + 1; i < 10 && ships[row, i] == 1; i++)
                        {
                            ships[row, i] = 0;
                        }
                        // Check below 
                        for (var j = row + 1; j < 10 && ships[j, col] == 1; j++)
                        {
                            ships[j, col] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(count);
                    Console.ReadLine();
                }
            }
        }
   
