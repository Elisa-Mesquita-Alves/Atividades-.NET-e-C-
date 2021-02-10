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
                        /*TODO: Adicionar aluno*/
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno(); /*Estancia o objeto aluno*/
                        aluno.Nome = Console.ReadLine(); /*Seta o nome do aluno*/

                        Console.WriteLine("Informe a nota do aluno:");

                      if(decimal.TryParse(Console.ReadLine(),out decimal nota))
                      {
                          aluno.Nota = nota;  
                      }
                      else
                     {
                         throw new ArgumentException("Valor da nota deve ser decimal");
                     }
                     alunos[indiceAluno] = aluno;
                     indiceAluno++;
                        break;

                    case "2":
                        /*TODO: Listar alunos*/
                    foreach(var A in alunos){
                        if(!String.IsNullOrEmpty(A.Nome)) /*!String.IsNullOrEmpty(A.Nome) vai mostrar apenas os alunos que não forem nulos os valores de nota*/
                        {
                    Console.WriteLine($"Aluno: {A.Nome} - Nota {A.Nota}");
                        }
                    }
                        break;

                    case "3":
                        /*TODO: Calcular média geral*/
                    decimal notaTotal = 0;  
                    var nrAlunos = 0;  
                    for(int i=0;i<alunos.Length; i++)
                    {
                    if(!String.IsNullOrEmpty(alunos[i].Nome))
                    {
                    notaTotal=notaTotal+alunos[i].Nota;
                    nrAlunos++;
                    }
                    }
                    var mediaGeral=notaTotal/nrAlunos;
                    Conceito conceitoGeral;

                    if(mediaGeral < 2)
                    {
                    conceitoGeral = Conceito.E;
                    }
                    else if(mediaGeral<4)
                    {
                        conceitoGeral = Conceito.D;
                    }
                    else if(mediaGeral<6)
                    {
                        conceitoGeral = Conceito.C;
                    }
                        else if(mediaGeral<8)
                    {
                        conceitoGeral = Conceito.D;
                    }
                        else if(mediaGeral<10)
                    {
                        conceitoGeral = Conceito.B;
                    }
                    else 
                    {
                        conceitoGeral = Conceito.A;
                    }
                    Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(); /* */

                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno:");
            Console.WriteLine("2- Listar alunos:");
            Console.WriteLine("3- Calcular média geral:");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
