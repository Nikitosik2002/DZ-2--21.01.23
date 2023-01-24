System.Console.WriteLine("Введите число");
var number = Convert.ToInt64(Console.ReadLine());

int i = 1;
int last;
int cube;

System.Console.WriteLine("Вывод куба всех четных чисел от 1 до " + number);
while (i <= number)
{
    cube = i * i * i;
    last = cube % 10;

    if (last % 2 == 0)
    {
        System.Console.WriteLine(cube);
    }
    i++;
}