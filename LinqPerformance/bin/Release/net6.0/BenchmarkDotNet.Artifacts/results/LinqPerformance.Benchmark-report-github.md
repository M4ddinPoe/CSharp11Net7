``` ini

BenchmarkDotNet=v0.13.2, OS=macOS 13.1 (22C65) [Darwin 22.2.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  .NET 6.0 : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  .NET 7.0 : .NET 7.0.1 (7.0.122.56804), Arm64 RyuJIT AdvSIMD


```
|  Method |      Job |  Runtime |      Mean |    Error |   StdDev | Allocated |
|-------- |--------- |--------- |----------:|---------:|---------:|----------:|
|     Min | .NET 6.0 | .NET 6.0 | 302.80 ns | 0.388 ns | 0.363 ns |      32 B |
|     Max | .NET 6.0 | .NET 6.0 | 270.24 ns | 3.701 ns | 3.462 ns |      32 B |
| Average | .NET 6.0 | .NET 6.0 | 297.65 ns | 1.349 ns | 1.196 ns |      32 B |
|     Sum | .NET 6.0 | .NET 6.0 | 266.70 ns | 0.801 ns | 0.710 ns |      32 B |
|   MyMax | .NET 6.0 | .NET 6.0 | 266.99 ns | 2.145 ns | 2.007 ns |      32 B |
|     Min | .NET 7.0 | .NET 7.0 |  14.28 ns | 0.122 ns | 0.095 ns |         - |
|     Max | .NET 7.0 | .NET 7.0 |  13.95 ns | 0.032 ns | 0.030 ns |         - |
| Average | .NET 7.0 | .NET 7.0 |  19.43 ns | 0.020 ns | 0.016 ns |         - |
|     Sum | .NET 7.0 | .NET 7.0 |  39.81 ns | 0.070 ns | 0.062 ns |         - |
|   MyMax | .NET 7.0 | .NET 7.0 | 270.87 ns | 5.351 ns | 5.006 ns |      32 B |
