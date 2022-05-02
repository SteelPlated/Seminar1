// 8. Показать все четные числа от 1 до N.

Console.Write("Enter N -> ");
int N =int.Parse(Console.ReadLine());
int i=2;
while ( i<= N)
    {
        Console.Write(i + " ");
        i=i+2;
    }
