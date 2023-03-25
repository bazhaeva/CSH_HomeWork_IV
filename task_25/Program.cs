double numberA = UserNumber("Введите число А: ");
double numberB = UserNumber("Введите степень В: ");

double result = MethodPower(numberA, numberB);

Console.WriteLine($"{numberA}^{numberB} -> {result}");

//==================================Методы===========================================

//---------------Возведение в степень
double MethodPower(double a, double b)
{
    double resultMethod = 1;
    if((b==0)||(a==0 && b==0))                    // *Для возведения в ненатуральную степень = 0
        return resultMethod;
    
    else if(b>0)
    {
        for(int i = 1; i<=b; i++)
            resultMethod = resultMethod*a;
             return resultMethod;
    }
    else if(b<0)                                  // *Для возведения в ненатуральную степень < 0
    {
        for(int i = 1; i<=b*(-1); i++)
        resultMethod = resultMethod*a;
        return 1/resultMethod; 
    }
    else return 0;                                 // **   
}                                                  
//** Возможно, есть варианты получше, но без последнего else ошибка:
// "не все пути возвращают значение", я думаю, что из-за того, что первое условие не простое, а составное

//----------------Ввод данных
static double UserNumber(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
