using System;
namespace Calculadora
{
    public class Operacoes
    {
        public double valorA {get;set;} // Alterado tipo - de int para double
        public char operador { get; set; }
        public double valorB { get; set; } // Alterado tipo - de int para double
        public double resultado { get; set; } // Alterado tipo - de decimal para double
        // Uso do decimal para armazenar os resultados não se faz necessário para essa aplicação.
        // Trata-se de um tipo de 128-bit de armazenamento. O tipo double já atende as nossas necessidades.

        /*
        O erro na penúltima operação se deve ao tipo de dado utilizado.
        O tipo int, com capacidade de 32-bit, estava sendo suficiente para armazenar o valorA no seu limite de capacidade.
        Ao somar 2, o limite era superado, fazendo com que, incorretamente, o número passasse a ser negativo ao invés de efetuar a soma correta.
        Isso foi corrigido por meio do uso do tipo double, de 64-bit
        Que além de ser suficiente para armazenar valores muito maiores, também permite o uso de números decimais.
        */

    }
}
