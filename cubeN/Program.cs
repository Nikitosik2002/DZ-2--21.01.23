System.Console.WriteLine("Введите число");
var number = Convert.ToInt64(Console.ReadLine());

int i = 1;
System.Console.WriteLine("Вывод куба всех чисел от 1 до " + number);
while (i <= number)
{
    System.Console.WriteLine(i*i*i);
    i++;
}