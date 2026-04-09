using System;

Console.WriteLine("--- Calculadora de Raiz Quadrada (C#) ---");

Console.Write("Digite um número: ");
string entrada = Console.ReadLine();

// Tenta converter a entrada para double
if (double.TryParse(entrada, out double numero))
{
    if (numero < 0)
    {
        Console.WriteLine("Erro: Não é possível calcular a raiz de um número negativo no conjunto dos reais.");
    }
    else
    {
        // Math.Sqrt é a função padrão para raiz quadrada
        double raiz = Math.Sqrt(numero);
        
        // Exibindo com 2 casas decimais usando Interpolação de String ($)
        Console.WriteLine($"A raiz quadrada de {numero} é: {raiz:F2}");
    }
}
else
{
    Console.WriteLine("Erro: Por favor, digite um número válido.");
}
