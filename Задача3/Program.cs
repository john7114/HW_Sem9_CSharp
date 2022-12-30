// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//           Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 (?)
// m = 3, n = 2 -> A(m,n) = 29 (?)

//                  n+1,                  m=0
//      A(m, n) =   A(m-1, 1),            m>0, n=0                   
//                  A(m-1, A(m, n-1)),    m>0, n>0
// 1. Создать метод вычисляющий функцию Аккермана.
// 2. Запросить у пользователя натуральные положительные числа не больше 3.
// 3. Применить метод в пункте 1 и вывести результат на экран.

// 1.
int AkkermanFunction(int m, int n)
{
    int result = 0;

    if (m == 0)
    { 
        result = n + 1; 
    }
    if (m > 0 && n == 0) 
    {
        result = AkkermanFunction(m - 1, 1);
    }

    if (m > 0 && n > 0) 
    {
        result = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    return result;
}

// 2.
Console.WriteLine("Введите число, который будет параметром m в функции."); 
Console.WriteLine("Число должно быть положительным, натуральным и не больше 3 "); 
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, которое будет являться параметром n в функции Аккермана ");
int n = Convert.ToInt32(Console.ReadLine());

// 3.
Console.WriteLine(AkkermanFunction(m, n));