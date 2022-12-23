//Решение в группах задач:
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    
    int sum = 1;
    for ( int i = 1 ; i <= num ; i++ )
    {
       sum = sum * i;
    }
    return sum;
}
//Получили число
int number = DataEntry("Введите число A ");
int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А = " +result);