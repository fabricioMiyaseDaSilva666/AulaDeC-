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
    }//Fim da classe
}//Fim do projeto
