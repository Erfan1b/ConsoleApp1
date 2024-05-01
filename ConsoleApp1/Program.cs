int a = int.Parse(Console.ReadLine());
if((a%2)==0)
{
    Console.WriteLine($"your input is an even number");
    global::System.Console.WriteLine(a);
}
else if((a%2)==1)
{
    Console.WriteLine($"your input is an odd number");
    global::System.Console.WriteLine(a);
}
else
{
    global::System.Console.WriteLine("Error code 101");
}
Console.ReadKey();