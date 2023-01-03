var numbers = new[] { 1, 2, 3, 4, 5 };

var sum = AddAllNumbers(numbers);

Console.WriteLine(sum);


int AddAllNumbers(int[] values)
{
    int result = 0;

    foreach (var value in values)
    {
        result += value;
    }

    return result;
}
