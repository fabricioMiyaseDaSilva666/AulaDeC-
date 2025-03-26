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
            int numePrimo = int.Parse(Console.ReadLine());
            static bool ePrimo(int n)
            {
                if (n < 2)
                {
                    return false;
                }
            }
        }
    }//Fim da classe
}//Fim do projeto
