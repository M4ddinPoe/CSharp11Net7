using System;
using GenericsOnAttributes;

Console.WriteLine();

class ValidatorAttributePre : Attribute
{
    public ValidatorAttributePre(Type validatorType)
    {
        this.ValidatorType = validatorType;
    }

    public Type ValidatorType { get; }
}

class ValidatorAttribute<T> : Attribute
    where T : IValidator
{
    public ValidatorAttribute(Type validatorType)
    {
        this.ValidatorType = typeof(T);
    }

    public Type ValidatorType { get; }
}