using System;

class Program
{
    public static void Main(string[] args)
    {
        string[,] contatos = new string[5, 4]; //5 CONTATOS PARA 4 COLUNAS

        Console.WriteLine("--------------------------------");
        Console.WriteLine("******CADASTRO DE CONTATOS******");
        Console.WriteLine("--------------------------------");

        string cadastrarOutro = "S";

        for (int contato = 0; contato <= 4 && cadastrarOutro == "S"; contato++)
        {
            Console.WriteLine("DIGITE OS DADOS DO CONTATO {0}", contato +1);
            for (int coluna = 0; coluna <= 3; coluna++)
            {
                switch (coluna)
                {
                    case 0:
                        Console.Write("CPF: ");
                        break;
                    case 1:
                        Console.Write("Nome: ");
                        break;
                    case 2:
                        Console.Write("Telefone: ");
                        break;
                    default:
                        Console.Write("E-mail: ");
                        break;
                }
                contatos[contato, coluna] = Console.ReadLine();
            }
            Console.WriteLine("Contato Gravado!");
            Console.Write("Cadastrar outro contato? (S/N)");
            cadastrarOutro = Console.ReadLine();
            Console.Clear(); //LIMPA CONSOLE
        }

        Console.WriteLine(new string ('-', 90));
        Console.WriteLine("| {0,-15} | {1,-20} | {2,-20} | {3,-26}| ", "CPF", "NOME", "TELEFONE", "E-MAIL");
        Console.WriteLine(new string('-', 90));
        for (int contato = 0; contato <= 4; contato++)
        {
            Console.WriteLine("| {0,-15} | {1,-20} | {2,-20} | {3,-26}|", contatos[contato, 0], contatos[contato, 1], contatos[contato, 2], contatos[contato, 3]);
            Console.WriteLine(new string('-', 90));
        }
    }
}