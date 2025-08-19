using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Program // CLASSE DA INTERFACE
    {
        static void Main(string[] args)
        {
            Soma s1;
            s1 = new Soma();

            #region Entrada
            Console.WriteLine("Digite o 1º valor: ");
            s1.setN1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o 2º valor: ");
            s1.setN2(int.Parse(Console.ReadLine()));
            #endregion

            #region Processo
            s1.calcular();
            #endregion

            #region Saída
            Console.WriteLine("Resultado da soma de {0} e {1} é {2}",
                              s1.getN1(), s1.getN2(), s1.getResultado());
            #endregion

        }
    }
}
