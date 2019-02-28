using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Axecutavel
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaClasse = new MinhaClasse();

            minhaClasse.salario = 1000;
            minhaClasse.teto = 400;
            minhaClasse.data = DateTime.Parse("21 / 01 / 2011");

            minhaClasse.CalcularDesconto(minhaClasse.salario,minhaClasse.data);

            Console.Write("Meu desconto é "+minhaClasse.inss,+minhaClasse.teto);

            Console.ReadKey();

        }

        



    }
    
}
