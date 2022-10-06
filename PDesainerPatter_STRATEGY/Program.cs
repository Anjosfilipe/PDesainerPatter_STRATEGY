using System;
using Services;

namespace PDesainerPatter_STRATEGY
{
    internal class Program
    {
        static double CaluloFrete(string servico,double peso)
        {
            double ValorTotal = 0;

            if (servico == "CORREIO")
            {
                Correiros correiros = new();
                ValorTotal = correiros.CalculoFrete(peso);
            }else if (servico == "DHL")
            {
                DHL dhl = new();
                ValorTotal = dhl.CalculoFrete(peso);
            }else if (servico == "INDEX")
            {
                INDEX index = new();
                ValorTotal = index.CalculoFrete(peso);
            }else if (servico == "JADLOG")
            {
                JADLOG jadlog = new();
                ValorTotal = jadlog.CalculoFrete(peso);
            }
            else
            {
                Console.WriteLine("Seriço selecionado invalido!");
            }

            return ValorTotal;
        }

        static void Main()
        {
            Console.WriteLine("Informe o serviço desejado de frete:");
            Console.WriteLine(" - CORREIO\n - DHL\n - INDEX\n - JADLOG");
            string servico  = Console.ReadLine();
            Console.WriteLine("Informe o peso da mercadoria");
            double peso = double.Parse(Console.ReadLine());

            double resultado = CaluloFrete(servico,peso);

            Console.WriteLine("O valor ficou em $" + resultado);

        }
    }
}
