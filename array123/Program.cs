int[] array = new int[123];

var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 20);
    }

System.Console.WriteLine("Вывод массива на экран");
System.Console.WriteLine("--------");

    foreach (int j in array)
    {
        System.Console.WriteLine(j);
    }

int count = 0;

    for (int i = 10; i <= 99; i++)
    {
        count++;
    }

System.Console.WriteLine("количество элементов из отрезка [10,99] = " + count);
System.Console.WriteLine("--------");

int summ = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }

System.Console.WriteLine("Сумма чисел состоящих на нечетной позиции массива = " + summ);
System.Console.WriteLine("--------");

int composition = 1;
int range = array.Length;

    for (int i = 0; i < array.Length / 2; i++)
    {
        if (i < array.Length / 2)
        {
            composition = array[i] * array[array.Length - (1+i)];
            System.Console.WriteLine("произведение пары = " + composition);
            System.Console.WriteLine("--------");
        }  
    }

    if (range % 2 != 0)
    {
        System.Console.WriteLine("У центрального числа нет пары");
        System.Console.WriteLine("--------");
        int center = array[array.Length / 2 ];
        System.Console.WriteLine("Центральное число = " + center);
        System.Console.WriteLine("--------");
    }

int max = array[0];
int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }

int difference = max - min;
System.Console.WriteLine("Разница между максимальным и минимальным числом = " + difference);
    