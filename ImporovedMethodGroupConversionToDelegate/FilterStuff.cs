namespace ImporovedMethodGroupConversionToDelegate;

public class FilterStuff
{
    private static readonly List<int> Ages = Enumerable.Range(0, 100).ToList();

    public int Sum()
    {
        // cached
        return Ages.Where(x => Filter(x)).Sum();
    }

    public int SumMethogGroup()
    {
        // not cached
        return Ages.Where(Filter).Sum();
    }

    static bool Filter(int age)
    {
        return age > 50;
    }
}