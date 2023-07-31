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
            return ConsultarOperacao -= num;
        }//fim do somar

        public double Dividir(double num)
        {                       
              return ConsultarOperacao /= num;            

        }// fim divisão

    }// fim da classe
}// fim do projeto 
