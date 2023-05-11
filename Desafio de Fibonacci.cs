using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Desafio de Fibonacci: Escreva um programa que imprima a sequência de Fibonacci
            //  até o décimo termo.A sequência de Fibonacci é definida como:
            //   0, 1, 1, 2, 3, 5, 8, 13, 21, ...

             int termo = 0;
            int x = 0, y = 1, z = 0, sequencia = 0;

            for (int i = 1; i <= 10; i++)
            {
                z = x + y;
                y = x;
                x = z;

                termo = termo + 1;

                Console.WriteLine($"termo = {termo} - sequencia = {z}");

                Console.WriteLine($"n ={n}  x={x} - y={y} -  sequencia ={sequencia}  ");
            }
        }
    }
}

