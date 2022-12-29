``` ini

BenchmarkDotNet=v0.13.3, OS=macOS 13.1 (22C65) [Darwin 22.2.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.1 (7.0.122.56804), Arm64 RyuJIT AdvSIMD


```
|  Method |     Mean |   Error |  StdDev |
|-------- |---------:|--------:|--------:|
| Compute | 312.9 μs | 0.49 μs | 0.46 μs |
