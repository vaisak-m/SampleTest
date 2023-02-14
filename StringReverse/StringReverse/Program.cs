Console.Write("Enter a String : ");
string name = Console.ReadLine();
string reverseString = string.Empty;
for (int i = name.Length - 1; i >= 0; i--)
{
    reverseString += name[i];
}
Console.Write($"Reverse String is : {reverseString} ");
