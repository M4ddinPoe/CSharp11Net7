using System;

int[] numbers = { 1, 2, 3 };
 
Console.WriteLine(numbers is [1, 2, 3]); // true
Console.WriteLine(numbers is [1, 2, 5]); // false
Console.WriteLine(numbers is [1, 2, 3, 4]); // false

Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // true

{
if (numbers is [var first, _])
{
 Console.WriteLine(first); // 1 
}
}

{
if (numbers is [var first, .. var rest])
{
 Console.WriteLine(first); // 1
 Console.WriteLine(rest); // [2, 3]
}
}
 
var myName = new[] { "Martin Pöpel" };
var myNameSplitted = new[] { "Martin", "Pöpel" };

var text = myName switch
{
    [] => "Name is empty",
    [var fullname] => $"My full name is {fullname}",
    [var firstName, var lastName] => $"My full name is {firstName} {lastName}",
};