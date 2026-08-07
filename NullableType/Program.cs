int? number = null;
number = 234; //comment this line to print out the result from the else block
if (number.HasValue)
{
    Console.WriteLine(number.Value);
}
else
{
    Console.WriteLine("number is null");
}