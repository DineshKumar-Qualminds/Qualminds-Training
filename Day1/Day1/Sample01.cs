﻿/*
*Sample01.cs
*This. program is used to print Hello World in Console Window
*/

using System;

namespace Day1
{
    /// <summary>
    /// Sample class prints Hello World when it gets executes
    /// </summary>
    class Sample01
    {
        /// <summary>
        /// The entry point for the applications.
        /// </summary>
        /// <param name="args">A list of command line arguments</param> 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Console.ReadKey();   

        }
    }
}

/* 
To Compile the program using Visual Studio Command Prompt
> CSC <FileName>.cs

To execute the program
> <FileName>

*/