// Задача_№70 Показать натуральные числа от 1 до N, N задано

void Loop (int i,int N)
{
    System.Console.Write($"{i,4},");
    if(i<N)Loop(i+1,N);
}

System.Console.WriteLine("Введите значение для переменной N:");
int N=Convert.ToInt32(Console.ReadLine());

Loop(1,N);









