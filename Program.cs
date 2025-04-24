// MON, Apr 21 2025
// Assignment 3.1.1 Write a method that returns string of even numbers

using System;
using System.Text;

class Program
{

    static void Main()
    {

        StringBuilder myStringBuilder = new StringBuilder();

        for (int i = 2; i < 100; i = i + 2)
        {
            myStringBuilder.Append(i);

            if (i < 98)
            {
                myStringBuilder.Append(".");
            }
        }

        Console.WriteLine(myStringBuilder.ToString());
    }
}