C#
using System;
using System.Text;

// Configuração para aceitar caracteres especiais no console (UTF-8)
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== Gerador de PA Otimizado (Alta Performance) ===");

// Entrada da quantidade de termos com suporte a números grandes (long)
Console.Write("Digite a quantidade de termos: ");
if (!long.TryParse(Console.ReadLine(), out long quantidade) || quantidade <= 0)
{
    Console.WriteLine("Quantidade inválida. Insira um número inteiro positivo.");
    return;
}

// Entrada do salto ou razão da PA
Console.Write("Digite o valor do salto (razão): ");
if (!int.TryParse(Console.ReadLine(), out int salto))
{
    Console.WriteLine("Salto inválido.");
    return;
}

Console.WriteLine("\n--- Resultados ---");
Console.WriteLine($"Razão aplicada: {salto}");
Console.WriteLine("Sequenciamento:");

int termoAtual = 0;

/* ESTRATÉGIA DE OTIMIZAÇÃO: 
   Não utilizamos listas (List<int>) para evitar o consumo excessivo de memória RAM.
   Os resultados são impressos diretamente no console durante o processamento.
*/
for (long i = 0; i < quantidade; i++)
{
    Console.Write(termoAtual);
    
    if (i < quantidade - 1) 
        Console.Write(" → ");

    termoAtual += salto;

    // Organização visual: Quebra de linha a cada 10 termos impressos
    if ((i + 1) % 10 == 0) 
        Console.WriteLine();
}

Console.WriteLine("\n\n--- Fim do processamento ---");
