using System;
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Digite o seu nome de usuário: ");
        string usuario = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha ="";
        while(true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            break;
            else
            {
                senha += tecla.KeyChar;
            }      
        }
        if (usuario == "Larissa" && senha == "1234")
        {
            Console.WriteLine("Usuário logado com sucesso");
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorreto");
        }
        Console.WriteLine("Pressione qualquer tecla para sair");
        Console.ReadKey();
    }
}