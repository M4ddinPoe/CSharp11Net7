using System;

ReadOnlySpan<char> text = "Martin";

if (text is "Martin")
{
    Console.WriteLine("Its Martin!");
}

if (text is ['M', ..])
{
    Console.WriteLine("It starts with M!");
}
