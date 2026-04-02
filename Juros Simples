C#
using System;

Console.WriteLine("=== Investimento de Juros Simples ===");

Console.Write("Digite o capital investido (R$): ");
float.TryParse(Console.ReadLine(), out float cap);

Console.Write("Digite o tempo investido (anos): ");
int.TryParse(Console.ReadLine(), out int temp);

Console.Write("Digite a taxa do juros anual (%): ");
float.TryParse(Console.ReadLine(), out float juros);

float taxa = juros / 100;
float lucroJuros = cap * taxa * temp;

Console.WriteLine($"\nO valor inicial foi de R$ {cap:F2}");
Console.WriteLine($"Tempo: {temp} ano(s)");
Console.WriteLine($"Capital final (Montante): R$ {lucroJuros + cap:F2}");
