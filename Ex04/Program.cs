int Candy = new Random().Next(20,30);
int max = 5;
string win = "";
while (Candy>0)
{
    Console.WriteLine($"Конфет осталось {Candy}, сколько конфет вы возьмете?"); //игрок делает ход
    int count = int.Parse (Console.ReadLine());
    Candy -= count; //candy = candy - count 

    if (Candy <=0)
    {win = "user";}
    if (Candy > 0)
    {
        int ii = Candy % (max + 1);
        if (ii == 0)
        {
            ii = new Random ().Next(1, max + 1);
        }
        Candy -= ii;
        Console.WriteLine($"Компьютер взял {ii} конфет.");
        if (Candy <= 0) 
        win = "ii";
    } 
}
Console.WriteLine($"Выиграл {win}");


