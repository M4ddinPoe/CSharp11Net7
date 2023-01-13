using System;
using System.Numerics;

var numbers = new[] { 1, 2, 3, 4, 5, 6.4 };

var sum = AddAllNumbers(numbers);

Console.WriteLine(sum);

T AddAllNumbers<T>(T[] values)
    where T : INumber<T>
{
    T result = T.Zero;

    foreach (var value in values)
    {
        result += value;
    }

    return result;
}
