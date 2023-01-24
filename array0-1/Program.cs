int[] array = new int[8];

var rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 2);
}

System.Console.WriteLine("Введите число (0 или 1) которое хотите найти в массиве");
int seek = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Вывод массива на экран");

int count = 0;

foreach (int j in array)
{
    System.Console.WriteLine(j);

    if(j == seek)
    {
        count++;
    }
}

System.Console.WriteLine("В данном масиве цифра " + seek + " повторяется " + count + " раз");

