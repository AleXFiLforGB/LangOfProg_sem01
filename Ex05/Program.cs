// Почувствуй себя интерном
// 0. Вывести квадрат числа
// 1. По двум заданным числам проверять является ли первое квадратом второго
// 2. Даны два числа. Показать большее и меньшее число
// 3. По заданному номеру дня недели вывести его название
// 4. Найти максимальное из трех чисел
// 5. Написать программу вычисления значения функции y=f(a)
// 6. Выяснить является ли число чётным
// 7. Показать числа от -N до N
// 8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру


// Вот задача: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
//   Юнит-тесты
//   Легкость добавления других фигур
//   Вычисление площади фигуры без знания типа фигуры в compile-time
//   Проверку на то, является ли треугольник прямоугольным

//Общие методы для последующих задач
 int RandomN (int min, int max) // Генератор случайных чисел
     {return new Random().Next(min, max);}

void PrintNumber (int one)
    {Console.Clear();
     Console.WriteLine($"Дано {one}");}

//0.Вывести квадрат числа
// int Sqer (int a)
// {
//     return a*a;
// }
// int number =2;
// Sqer(number);

// Console.WriteLine(Sqer(number));

//1.По двум заданным числам проверять является ли первое квадратом второго
    // int a = new Random().Next(0,100);
    // int b = new Random().Next(0,50);
    
    // int RandomNumber (int a)
    // {a=new Random().Next(0,100);
    // return a;}

    // string A (int one, int two)
    //     {
    //         if (one==two*two)
    //         {return "Да";}
    //         else {return "Нет";}
    //         }
    // A(a,b);

// вариант 2 
    // int a = new Random().Next(0,100);
    // int b = new Random().Next(0,50);
    // bool A (int one, int two)
    //     {return one==two*two;}
          
    // A(a,b);
    
    // Console.WriteLine($"Является ли {a} квадратом {b} {A(a,b)}");

// 2. Даны два числа. Показать большее и меньшее число
    // int a = new Random().Next(0,100);
    // int b = new Random().Next(0,100);
    // Console.WriteLine($"Данны числа а={a}, b={b}");
    
    // if (a>b)
    // {Console.WriteLine($"Большим числом является а={a}, b={b}");}
    // else
    // {Console.WriteLine($"Большим числом является b={b}, a={a}");}

   
    
// 3. По заданному номеру дня недели вывести его название
        // int today = new Random().Next (0,8);
        // if (today == 1) {string monday = "Понедельник"; PrintResult(monday);} 
        // if (today == 2) {string thuesday = "Вторник"; PrintResult(thuesday);}
        // if (today == 3) {string wednesday = "Среда"; PrintResult(wednesday);}
        // if (today == 4) {string thursday = "Четверг"; PrintResult(thursday);}
        // if (today == 5) {string friday = "Пятница"; PrintResult(friday);}
        // if (today == 6) {string Saturday = "Суббота"; PrintResult(Saturday);}
        // if (today == 7) {string Sunday = "Воскресенье"; PrintResult(Sunday);}
        // void PrintResult(string Day)
        // {Console.WriteLine($"Today is {Day}, {today} день недели");}
// Второй вариант 

            // void DayOfWeek(int dayN)
            // {
            //     string[] array = { "Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресенье" };
            //     Console.WriteLine(array[dayN - 1]);
            // }

            // int daynum = new Random().Next(1, 8);
            // DayOfWeek(daynum);



// 4. Найти максимальное из трех чисел
    // int RandomNumber ()
    // {return new Random().Next(0,10);}

    // void Print (int n)
    // {Console.WriteLine(n);}

    // int a = RandomNumber(); 
    // Console.WriteLine($"a={a}");
    // int b = RandomNumber(); 
    // Console.WriteLine($"b={b}");
    // int c = RandomNumber(); 
    // Console.WriteLine($"c={c}");
    // int max = a;
    
    // if (max<b) {max=b;}

    // if (max<c) {max=c;}

    // Print (max);

// 5. Написать программу вычисления значения функции y=f(a) 

            // double Function(double a)
            // {
            //     double result = Math.Sin(a);
            //     return result;
            // }

            // double sin = Function(10);
            // Console.WriteLine(sin);

// 6. Выяснить является ли число чётным
    // int a = new Random().Next(0,100);
    // int b = new Random().Next(0,50);
    // bool CheckEvenNumber (int one)
    //     {return one % 2 == 0;}

    // int RandomNumber (int min, int max)
    //     {int a = new Random().Next(min,max);
    //         return a; }
    // void PrintNumber (int a)
    //     {Console.WriteLine($"Дано {a}");}

    // int one = RandomNumber (1,100);
    // PrintNumber(one);
    // CheckEvenNumber(one);

    // Console.WriteLine(CheckEvenNumber(one));
// 7. Показать числа от -N до N
        // int N = RandomNumber(1,100);
        // PrintNumber(N);
        // for (int i = -N; i <= N; i++)
        // {
        //     Console.Write($"{i} ");}
// 8. Показать четные числа от 1 до N
        // int N = RandomNumber(1,100);
        // PrintNumber(N);
        // for (int i =1; i<=N; i++)
        // {if (i % 2 ==0) Console.Write($"{i} ");}
// 9. Показать последнюю цифру трёхзначного числа
        // int N = RandomNumber(100,1000);
        // PrintNumber(N);
        // int LastNumber = N % 10;
        // PrintNumber(LastNumber);
// 10. Показать вторую цифру трёхзначного числа
        // int N = RandomNumber(100,1000);
        // PrintNumber(N);
        // int ScndNumber (int N)
        // {return N % 100 / 10;}
        // PrintNumber(ScndNumber(N));
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
        // int N = RandomNumber(10,99);
        // PrintNumber(N);
        // int one = N /10;
        // int two = N % 10;
        // if (one>two)
        // {Console.WriteLine($"Наибольшое число {one}");}
        // {Console.WriteLine($"Наибольшое число {two}");}

// 12. Удалить вторую цифру трёхзначного числа
        // int N = RandomNumber(100,1000);
        // PrintNumber(N);
        // int NewN = N / 100 * 10 + N % 10;
        // PrintNumber (NewN);
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
        //  int N = RandomNumber(10,99);
        // PrintNumber(N);
        // int delitel = 7;
        // bool Check (int a, int b)
        // {return a % b == 0;}
        // if (Check (N,delitel)==true)
        //     Console.WriteLine("Число кратно");
        // else Console.WriteLine(N % delitel);
// 14. Найти третью цифру числа или сообщить, что её нет
        // int N = RandomNumber(10,100000);
        // PrintNumber(N);
        
        // void EX_14 (int a)
        //     {
        //         if (a>99)
        //             {
        //                 while (a >= 1000)
        //                 {
        //                     a=a / 10;
        //                 }
        //                 a= a%10;
        //                 PrintNumber(a);
        //                 }
        //         else Console.WriteLine($"3 цифра числа {N} является {a}");

        //     }

        // EX_14(N);

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
        // int N = RandomN(161,164);
        // PrintNumber(N);

        // bool Ex_15 (int one)
        //     {return (one % 7 == 0) & (one % 23 == 0);}
        //      if (Ex_15(N) == true) Console.WriteLine($"Заданное число {N} кратно 7 и 23");
        //      else Console.WriteLine($"Заданное число {N} не кратно 7 и 23");

        // Ex_15(N);

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
        // int D = RandomN (1,8);
        // PrintNumber(D);

        // string [] Week = {"Понедельник", "Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};

        // void EX_16 (int one)
        // {   if (one > 5) 
        //     {Console.WriteLine($"Сегодня {Week[D-1]} можно и почилить");}
        //     else Console.WriteLine($"О_о Опять Работать! сегодня {Week[D-1]}");}

        // EX_16(D);

// 17. По двум заданным числам проверять является ли одно квадратом другого
        // int one = 4;
        // int two = RandomN (1,3);

        // bool CheckEven (int a, int b) {return a == b*b;}

        // if (CheckEven(one,two)==true) 
        //      {Console.WriteLine($"Число {one} является квадратом {two}");}
        // else {Console.WriteLine($"Число {one} не является квадратом {two}");}

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
        








// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива