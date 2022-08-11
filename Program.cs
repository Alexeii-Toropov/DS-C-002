Console.Write("Введите число обозначающее номер дня недели  ");
int num = Convert.ToInt32(Console.ReadLine());
    if(num == 6 || num == 7)
    {
        Console.WriteLine("да");
    }
    else if(num > 7 || num < 1)
    {
        Console.WriteLine("не является днем недели");
    }
    else
    {
        Console.WriteLine("не выходной");
    }