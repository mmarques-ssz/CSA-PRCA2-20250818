using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Soma // CLASSE DO NEGÓCIO
    {
        #region Atributos
        private int n1;
        private int n2;
        private int resultado;
        #endregion

        #region Setter's & Getter's
        public void setN1(int n)
        {
            n1 = n;
        }

        public void setN2(int n)
        {
            n2 = n;
        }

        public int getN1()
        {
            return n1;
        }

        public int getN2()
        {
            return n2;
        }

        public int getResultado()
        {
            return resultado;
        }
        #endregion

        #region Métodos funcionais
        public void calcular()
        {
            resultado = n1 + n2;
        }
        #endregion
    }
}
