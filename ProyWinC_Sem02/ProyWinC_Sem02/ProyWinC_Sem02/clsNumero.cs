using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWinC_Sem02
{
    class clsNumero
    {
        private double mvarValor;
        public double Valor
        {
            get { return mvarValor; }
            set { mvarValor = value; }


        }

        public double Factorial()
        {
            double dblFact = 1;
            double z = 0;

            try
            {
                for (z = 1; z <= mvarValor; z++)
                {
                    dblFact = dblFact * z;
                }
                return dblFact;
            }
            catch (Exception ex)
            {
                throw new Exception("Valor muy grande para calcular el factorial..." + ex.Message);
            }
        }
        public bool EsPrimo()
        {
            long x = 0;
            for (x = 1; x <= mvarValor; x++)
            {
                if (x != 1 & x != mvarValor)
                {
                    if (mvarValor % x == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
