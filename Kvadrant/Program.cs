
double x, y;
Console.WriteLine("Введите значение координаты х");
x = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
Console.WriteLine("Введите значение координаты у");
y = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
if (x > 0 && y > 0)
{
    Console.WriteLine("точка с координатами " + "(" + x + ";" + y + ") " + "находится в I квадранте");
}
else
{
    if (x < 0 && y > 0)
    {
        Console.WriteLine("точка с координатами " + "(" + x + ";" + y + ") " + "находится во II квадранте");
    }
    else
    {
        if (x < 0 && y < 0)
        {
            Console.WriteLine("точка с координатами " + "(" + x + ";" + y + ") " + "находится в III квадранте");
        }
        else 
        {
            if (x > 0 && y < 0)
            {
                Console.WriteLine("точка с координатами " + "(" + x + ";" + y + ") " + "находится в IV квадранте");
            }
            else
            {
            Console.WriteLine("точка с координатами " + "(" + x + ";" + y + ") " + "находится на оси ординат");
                
            }
        }
    }
        
}

