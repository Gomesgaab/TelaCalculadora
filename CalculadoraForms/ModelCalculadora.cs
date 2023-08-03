using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForms
{
     class ModelCalculadora
    {
        private double operacao;
        public ModelCalculadora()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do método
        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do somar

        public double Subtrair(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao -= num;
        }//fim do somar

        public double Dividir(double num)
        {
            if (ConsultarOperacao <= 0)
            {
               return  ConsultarOperacao = num;
            }
             return ConsultarOperacao /= num;
        }// fim divisão

        public double Multiplicar(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
                return ConsultarOperacao *= num;
        }//fim do método multiplicar

        public double Potencia(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return Math.Pow(ConsultarOperacao, num);
        }//fim da potência

        public double Raiz(double num)
        {
            
            return Math.Sqrt(num); 

        }//fim do método raiz
    }// fim da classe
}// fim do projeto 
