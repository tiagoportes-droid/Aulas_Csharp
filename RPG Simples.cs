using System;
using System.Threading;

#region Variaveis Globais
int danoMagia = 0;
string resultado = "";
#endregion

#region VFX (Efeitos Visuais)
static void EscreverLento(string texto, int velocidade)
{
    foreach (char caractere in texto)
    {
        Console.Write(caractere);
        Thread.Sleep(velocidade);
    }
}

static void EfeitoCarregamento(string msg)
{
    EscreverLento(msg, 50);
    for (int i = 0; i < 3; i++)
    {
        Console.Write(".");
        Thread.Sleep(500);
    }
    Console.WriteLine();
}
#endregion

#region Grimorio
static string Grimoriosorte()
{
    string[] grimorio = {
        "Anti-Magia", "Magia do Tempo", "Magia do Vento", "Magia do Fogo",
        "Magia do Raio", "Magia de Água", "Magia de Luz", "Magia de Trevas"
    };

    Random grimo = new Random();
    return grimorio[grimo.Next(grimorio.Length)];
}
#endregion

#region Nome
static string Escolhanome()
{
    Console.Clear();
    EscreverLento("--- CRIAÇÃO DE PERSONAGEM ---\n", 50);
    EscreverLento("Defina um nome ao seu mago: ", 50);
    return Console.ReadLine();
}
#endregion

#region Gênero
static bool Genero(string user)
{
    EscreverLento("\nDefina seu genero [M/F]: ", 50);
    string gener = Console.ReadLine().ToUpper();

    if (gener == "M")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        EscreverLento($"\n>>> Mago {user} foi registrado no Reino de Clover!", 50);
        Console.ResetColor();
        return true;
    }
    else if (gener == "F")
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        EscreverLento($"\n>>> Maga {user} foi registrada no Reino de Clover!", 50);
        Console.ResetColor();
        return true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        EscreverLento("\n[ERRO] Gênero inválido. Tente novamente.", 50);
        Console.ResetColor();
        return false;
    }
}
#endregion

#region Dano Magias
static int DefinirDano(string magiaSorteada)
{
    return magiaSorteada switch
    {
        "Anti-Magia" => 100,
        "Magia do Tempo" => 95,
        "Magia do Fogo" => 80,
        "Magia do Raio" => 75,
        "Magia de Luz" => 88,
        "Magia de Trevas" => 85,
        _ => 50
    };
}
#endregion

#region Sistema de Batalha
static void AparecerInimigo(int danoDoJogador)
{
    string[] nomes = { "Goblin", "Lobo", "Demônio" };
    int[] vidas = { 50, 40, 150 };
    int[] danosInimigo = { 10, 8, 25 };

    Random rand = new Random();
    int i = rand.Next(nomes.Length);

    string nomeInimigo = nomes[i];
    int hpInimigo = vidas[i];
    int danoInimigo = danosInimigo[i];
    int seuHp = 100;

    Console.WriteLine();
    EfeitoCarregamento("Sentindo mana hostil");

    Console.ForegroundColor = ConsoleColor.Red;
    EscreverLento($"\n!!! UM {nomeInimigo.ToUpper()} SURGIU !!!\n", 50);
    Console.ResetColor();

    while (hpInimigo > 0 && seuHp > 0)
    {
        EscreverLento($"\nHP Jogador: {seuHp} | HP {nomeInimigo}: {hpInimigo}", 30);
        EscreverLento("\nAção [A]TACAR | [D]EFENDER | [F]UGIR: ", 30);
        string acao = Console.ReadLine().ToUpper();

        if (acao == "A")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            EscreverLento($"\n» Você lançou sua magia!", 30);
            hpInimigo -= danoDoJogador;
            EscreverLento($"\n» O {nomeInimigo} recebeu {danoDoJogador} de dano!", 30);
            Console.ResetColor();
            if (hpInimigo <= 0) break;
        }
        else if (acao == "D")
        {
            EscreverLento("\n» Você se defendeu!", 40);
        }
        else if (acao == "F")
        {
            if (rand.Next(1, 11) <= 3)
            {
                EscreverLento("\n» Você fugiu da batalha!", 50);
                return;
            }
            EscreverLento("\n» A fuga falhou!", 50);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        EscreverLento($"\n» O {nomeInimigo} ataca!", 40);
        int danoRec = (acao == "D") ? danoInimigo / 2 : danoInimigo;
        seuHp -= danoRec;
        EscreverLento($"\n» Dano recebido: {danoRec}!", 40);
        Console.ResetColor();
        Console.WriteLine("\n-------------------------------------------");
    }

    if (seuHp <= 0)
    {
        EscreverLento("\n--- VOCÊ FOI DERROTADO ---", 60);
        Environment.Exit(0);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        EscreverLento("\n--- VITÓRIA COMPLETA ---", 50);
        Console.ResetColor();
    }
}
#endregion

#region Lógica Principal
string user = Escolhanome();

while (!Genero(user)) ;

Console.WriteLine();
EfeitoCarregamento("Escolhendo seu Grimório");

resultado = Grimoriosorte();
danoMagia = DefinirDano(resultado);

Console.ForegroundColor = ConsoleColor.Cyan;
EscreverLento($"\nGRIMÓRIO: {resultado.ToUpper()}", 50);
Console.ResetColor();
EscreverLento($"\nPoder de Mana: {danoMagia}\n", 50);

AparecerInimigo(danoMagia);

EscreverLento("\nFim da aventura por enquanto...", 50);
Console.ReadLine();
#endregion
