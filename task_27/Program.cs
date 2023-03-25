int numberA = UserNumber("Введите число: ");

int result = Method1(numberA);

Console.WriteLine($"{numberA} -> {result}");

//=============================Методы==================

//------------------------Суммирование цифр
int Method1(int number)
{
    if(number<0) 
        number=number*(-1);

    int sum = number%10;

    while(number!=0)
    {
        number=number/10;
        sum = sum+number%10;
    }
return sum;
}



//----------------Ввод данных
static int UserNumber(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
