//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int QualytiNumber(int num)
{
    int  i ;
    for (i =0; num >0 ; i++)
    {
       num = num / 10;
    }
    return i;
}
int FindUnitNumber = DataEntry("Введите чило :");
int result = QualytiNumber(FindUnitNumber);
Console.WriteLine(result);