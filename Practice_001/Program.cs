//  Нахождение суммы кратных и некратных чисел

int result1 = 0;
int result2 = 0;
int crat = 2;
while (true)
{
    Console.WriteLine("Введите число или команду");
    string res = Console.ReadLine();
    if(res == "end")
    {
        break;
    }
    else if (res == "num")
    {
        Console.WriteLine("Введите кратное число");
        crat = Convert.ToInt32(Console.ReadLine());
        result1 = 0;
        result2 = 0;
    }
    else
    {
        int number = Convert.ToInt32(res);
        if (number % crat == 0)
        {
            result1 += number;
        }
        else
        {
            result2 += number;
        }
    }
}
Console.WriteLine(result1.ToString() + " Сумма кратных чисел");
Console.WriteLine(result2.ToString() + " Сумма не кратных чисел");
