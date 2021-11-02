// при построении вопроса следуют придерживаться следующего алгоритма 
// 1. Какая задача - описать выполняемую задачу 
// 2. Я делаю то и то - описание действий 
// 3. Какие данные используются 
// 4. Что вы ожидаете - описание желаемого результата 
// 5. Что получается в итоге 
// Ошибки 
// почему? как исправить? 

// типы данных int double string bool 

// Переменная 
// if -else 
// while 

// поменять 2 переменные местами 

// int a = 1; 
// int b = 3;

// Console.Write(" a = ");
// Console.Write(a);
// Console.Write(" b = ");
// Console.WriteLine(b);

// int temp = a;
// a = b;
// b = temp;

// Console.Write(" a = ");
// Console.Write(a);
// Console.Write(" b = ");
// Console.WriteLine(b);

// ==

// Console.WriteLine(" a = " + a + " b = " + b);

// Console.WriteLine("a = {0} b = {1}", a, b);


// Console.WriteLine($"a = {a} b = {b}");


// Переменная 
// Тип данных 
// Имя
// Значение

// int a = new Random().Next(1, 100); 
// int b = new Random().Next(1,100);
// Console.WriteLine($"a = {a} b = {b}");

// if (a > b)
// {
//     Console.WriteLine(a);
// }

// else 
// {
//     Console.WriteLine(b);
// }

int current = 1; 
 while (current <= 10)
 {
     Console.WriteLine($"{current} {current*current}");
     current++;
 }
