namespace ExtendedNameof;

using System;

public class CustomAttribute : Attribute
{
    public CustomAttribute(string text)
    {
        this.Text = text;
    }

    public string Text { get; }
}