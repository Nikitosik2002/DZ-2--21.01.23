
var rnd = new Random();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}

System.Console.WriteLine("Вывод массива на экран");

foreach (int j in array)
{
    System.Console.WriteLine(j);
}

int evenCount = 0;
int unevenCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        unevenCount++;
    }
}

System.Console.WriteLine("Количество четных чисел = " + evenCount);
System.Console.WriteLine("Количество нечетных чисел = " + unevenCount);