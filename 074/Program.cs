// Задача_№74 Найти сумму цифр числа

 int SumNumbers(int N)
   {
        if (N == 0)
          return 0; 
           return (N % 10 + SumNumbers (N / 10)); 
    }
 
int N=123;
int sum = SumNumbers(N);
Console.WriteLine($"Сумма цифр в числе {N} = {sum}");
    













