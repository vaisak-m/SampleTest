Console.WriteLine("Enter first number");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int n2 = int.Parse(Console.ReadLine());

int temp = n2;
n2 = n1;
n1 = temp;

Console.WriteLine($"The swapped numbers are {n1} and {n2}");
// Comment. 