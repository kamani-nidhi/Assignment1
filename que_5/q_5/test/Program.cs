using test;

generic_class<int> intCalculator = new generic_class<int>();

Console.WriteLine($"5 + 3 = {intCalculator.Add(5, 3)}");
Console.WriteLine($"5 - 3 = {intCalculator.sub(45, 3)}");
Console.WriteLine($"5 * 3 = {intCalculator.mul(65, 3)}");
Console.WriteLine($"5 / 3 = {intCalculator.div(5, 31)}");

generic_class<decimal> decimalCalculator = new generic_class<decimal>();
Console.WriteLine($"10.5m + 2.3m = {decimalCalculator.Add(10.5m, 2.3m)}");
Console.WriteLine($"15.0m / 3.0m = {decimalCalculator.div(15.0m, 3.0m)}");


generic_2d<int> int2d = new generic_2d<int>();


int[,] a = new int[3,3];
int[,] b = new int[3, 3];

Console.WriteLine("Enter 2d value 1");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Enter a[" + i + "][" + j + "]");
        int input = Convert.ToInt32(Console.ReadLine());
        a[i, j] = input;
    }

}

Console.WriteLine("Enter 2d value 2");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Enter a[" + i + "][" + j + "]");
        int input = Convert.ToInt32(Console.ReadLine());
        b[i, j] = input;
    }

}
int2d.Add(a, b);