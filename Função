#region Funções
static int calc(int a, int b, string z)
{
    switch (z)
    {
        case "+":
            return a + b;
        case "-":
            return a - b;
        case "x":
            return a * b;
        case "/":
            return a / b;

        default:
            throw new ArgumentException("Escolha uma classe matematica certa");
    }
}
#endregion

#region Variaveis/Menu
Console.Write("Escolha um numero: ");
int.TryParse(Console.ReadLine(), out int x);

Console.Write("Escolha outro numero: ");
int.TryParse(Console.ReadLine(), out int y);

Console.Write("Defina uma Classe matematica: ");
string b = Console.ReadLine()!; //o "!" não deixa o valor ser nulo

#endregion

#region head
int r = calc(x, y, b);
Console.WriteLine();
Console.WriteLine($"O resultado é {r}");
#endregion
