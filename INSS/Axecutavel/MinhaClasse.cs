using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axecutavel
{
    class MinhaClasse: ICalculadorInss
    {
        public decimal salario { get; set; }
        public decimal inss { get; set; }
        public decimal teto { get; set; }
        public DateTime data;


        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
           

            if (salario >= 1000 )
            {
                this.inss = this.salario * ((decimal)8/ 100);
                data = DateTime.Parse("21 / 01 / 2011");
            }
            else if (salario <= 1107 && salario >= 1845)
            {
                inss = salario * ((decimal)9 / 100);
                data = DateTime.Parse("01 / 01 / 2011");
            }
            if (salario <= 1845 && salario <= 3689)
            {
                inss = salario * ((decimal)11 / 100);
                data = DateTime.Parse("21 / 01 / 2011");
            }
            else if (salario >=400)
            {
                salario = salario + teto;
                data = DateTime.Parse("21 / 01 / 2011");
            }


            return salario;
        }
    
}
}
