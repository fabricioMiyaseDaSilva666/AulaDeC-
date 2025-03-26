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
                               "\n2. Média de três notas" +
                               "\n3. Número negativo, positivo ou zero" +
                               "\n4. Tabuada" +
                               "\n5. Número Fatorial" +
                               "\n6. Ver a potêrncia e a raiz" +
                               "\n7. Número par ou impar" +
                               "\n8. Números em orndem crescente" +
                               "\n9. Médias de um número" +
                               "\n10. Vogais em uma palavra" +
                               "\n11. Palavrinha invertida");
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

                    case 3:
                        Console.WriteLine("Informe um número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.negativoPosZe(num));
                        break;

                    case 4:
                        Console.WriteLine("Informe um número");
                        int tabu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.tabuada(tabu));
                        break;

                    case 5:
                        Console.WriteLine("Informe um número");
                        int fatorial = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.fatorial(fatorial));
                        break;

                    case 6:
                        Console.WriteLine("Informe um número");
                        int potencia1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um segundo número");
                        int potencia2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.potenRaiz(potencia1, potencia2));
                        break;
                        
                    case 7:
                        Console.WriteLine("Informe um número");
                        int parImpar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.parImp(parImpar));
                        break;

                    case 8:
                        Console.WriteLine("Informe um número");
                        int cres1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número");
                        int cres2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.crescente(cres1, cres2));
                        break;

                    case 9:
                        Console.WriteLine("Informe um número");
                        int nume1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe mais um número");
                        int nume2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe mais um número");
                        int nume3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe mais um número");
                        int nume4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe mais um número");
                        int nume5 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.numMedia(nume1, nume2, nume3, nume4, nume5));
                        break;

                    case 10:
                        Console.WriteLine("Escreva uma palavra");
                        string vogais = Console.ReadLine();

                        Console.WriteLine(this.exer.vogaisContar(vogais));
                        break;

                    case 11:
                        Console.WriteLine("Escreva alguma coisa");
                        string palavra = Console.ReadLine();

                        Console.WriteLine(this.exer.palavraInver(palavra));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                    
                }//Fim do escolha
            } while (opcao != 0);
        }//Fim dop método
    }//Fim da classe
}//Fim do projeto
