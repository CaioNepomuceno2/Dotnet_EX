using System;

namespace Revisao
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        {
                            Console.WriteLine("Informe o nome do aluno: ");
                            Aluno aluno = new Aluno();
                            aluno.Nome = Console.ReadLine();

                            Console.WriteLine("Informe a nota do aluno: ");

                            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                            {
                                aluno.Nota = nota;
                            }
                            else
                            {
                                throw new ArgumentException("Valor da not deve ser decimal");
                            }
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;

                            //TODO: Adicionar alunos
                            break;
                        }
                    case "3":
                        {
                        //TODO: listar alunos
                            foreach (var a in alunos)
                            {
                                if(!string.IsNullOrEmpty(a.Nome))
                                {
                                    Console.WriteLine($"Aluno: {a.Nome} - NOTA: {a.Nota} ");
                                }
                                
                            }
                            break;
                        }
                    case "5":
                        //TODO: Calcular média alunos
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
            
                
            }
            ObterOpcaoUsuario();
        }
    }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listr Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}