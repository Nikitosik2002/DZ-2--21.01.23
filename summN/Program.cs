System.Console.WriteLine("Введите число");
var number = Convert.ToInt64(Console.ReadLine());

int i = 1;
int summ = 0;
System.Console.WriteLine("Вывод cуммы всех чисел от 1 до " + number);

while (i <= number)
{
    summ += i; 
    i++;
}
System.Console.WriteLine(summ);