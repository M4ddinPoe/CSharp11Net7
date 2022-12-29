``` ini

BenchmarkDotNet=v0.13.3, OS=macOS 13.1 (22C65) [Darwin 22.2.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.12 (6.0.1222.56807), Arm64 RyuJIT AdvSIMD


```
|  Method |     Mean |   Error |  StdDev |
|-------- |---------:|--------:|--------:|
| Compute | 949.2 μs | 4.64 μs | 4.11 μs |
