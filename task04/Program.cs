// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до number
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Enter an integer largr than 0: ");
int a = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 1;
    }
}

else
{
    Console.WriteLine("Input error!");
}
