System.Console.WriteLine("Введите число");
var number = Convert.ToInt64(Console.ReadLine());

int count = 1;
int i = 1;

while (i <= number)
{
    count = count * i;
    i++;
}
System.Console.WriteLine(count);