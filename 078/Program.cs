// Задача_№78 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.


int Fib(int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
}

System.Console.WriteLine("Введите значение для переменной N:");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вывожу первые {N} чисел Фибоначи:");
for(int j=0;j<N;j++)
System.Console.Write($"{Fib(j),4},");







