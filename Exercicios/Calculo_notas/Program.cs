using System;

class Program
{
    static int nota = 0;

    static void LerNota()
    {
        Console.Write("Digite a nota do aluno: ");
        nota = Convert.ToInt32(Console.ReadLine());
    }

    static void VerificarNota()
    {
        if (nota >= 5)
        {
            Console.WriteLine("Nota suficiente para aprovação.");
        }
        else
        {
            Console.WriteLine("Nota insuficiente para aprovação.");
        }
    }

    static void Main(string[] args)
    {
        LerNota();
        VerificarNota();
    }
}
