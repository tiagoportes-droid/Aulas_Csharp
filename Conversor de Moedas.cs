C#
using System;
using System.Globalization;

// Aceita ponto decimal independente da região
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Digite o valor em Reais (R$): ");

if (float.TryParse(Console.ReadLine(), out float reais))
{
    Console.WriteLine("\nEscolha a moeda: 1-Dólar | 2-Euro | 3-Libra");
    string opcao = Console.ReadLine();

    float cotacao = opcao switch {
        "1" => 5.49f,
        "2" => 6.33f,
        "3" => 6.99f,
        _ => 0
    };

    if (cotacao > 0) {
        float resultado = reais / cotacao;
        Console.WriteLine($"\nValor convertido: {resultado:F2}");
    } else {
        Console.WriteLine("Opção inválida!");
    }
}


