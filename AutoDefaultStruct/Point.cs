namespace AutoDefaultStruct;

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        
        // This is not allowed in Pre-.NET 7
        // Y = y;
    }
}