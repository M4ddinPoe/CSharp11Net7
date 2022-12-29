``` ini

BenchmarkDotNet=v0.13.3, OS=macOS 13.1 (22C65) [Darwin 22.2.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.101
  [Host]   : .NET 7.0.1 (7.0.122.56804), Arm64 RyuJIT AdvSIMD
  .NET 6.0 : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  .NET 7.0 : .NET 7.0.1 (7.0.122.56804), Arm64 RyuJIT AdvSIMD


```
|  Method |      Job |  Runtime |     Mean |   Error |  StdDev | Allocated |
|-------- |--------- |--------- |---------:|--------:|--------:|----------:|
| Compute | .NET 6.0 | .NET 6.0 | 630.3 μs | 2.79 μs | 2.61 μs |       1 B |
| Compute | .NET 7.0 | .NET 7.0 | 316.0 μs | 0.77 μs | 0.64 μs |         - |
