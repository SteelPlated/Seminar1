// 2. Найти максимальное из двух чисел 

Console.Write("Enter number 1 -> ");
int num1 =int.Parse(Console.ReadLine());
Console.Write("Enter number 2 -> ");
int num2 =int.Parse(Console.ReadLine());

int max=num1; 
int min=num2;

if (num1 > num2) {
    max = num1; 
    min=num2;
    Console.WriteLine($"max= {max}");
    Console.WriteLine($"min= {min}");
    }
else
    if (num2 > num1) {
        max = num2; 
        min=num1;
        Console.WriteLine($"max= {max}");
        Console.WriteLine($"min= {min}");
    }
    else 
    Console.WriteLine("Числа равны");
