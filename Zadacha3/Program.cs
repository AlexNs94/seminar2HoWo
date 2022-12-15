Console.Clear();

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");

int day = int.Parse(Console.ReadLine());
 
if (day > 5 && day < 8)

    Console.Write("выходной");

else
     if (day > 0 && day < 6)
    
        Console.Write("рабочий");

    else
        Console.Write("некорректное число");