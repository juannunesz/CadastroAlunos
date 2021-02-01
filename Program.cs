using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpacaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        Console.WriteLine("Adicionando Auluno");
                        break;

                    case "2":
                        //TOdO: Listar alunos
                        Console.WriteLine("Listando Alunos");
                        break;

                    case "3":
                        //TODO: Calcular a media 
                        Console.WriteLine("Calculando media");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = obterOpacaoUsuario();
            }




        }

        private static string obterOpacaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }


    }
}
