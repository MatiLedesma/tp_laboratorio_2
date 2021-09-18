using System;

namespace Entidades
{
	public static class Calculadora
	{
		/// <summary>
		/// Valida el operador ingresado
		/// </summary>
		/// <param name="operador">Obtiene el tipo de operador(suma, resta, multiplicacion o division</param>
		/// <returns>Devuelve el operador en caso de ser valido, si no es un operador valido devuelve "+" por defecto</returns>
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
		/// <summary>
		/// Realiza la operacion
		/// </summary>
		/// <param name="num1">Obtiene el num1 de la clase Operando</param>
		/// <param name="num2">Obtiene el num2 de la clase Operando</param>
		/// <param name="operador">Obtiene el tipo de operador para realizar la cuenta</param>
		/// <returns>Devuelve la suma, resta, multiplicacion o division realizada</returns>
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
