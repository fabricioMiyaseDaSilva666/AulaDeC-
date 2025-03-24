using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosTint
{
    public class Control
    {
        exerciciosIniciais exer;

        public Control() 
        {
            this.exer = new exerciciosIniciais();
        }//Fim do construtor

        public void mostrarMenu() 
        {
            Console.WriteLine("Escolha uma das opções abaixo: " +
                "\n0. Sair" +
                "\n1. Mostrar Números" +
                "\n2. Média de três notas");
        }//Fim do método

        public void menu()
        {
            int opcao = 0;
            do
            { 
                mostrarMenu();//Mostrar as opções para o usuário
                opcao = Convert.ToInt32(Console.ReadLine());
                //Escolha
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\n\n\nObrigado!!!");
                        break;
                    case 1:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        exerciciosIniciais exer = new exerciciosIniciais(num1, num2);
                        //Utilizando - criando o objeto exer
                        Console.WriteLine(exer.imprimir());
                        break;
                    case 2:
                        Console.WriteLine("Informe uma nota entre 0 e 10");
                        double nota1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe uma nota entre 0 e 10");
                        double nota2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe uma nota entre 0 e 10");
                        double nota3 = Convert.ToDouble(Console.ReadLine());

                        //Executar
                        double media = this.exer.media(nota1, nota2, nota3);

                        //Resposta
                        if (media == -1)
                        {
                            Console.WriteLine("Uma ou mais notas estão erradas, digite novamente");
                        }
                        else
                        {
                            Console.WriteLine("\n\n A média é: " + media);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//Fim do escolha
            } while (opcao != 0);
        }//Fim dop método
    }//Fim da classe
}//Fim do projeto
