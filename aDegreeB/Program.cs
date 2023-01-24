System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;

System.Console.WriteLine("Введите степень");
int degree = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < degree)
{
    count = count * number;
    i++;
}

System.Console.WriteLine(count);
