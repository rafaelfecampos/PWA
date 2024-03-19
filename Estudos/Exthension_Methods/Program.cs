using System;
using Exthension_Methods;
internal class Program
{
    private static void Main(string[] args)
    {
        var mensagem = "O homem não teria alcançado o possível se, repetidas vezes, não tivesse tentado o impossível.";
        var mensagemInvertida = mensagem.Revert();
        Console.WriteLine($"Mensagem original: {mensagem}");
        Console.WriteLine($"Mensagem invertida: {mensagemInvertida}");
        Console.WriteLine($"Número de palavras da mensagem: {mensagem.WordCount()}");
    }
}