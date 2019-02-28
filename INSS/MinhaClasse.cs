using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class MinhaClasse : ICalculadorInss
    {
        public decimal salario { get; set; }
        public decimal inss { get; set; }
        public decimal teto { get; set; } 

      
        public decimal CalcularDesconto( decimal salario)
        {
    
            if (salario >= 1000 )
            {
                this.inss = this.salario * 008;
            }
            else if(salario >=1500 && salario >= 3000)
            {
                inss = salario * 0012;
            }if(salario >= 4000)
            {
                salario = teto;
            }


            return inss;
        }
    }
}
