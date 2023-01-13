// See https://aka.ms/new-console-template for more information
// dotnet publish -c Release -r osx.10.15-x64 -p:PublishAot=true
// PublishReadyToRun=true -p:PublishSingleFile=true --self-contained

using System;
using System.Diagnostics;

Console.WriteLine("Aot Compiled!");

static void PrintPrimeNumbers(int max)
{
    for (int number = 2; number <= max; number++)
    {
        bool isPrime = true;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.Write(number + " ");
        }
    }
}

int max = 1_000_000;

if (args.Length > 0)
{
    if (int.TryParse(args[0], out int parsed))
    {
        max = parsed;
    }
}

var stopwatch = new Stopwatch();
stopwatch.Start();

PrintPrimeNumbers(max);

stopwatch.Stop();

Console.WriteLine();
Console.WriteLine(stopwatch.Elapsed);