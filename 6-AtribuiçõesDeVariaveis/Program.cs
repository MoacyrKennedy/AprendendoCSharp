using System;
class Programa
{
    static void Main(String[] arg)
    {
        Console.WriteLine("Executando projeto6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Tecle Enter para fechar....");
        Console.ReadLine();
    }
}


