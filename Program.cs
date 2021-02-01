using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5];

            var indiceAluno =  0; 

            string opcaoUsuario = obterOpacaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        Aluno aluno =  new Aluno();
                        Console.WriteLine("Informe o nome do aluno:");
                        aluno.Nome = Console.ReadLine();
                       
                        Console.WriteLine("Informe a nota do aluno:");

                        if(decimal.TryParse(Console.ReadLine(),out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor de nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;

                    case "2":
                        //TOdO: Listar alunos
                        foreach(var a in alunos)
                        {
                            if(!a.Nome.Equals("")){
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                            
                        }
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
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            Console.WriteLine();

            return opcaoUsuario;
        }


    }
}
