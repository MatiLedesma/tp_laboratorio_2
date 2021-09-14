using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public static class Calculadora
	{
		private static char ValidarOperando(char operador)
		{
			char retorno;
			switch (operador)
			{
				case '+':
					retorno = operador;
					break;
				case '-':
					retorno = operador;
					break;
				case '*':
					retorno = operador;
					break;
				case '/':
					retorno = operador;
					break;
				default:
					retorno = '+';
					break;
			}
			return retorno;
		}

		public static double Operar(Operando num1, Operando num2, char operador)
		{
			char op;
			double resultado = 0;
			op = ValidarOperando(operador);

			switch (op)
			{
				case '+':
					resultado = num1 + num2;
					break;
				case '-':
					resultado = num1 - num2;
					break;
				case '*':
					resultado = num1 * num2;
					break;
				case '/':
					resultado = num1 / num2;
					break;
			}
			return resultado;
		}
	}
}
