using System;
class Program
{
    static string[] programLanguages = { "C#", "Java", "Python", "JavaScript", "Ruby", "PHP", "Swift", "Go", "Kotlin", "Rust" };

    static void PrintLanguages()
    {
        for (int i = 0; i < programLanguages.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {programLanguages[i]}");
        }

        Console.Write("Selecione o número da linguagem de programação que você deseja:");
        int input = Convert.ToInt32(Console.ReadLine());
        SelectLanguage(input);
    }
    static void SelectLanguage(int position)
    { 
        if (position < 1 || position > programLanguages.Length)
        {
            Console.WriteLine("Posição inválida. Por favor, selecione um número entre 1 e " + programLanguages.Length);
            PrintLanguages();
            
        }
        Console.WriteLine($"Você selecionou: {programLanguages[position - 1]}");
    }
    static void Main(string[] args)
    {
        PrintLanguages();
    }
}