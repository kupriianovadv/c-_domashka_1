// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1>=number2)
// {
//     Console.WriteLine("Первое число БОЛЬШЕ второго.");
// }
// if(number1<=number2)
// {
//     Console.WriteLine("Первое число МЕНЬШЕ второго.");
// }
// else
// {
//    Console.WriteLine("Числа равны.");
// }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int numberMax = number1;

// if(number1>number2)
// {
//     numberMax = number1;
// }
// else
// {
//     numberMax = number2;
// }
// if(number3>numberMax)
// {
//     numberMax = number3;
// }
// Console.WriteLine("Масксимальное из введенных трех чисел:");
// Console.WriteLine(numberMax);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine("Введенное вами число четное");
// }
// else
// {
//     Console.WriteLine("Введенное вами число нечетное");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int numberStart = 1;

Console.Clear();
while(numberStart<=number)
{

    if(numberStart % 2 == 0)
    {
        Console.WriteLine(numberStart);
    }
numberStart++;
}