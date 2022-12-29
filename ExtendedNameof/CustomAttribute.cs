namespace ExtendedNameof;

public class CustomAttribute : Attribute
{
    public CustomAttribute(string text)
    {
        this.Text = text;
    }

    public string Text { get; }
}