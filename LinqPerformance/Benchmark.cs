// Thanks to Nick Chapsas:
// https://www.youtube.com/watch?v=zCKwlgtVLnQ

namespace LinqPerformance;

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[MemoryDiagnoser(false)]
public class Benchmark
{
    private IEnumerable<int> _items;

    [GlobalSetup]
    public void Setup()
    {
        this._items = Enumerable.Range(1, 100).ToArray();
    }

    [Benchmark]
    public int Min() => this._items.Min();
    
    [Benchmark]
    public int Max() => this._items.Max();
    
    [Benchmark]
    public double Average() => this._items.Average();
    
    [Benchmark]
    public int Sum() => this._items.Sum();

    [Benchmark]
    public int MyMax()
    {
        var max = 0;

        foreach (int item in this._items)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }
}