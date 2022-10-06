using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DHL
    {

        public double CalculoFrete(double i)
        {
            double resultado = 8.50*i;
            return resultado;
        }
    }
}

