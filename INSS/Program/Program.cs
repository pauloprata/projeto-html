using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaClasse = new MinhaClasse();
            

            minhaClasse.salario = 2000;

            minhaClasse.CalcularDesconto(2000);
            Console.WriteLine("Meu desconto é" );
        }
    }
}
