namespace OnStackReplacement;
// Thanks to Steven Toub
// https://www.codemag.com/Article/2211042/Highlighted-Performance-Wins-with-.NET-7

using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[MemoryDiagnoser(false)]
public class Benchmark
{
    private static readonly int s_year = DateTime.UtcNow.Year;

    [Benchmark]
    public int Compute()
    {
        int result = 0;
        for (int i = 0; i < 1_000_000; i++)
        {
            result += i;
            
            if (s_year == 2021)
            {
                result += i;
            }
        }
        
        return result;
    }
}