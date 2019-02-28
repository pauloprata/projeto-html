using System;

public class Pessoa:ICacluladoraInss
{
    private decimal salario;
    private String name;

	public Pessoa()
	{
	}

    decimal CalcularDesconto(DateTime data, decimal salario)
    {
      if(salario > 1000)
        {
            salario = salario * 0.8;
            data = data;
        }
    }
}
