int length = UserNumber("Введите размер массива: ");
int[] userArray = new int[length];
FillArray(length);
PrintArray(userArray);


//=======================Методы============================
//-----------------------Заполнение массива
void FillArray(int length)
{
        for(int i = 0; i<length; i++)
    {
         userArray[i]= UserNumber($"Введите элемент массива {i}: ");
    }
}

//-----------------------Вывод массива
void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write($"]");
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
