

using RegexPattern;

Pattern patterns = new Pattern();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validateString("tomsh21@gmail.com"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();
