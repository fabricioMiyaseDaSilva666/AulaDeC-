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
                               "\n0.  Sair" +
                               "\n1.  Mostrar Números" +
                               "\n2.  Média de três notas" +
                               "\n3.  Número negativo, positivo ou zero" +
                               "\n4.  Tabuada" +
                               "\n5.  Número Fatorial" +
                               "\n6.  Ver a potêrncia e a raiz" +
                               "\n7.  Número par ou impar" +
                               "\n8.  Números em orndem crescente" +
                               "\n9.  Médias de um número" +
                               "\n10. Vogais em uma palavra" +
                               "\n11. Palavrinha invertida" +
                               "\n12. Número primo" +
                               "\n13. Somar e Multiplicar" +
                               "\n14. Somar média de três números" +
                               "\n15. Porcentagem de 15%" +
                               "\n16. Porcentagem de 5% e de 50%" +
                               "\n17. Quadrado de um número" +
                               "\n18. m/s para km" +
                               "\n19. Calcular o IMC de alguém" +
                               "\n20. Calcular o desconto de 9%" +
                               "\n21. Desconto de 7%" +
                               "\n22. Calcular o volume da caixa" +
                               "\n23. Desconto de 27%" +
                               "\n24. Área de um trapézio" +
                               "\n25. Media de notas com ponderada" +
                               "\n26. Valor parcelado" +
                               "\n27. Consumo de gasolina por kms");
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

                    case 12:
                        Console.WriteLine("Digite um número");
                        int numPrimo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.primo(numPrimo));
                        break;

                    case 13:
                        Console.WriteLine("Digite um número");
                        int numSoma1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite mais um número");
                        int numSoma2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.somaMult(numSoma1, numSoma2));
                        break;

                    case 14:
                        Console.WriteLine("Digite um númro");
                        int mad1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite mais um número");
                        int mad2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite mais um númro");
                        int mad3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.mediaTresNum(mad1, mad2, mad3));
                        break;

                    case 15:
                        Console.WriteLine("Informe um valor");
                        int porcentage = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.porcentagemNum(porcentage));
                        break;

                    case 16:
                        Console.WriteLine("Informe um número");
                        int porcentagem = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.porcentagem2(porcentagem));
                        break;

                    case 17:
                        Console.WriteLine("Informe um número");
                        int quadrado1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número");
                        int quadrado2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.quadrado(quadrado1, quadrado2));
                        break;

                    case 18:
                        Console.WriteLine("Informe um número");
                        int ms = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.km(ms));
                        break;

                    case 19:
                        Console.WriteLine("Informe uma altura");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe um peso");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.imc(altura, peso));
                        break;

                    case 20:
                        Console.WriteLine("Informe um valor");
                        double preso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.desconto(preso));
                        break;

                    case 21:
                        Console.WriteLine("Informe um número");
                        double descontos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.descontos(descontos));
                        break;

                    case 22:
                        Console.WriteLine("Informe um comprimeto");
                        double comprimento = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe largura");
                        double largura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe uma altura");
                        double alturas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.volumeCaixa(comprimento, largura, alturas));
                        break;

                    case 23:
                        Console.WriteLine("Informe um valor");
                        double presos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.desconto3(presos));
                        break;

                    case 24:
                        Console.WriteLine("Informe um valor");
                        int baseMaior = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro valor");
                        int baseMenor = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe mais um valor");
                        int h = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.trapezio(baseMaior, baseMenor, h));
                        break;

                    case 25:
                        Console.WriteLine("Informe a primeira nota entre 0 e 10");
                        double notas1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a primeira nota entre 0 e 10");
                        double notas2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a primeira nota entre 0 e 10");
                        double notas3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.mediaPon(notas1, notas2, notas3));
                        break;

                    case 26:
                        Console.WriteLine("Informe um valor");
                        double presosPar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.desconto4(presosPar));
                        break;

                    case 27:
                        Console.WriteLine("Informe os km");
                        double kms = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe os litros de gasolina");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.distancia(kms, litros));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                    
                }//Fim do escolha
            } while (opcao != 0);
        }//Fim dop método
    }//Fim da classe
}//Fim do projeto
