// 4. Найти максимальное из трех чисел 

Console.Write("Enter number 1 -> ");
int num1 =int.Parse(Console.ReadLine());
Console.Write("Enter number 2 -> ");
int num2 =int.Parse(Console.ReadLine());
Console.Write("Enter number 3 -> ");
int num3 =int.Parse(Console.ReadLine());

int max = num1;

if (num1 > max ) max = num1;
if (num2 > max ) max = num2;
if (num3 > max ) max = num3;

Console.Write("max= ");
Console.WriteLine(max);