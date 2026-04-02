C#
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("======= Calculadora de Números Primos ======= \n");

Console.Write("Digite um número para verificar se é primo: ");
if (!double.TryParse(Console.ReadLine(), out double numero) || numero < 2)
{
    Console.WriteLine("Por favor, digite um número inteiro maior ou igual a 2. 🙄⚠️");
    return;
}

bool ehPrimo = true;

// Otimização: Testar apenas até a raiz quadrada do número
for (int i = 2; i <= Math.Sqrt(numero); i++)
{
    if (numero % i == 0)
    {
        ehPrimo = false;
        Console.WriteLine($"Divisor encontrado: {i}");
        break;
    }
}

if (ehPrimo)
    Console.WriteLine($"\n{numero} é um número primo! ‼️");
else
    Console.WriteLine($"\n{numero} não é primo. ❌");
