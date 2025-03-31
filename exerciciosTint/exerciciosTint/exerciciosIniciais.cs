using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosTint
{
    public class exerciciosIniciais
    {
        //Área de variáveis -> Globais
        private int num1;
        private int num2;

        public exerciciosIniciais() 
        {
            
        }//Fim do construtor

        public exerciciosIniciais(int num1, int num2)
        {
            //Áreas globais
            this.num1 = num1;
            this.num2 = num2;
        }//Fim do contrutor

        //Métodos Modificadors
        public int getNum1() { return this.num1; }
        public int getNum2() { return this.num2; }

        public void setNum1(int num1) { this.num1 = num1; }
        public void setNum2(int num2) { this.num2 = num2; }

        public string imprimir() 
        {
            return "\nPrimeiro Número: " + getNum1() +
                   "\nSegundo Número: "  + getNum2();
        }//Fim do imprimir

        public double media(double nota1, double nota2, double nota3) 
        {
            double med = 0; //Aqui ele sempre precisa de um valor, e ele sempre vai começar em 0
            if((nota1 >= 0 && nota1 <= 10) && 
               (nota2 >= 0 && nota2 <= 10) && 
               (nota3 >= 0 && nota3 <= 10)) 
            {
                med = (nota1 + nota2 + nota3) / 3;
                return med;
            }//Fim do if
            return -1;//Pra termina a model, sempre tem que usa o return, NÃO outra coisa
        }//Fim do método
        public string negativoPosZe(int num) 
        {
            if (num < 0) 
            {
                return "Esse número é negativo";
            }
            else if (num > 0) 
            {
                return "Esse número é positivo";
            }
            else 
            {
                return "Esse número é um zero";
            }
            
        }//Fim do método
        
        public string tabuada(int tabu) 
        {
            string resposta = "";
            for (int i = 0; i <= 10; i++) 
            {
                resposta +="\n" + tabu + " * " + i + " = " + (tabu * i);
            }
            return resposta;
        }//Fim do método

        public int fatorial(int fatorial) 
        {
            int i = fatorial - 1;
            string resposta = "";
            for (i = i; i >= 1; i--) 
            {
                fatorial += i * fatorial;
            }
            return fatorial;
        }//Fim do método

        
        public string potenRaiz(int potencia1, int potencia2)
        {
            int potencia = potencia1 * potencia2;
            double raiz = 0;
            int metade = potencia / 2;
            return "A potência desses dois números é: " + potencia + "\nA raiz dessa potência é: " + (raiz = Math.Sqrt(potencia)); 
        }//Fim do método

        public string parImp(int parImpar)
        {
            if (parImpar % 2 == 0)
            {
                return "Esse número é par!";
            }
            else
            {
                return "Esse número é impar!";
            }
        }//Fim do método

        public string crescente(int cres1, int cres2)
        {
            string crescente1 = "";
            string crescente2 = "";
            for(int i = 0; i <= cres1; i++)
            {
                crescente1 += i;
            }
            for(int i2 = 0; i2 <= cres2; i2++)
            {
                crescente2 += i2;
            }
            return crescente1 + "\n" + crescente2; 
        }//Fim do método

        public string numMedia(int nume1, int nume2, int nume3, int nume4, int nume5)
        {
            double medias = 0;
            medias = (nume1 + nume2 + nume3 + nume4 + nume5) / 5;
            return "A media é" + medias;
        }//Fim do método

        public string vogaisContar(string vogais)
        {
            vogais = vogais.ToLower();
            int contarVoga = 0;
            string vogal = "aeiou";
            foreach (char c in vogais)
            {
                if (vogal.Contains(c))
                {
                    contarVoga++;
                }
            }
            return "Essa palavra tem " + contarVoga + " vogais";
        }//Fim do método

        public string palavraInver(string palavra)
        {
            char[] caracteres = palavra.ToCharArray();

            Array.Reverse(caracteres);
            string invertida = new string(caracteres);
            return invertida;
        }//Fim do método

        public string primo(int numPrimo)
        {
            if(numPrimo <= 1)
            {
                return "Não é primo";
            }
            for(int i = 2; i <= Math.Sqrt(numPrimo); i++)
            {
                if(numPrimo % i == 0)
                {
                    return "Não é primo";
                }
            }
            return "É primo";
        }//Fim do método

        public string somaMult(int numSoma1, int numSoma2)
        {
            int soma = 0;
            soma = numSoma1 + numSoma2;
            int mult = 0;
            mult = soma * numSoma1;
            return "A soma dos dois números é " + soma + " E a multiplicação dessa soma com o primeiro número é " + mult;
        }//Fim do método

        public string mediaTresNum(int mad1, int mad2, int mad3)
        {
            int media1 = 0;
            media1 = (mad1 + mad2 + mad3) / 3;
            
            return "A média desses 3 médias é " + media1;
        }//Fim do método

        public string porcentagemNum(int porcentage)
        {
            int resposta = 0;
            resposta = (porcentage * 15) / 100;
            return "15% desse valor é " + resposta;
        }//Fim do método

        public string porcentagem2(int porcentagem)
        {
            int resposta1 = 0;
            int resposta2 = 0;

            resposta1 = (porcentagem * 5) / 100;
            resposta2 = (porcentagem * 50) / 100;

            return "5% desse valor é " + resposta1 + " e 50% desse valor é " + resposta2;
        }//Fim do método
        
        public string quadrado(int quadrado1, int quadrado2)
        {
            int resposta1 = 0;
            int resposta2 = 0;
            int resposta3 = 0;

            resposta1 = quadrado1 * quadrado1;
            resposta2 = quadrado2 * quadrado2;
            resposta3 = resposta1 + resposta2;

            return "O quadrado do primeiro número é " + resposta1 + " O segundo é " + resposta2 + "\n" + "e a soma desses quadrados é " + resposta3;
        }//Fim do método

        public string km(int ms)
        {
            double km = 0;

            km = ms * 3.6;

            return "Os km desse m/s são: " + km;
        }//Fim do método

        public string imc(double altura, double peso)
        {
            double imc = 0;
            double alt = 0;

            alt = altura * 2;
            imc = altura / peso;

            return "O IMC dessa pessoa é: " + imc;
        }//Fim do método

        public string desconto(double preso)
        {
            double desconto = 0;
            double descontinho = 0;

            desconto = (preso * 9) / 100;
            descontinho = preso - desconto;

            return "O desconto de 9% do seu item vai ser " + descontinho;
        }//Fim do método

        public string descontos(double descontos)
        {
            double desconto = 0;
            double descontinho = 0;

            desconto = (descontos * 7) / 100;
            descontinho = descontos - desconto;

            return "O valor original do seu produto é: " + descontos + "\n" + " O desconto de 7% do seu item vai ser " + descontinho;
        }//Fim do método

        public string volumeCaixa(double comprimento, double largura, double alturas)
        {
            double volume = 0;
            volume = comprimento * largura * alturas;

            return "O volume da caixa é " + volume;
        }//Fim do método

        public string desconto3(double presos)
        {
            double desconto = 0;
            double descontinho = 0;

            desconto = (presos * 27) / 100;
            descontinho = presos - desconto;

            return "O desconto de 27% do seu item vai ser " + descontinho;
        }//Fim do método

        public string trapezio(int baseMaior, int baseMenor, int h)
        {
            double resposta = 0;
            resposta = (baseMaior + baseMenor) * h;
            resposta = resposta / 2;

            return "O trapézio desses valores é " + resposta;
        }//Fim do método

        public string mediaPon(double notas1, double notas2, double notas3)
        {
            double media = 0;
            double mediaFinal = 0;
            double notaPon1 = 0;
            double notaPon2 = 0;
            double notaPon3 = 0;

            notaPon1 = notas1 * 2;
            notaPon2 = notas2 * 3;
            notaPon3 = notas3 * 5;
            media = notaPon1 + notaPon2 + notaPon3;
            mediaFinal = media / 10;

            if (mediaFinal == -1)
            {
                return "Uma ou mais notas estão erradas, digite novamente";
            }
            else
            {
                return "\n\n A média é: " + mediaFinal;
            }

        }//Fim do método

        public string desconto4(double presosPar)
        {
            double desconto = 0;
            double descontinho = 0;
            double parcela = 0;

            desconto = (presosPar * 16) / 100;
            descontinho = presosPar + desconto;
            parcela = descontinho / 10;

            return "O acrescimo de 16% do seu item vai ser " + descontinho + " e sua parcela de 10 vezes vai sair por" + parcela;
        }//Fim do método

        public string distancia(double kms, double litros)
        {
            double consumoMedio = 0;

            consumoMedio = kms / litros;

            return "O consumo médio de gasolina é de" + consumoMedio + "km por litro";
        }
    }//Fim da classe
}//Fim do projeto
