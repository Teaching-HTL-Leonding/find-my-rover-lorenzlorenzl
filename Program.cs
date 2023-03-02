int dirgeonal = 0;
int vertikal = 0;
string input = "";

do
{

    Console.WriteLine("Pleas enter were the rover is:");
    input = Console.ReadLine()!;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '>')
        {
            dirgeonal = dirgeonal + 1;
        }
        else if (input[i] == '<')
        {
            dirgeonal = dirgeonal - 1;
        }

        if (input[i] == 'V')
        {
            vertikal = vertikal-1;
        }
        else if (input[i] == '^')
        {
            vertikal = vertikal+1;
        }
    }
}
while ((input != "q"));


if (vertikal <= 0)
{
    Console.WriteLine($"North = {dirgeonal}m");
}
else if (vertikal >= 0)
{
    Console.WriteLine($"South = {dirgeonal *(-1)}m");
}

if (dirgeonal <= 0)
{
    Console.WriteLine($"Ost = {vertikal}m");
}
else if (dirgeonal >= 0)
{
    Console.WriteLine($"West = {vertikal * (-1)}m");
}



