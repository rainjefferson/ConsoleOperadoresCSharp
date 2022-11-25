using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperadores
{
    class Program
    { 
        static void Main(string[] args)
        {
            #region Operadores matematicos 
            int num1 = 16;
            int num2 = 2;

            Console.WriteLine("num1 + num2: " + (num1 + num2));
            Console.WriteLine("num1 - num2: " + (num1 - num2));
            Console.WriteLine("num1 * num2: " + num1 * num2);
            Console.WriteLine("num1 / num2: " + num1 / num2);
            Console.WriteLine("num1 % num2: " + num1 % num2);
            #endregion

            #region Ordem de precedencia
            // 1. operação entre parenteses (..)
            // 2. operação de multiplicação e divisão * e /
            // 3. operação de adiçãoe subtração + e -

            Console.WriteLine("5 + 5 * 2 = " + (5 + 5 * 2));

            Console.WriteLine("(5 + 5) * 2 = " + ((5 + 5) * 2));
            #endregion

            #region Operadores de incremento e decremento
            // ++ -> num++ é igual a num = num + 1 -> neste caso executa a operação depois incrementa
            // ++ -> ++num é igual a num = num + 1 -> neste caso incrementa primeiro depois executa o restante da operação
            // -- -> num-- é igual a num = num - 1 -> neste caso executa a operação depois decrementa
            // -- -> --num é igual a num = num - 1 -> neste caso decrementa primeiro depois executa o restante da operação

            int incrementa = 1000;
            int decrementa = 1000;

            Console.WriteLine("++incrementa = " + ++incrementa);
            Console.WriteLine("incrementa++ = " + incrementa++);
            Console.WriteLine("--decrementa = " + decrementa--);
            Console.WriteLine("decrementa-- = " + decrementa--);
            #endregion

            #region Operadore de concatenação
            // + concatena string literais oun variaveis
            string nome = "Jefferson ";
            string idade = "idade ";
            Console.WriteLine(nome + idade + 41);
            #endregion

            #region Operadores de atribuição
            // =  : atribui um valor a uma variavel de uma literal, outra variavel ou expressão
            // += : recebe um resultado com soma, exemplo a += b, a recebe o resultado de a + b
            // -= : recebe um resultado com subtração, exemplo a -= b, a recebe o resultado de a - b 
            // *= : recebe um resultado com multiplicação, exemplo a *= b, a recebe o resultado de a * b
            // /= : recebe um resultado com divisão, exemplo a /= b, a recebe o resultado de a / b 
            // %= : recebe um resultado com resto da divisão, exemplo a %= b, a recebe o resto da divisão de a % b 

            int adicionar = 20;
            adicionar += 30; // mesmo que adicionar = adicionar + 30;

            int subtrair = 100;
            subtrair -= 15; // mesmo que subtrair = subtrair -15;

            Console.WriteLine("adicionar: " + adicionar);
            Console.WriteLine("subtrair: " + subtrair);
            #endregion

            #region Operadores de igualdade
            // == : Igual
            // != : diferente

            bool resultado = 100 == 50; // 100 é igual a 50? false
            Console.WriteLine(resultado);
            resultado = 100 == 50 * 2; // 100 é igual a 50 x 2? sim
            Console.WriteLine(resultado);
            #endregion

            #region Operadores relacionais
            // > : Maior que
            // < : Menor que
            // >= : Maior ou igual a
            // <= : Menor ou igual a
            #endregion

            #region Operadores logicos
            // && : and -> retorna true quando todas as expressões são verdadeiras
            // || : or -> retorna true quando pelo menos uma expressão é verdadeira
           
            #endregion

            Console.ReadKey();

        }
    }
}
