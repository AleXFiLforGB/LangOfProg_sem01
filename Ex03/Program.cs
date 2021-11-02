// Показать все числа на [2;128]
// которые делятся на 3 и 5 
// bool f = (88 % 22) == 0;
// Console.WriteLine(88 % 22 == 0);

// int start = 2;
// int end = 128;
// int current = start;
// int count = 1;

// while (current <= end)
// {
//     if ((current % 3 == 0) && (current % 5 == 0))
//     {
//         Console.WriteLine($"{count}) {current}");
//         count++;
//     }
//     current++;
// }


int candy = new Random().Next(20,39); //кол-во конфет
int max = 5; 
int player = 1;

while (candy > 0)
{
    Console.WriteLine($"Количество конфет: {candy}");
    Console.WriteLine($"Игрок {player} берет конфеты");
    Console.Write("Введите количество конфет, которые вы хотите отобрать ");
    int count = 0;
    while (!(count >=1 && count <= max))
    {
        count = int.Parse (Console.ReadLine());
        Console.WriteLine("Можно взять только от 1 до 5 конфет");
    }
    candy=candy-count;
    if (candy>0)
    {if (player==1){player=2;} else player=1;}
}
Console.WriteLine($"Победил игрок {player}");

