Console.Clear();

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine());

int ostatok =(number/10)%10;

if ((number > 999) || (number < 100))

    Console.WriteLine("Введенное число не подходит под условие задачи");
    
else

    Console.WriteLine($"вторая цифра от числа {number} это {ostatok}");