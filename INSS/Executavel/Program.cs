using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executavel
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaClasse = new MinhaClasse();

            minhaClasse.salario = 2000;

            minhaClasse.CalcularDesconto(2000);
            Console.WriteLine("Meu desconto é " + minhaClasse.inss);
        }
    }
}
