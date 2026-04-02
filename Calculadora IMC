C#
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("🏋️‍♂️ Calculadora de IMC 🏋️‍♀️");

Console.Write("Digite seu peso (kg): ");
double peso = double.Parse(Console.ReadLine()!);

Console.Write("Digite sua altura (m): ");
double altura = double.Parse(Console.ReadLine()!);

double imc = peso / (altura * altura);
Console.WriteLine($"\nSeu IMC é: {imc:F2} 📊");

if (imc < 18.5)
    Console.WriteLine("⚠️ Status: Abaixo do peso");
else if (imc < 25)
    Console.WriteLine("✅ Status: Peso normal");
else if (imc < 30)
    Console.WriteLine("⚠️ Status: Sobrepeso");
else
    Console.WriteLine("🚨 Status: Obesidade");
