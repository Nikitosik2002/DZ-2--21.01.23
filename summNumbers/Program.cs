System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int summ = 0;

while (number > 0)
{
    summ = summ + number % 10;
    number = number / 10;
}

System.Console.WriteLine(summ);