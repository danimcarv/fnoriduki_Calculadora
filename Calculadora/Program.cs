using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            
            Stack<double> resultados = new Stack<double>(); // Implementação da Stack

            while (filaOperacoes.Count > 0) // Alterado o parâmetro do while
            { // Após zerar a Queue, ele estava gerando uma exceção devido a tentar remover itens da Queue vazia. Alterar de ">= 0" para "> 0" solucionou o problema
                Operacoes operacao = filaOperacoes.Dequeue(); // Alterado método. O método Peak retorna o item mas não o remove, o que estava causando o processamento infinito
                calculadora.calcular(operacao);
                resultados.Push(operacao.resultado); // Implementação da Stack
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                if (filaOperacoes.Count != 0) Console.WriteLine("Próximas operações:"); // Implementação da lista de operações
                else Console.WriteLine("Fim das operações"); // Implementação da lista de operações
                foreach (Operacoes novaoperacao in filaOperacoes) // Implementação da lista de operações
                { // Implementação da lista de operações
                    Console.WriteLine("{0} {1} {2}", novaoperacao.valorA,novaoperacao.operador,novaoperacao.valorB); // Implementação da lista de operações
                } // Implementação da lista de operações
                Console.WriteLine(); // Implementação da lista de operações
            }

            Console.WriteLine("Lista de Resultados (Stack / LIFO)"); // Implementação da Stack
            foreach (double resultado in resultados) Console.WriteLine(resultado); // Implementação da Stack
           
        }
    }
}
