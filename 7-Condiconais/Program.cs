using System;
class Programa
{
    static void Main(String[] arg)
    {
        Console.WriteLine("Executando o projeto 7 - Condiconais");

        int idadeJoão = 16;
        int quantidadePessoas = 2;

        if (idadeJoão >= 18)
        {
            Console.WriteLine("Podwe entrar!");
        }
        else
        {
            if(quantidadePessoas> 1)
            {
                Console.WriteLine("Eele está acompanhado . Pode entrar!");

            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            

        }

                   
        Console.WriteLine("Tecle Enter para fechar....");
        Console.ReadLine();
    }
}


