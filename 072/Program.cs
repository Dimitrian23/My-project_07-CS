// Задача_№72 Показать натуральные числа от M до N, N и M заданы

void Loop (int M,int N)
{
    System.Console.Write($"{M,4},");
    if(M<N)Loop(M+1,N);
}

Loop(12,22);
