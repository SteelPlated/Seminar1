// 2. Найти максимальное из двух чисел 

Console.Write("Enter number 1 -> ");
int num1 =int.Parse(Console.ReadLine());
Console.Write("Enter number 2 -> ");
int num2 =int.Parse(Console.ReadLine());

int max = num1; 
int min=num2;

if (num1 > max ) max = num1; min=num2;
if (num2 > max ) max = num2; min=num2;


Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);