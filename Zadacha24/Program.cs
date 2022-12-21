//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36


Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int FindSum(int num)
{
    //пишем цикл от 1 до А
    int sum = 0;
    for ( int i = 1 ; i <= num ; i++ )
    {
       sum = sum + i;
    }
    return sum;
}
//Получили число
int number = DataEntry("Введите число A ");
int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А = " +result);