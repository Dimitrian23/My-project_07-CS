// Задача_№71 Показать натуральные числа от N до 1, N задано

void Pool(int i, int N)
{
    System.Console.Write($"{N,4}");
       if(N>i)Pool(i,N-1);
}

// System.Console.WriteLine("Введите значения для переменной N:");
// int N=Convert.ToInt32(Console.ReadLine());

Pool(1,20);





