using System;
using System.Reflection;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public double soma(Operacoes operacao)  // Alterado tipo - de int para double
        {
            return operacao.valorA + operacao.valorB;
        }
        public double subtracao(Operacoes operacao)  // Alterado tipo - de int para double
        {
            return operacao.valorA - operacao.valorB;
        }
        public double multiplicacao(Operacoes operacao) // Alterado tipo - de int para double
        {
            return operacao.valorA * operacao.valorB;
        }

        public double divisao(Operacoes operacao) // Implementado o cálculo de divisão
        {  // Alterado tipo - de int para double
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
