using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class Program
	{
		static void Main(string[] args)
		{
			Operando bin = new Operando();
			Operando num1 = new Operando(2);
			Operando num2 = new Operando("0");
			double res;

			res = Calculadora.Operar(num1, num2, '+');
			Console.WriteLine("Resultado: {0}",res);
			res = Calculadora.Operar(num1, num2, '-');
			Console.WriteLine("Resultado: {0}", res);
			res = Calculadora.Operar(num1, num2, '/');
			Console.WriteLine("Resultado: {0}", res);
			res = Calculadora.Operar(num1, num2, '*');
			Console.WriteLine("Resultado: {0}", res);

			Console.WriteLine(bin.BinarioDecimal("abv"));
			Console.WriteLine(bin.BinarioDecimal("1100"));
			Console.WriteLine(bin.BinarioDecimal("110a1"));
			Console.WriteLine(bin.DecimalBinario(121));
			Console.WriteLine(bin.DecimalBinario("1"));
			Console.ReadKey();
		}
	}
}
