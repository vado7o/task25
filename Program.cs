// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("программа, принимающая два числа А и В и возводящая число А в натуральную степень В");

int numA = 0;
int numB = 0;
int sum = 0;

// ввод числа А
while(true)
{
    Console.WriteLine("Введите целое число А:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        numA = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}
// ввод числа В
while(true)
{
    Console.WriteLine("Введите целое НАТУРАЛЬНОЕ число В:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        if(number < 0) 
        {
            Console.WriteLine("Вами введено НЕ натуральное число (отрицательное)!");
            continue;
        }
        else numB = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

Console.WriteLine("число " + numA + " в степени " + numB + " = " + Calculate(numA, numB));


int Calculate(int a, int b)
{
    if (a == 0 && b == 0)
    {
        sum = 1;
    }
    else
    {
        sum = a;
        for(int i = 1; i < b; i++)
        {
            sum = sum * a;
        }
    }
    return sum;
}
