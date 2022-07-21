using System;

namespace Array_Soma
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Sum = Metodo da Classe Calculator  que retorna a soma de qualquer quantidade de valores no Vetor*/


            int s1 = Calculator.Sum(new int[] {2,3,4,5,6,7,8,9}); 

            Console.WriteLine(s1);


            /* Sum2 = Metodo da Classe Calculator  que retorna a soma de qualquer quantidade de valores no Vetor usando PARAMS
             (modificador de Parametros*/

            int s2 = Calculator.Sum2(2, 3, 4, 5, 6, 7, 8, 9);
            
            Console.WriteLine(s2);

        }
    }
}
