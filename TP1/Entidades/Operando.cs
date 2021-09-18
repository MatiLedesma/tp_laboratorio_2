using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Operando
	{
		private double numero;

		#region Constructor
		/// <summary>
		/// Constructor operando sin parametros
		/// </summary>
		public Operando()
		{
			this.numero = 0;
		}
		/// <summary>
		/// Constructor operando con parametros
		/// </summary>
		/// <param name="numero">Obtiene el numero</param>
		public Operando(double numero)
		{
			this.numero = numero;
		}
		/// <summary>
		/// Constructor operando con parametros
		/// </summary>
		/// <param name="numero">Obtiene el numero en string</param>
		public Operando(string numero)
		{
			this.Numero = numero;
		}
		#endregion
		/// <summary>
		/// Valida si la operacion es valida
		/// </summary>
		/// <param name="strNumero">Obtiene el numero en string</param>
		/// <returns>Devuelve el numero si es valido, de no ser valido devuelve 0</returns>
		private double ValidarOperando(string strNumero)
		{
			double num = 0;
			double oResult = 0;
			if (double.TryParse(strNumero, out oResult))
			{
				num = double.Parse(strNumero);
			}
			return num;
		}
		#region Metodos
		/// <summary>
		/// Verifica si el numero ingresado es binario
		/// </summary>
		/// <param name="binario">Obtiene el string binario</param>
		/// <returns>Devuelve true o false en caso de ser o no ser binario</returns>
		private bool EsBinario(string binario)
		{
			int contC = 0;
			foreach (char c in binario)
			{
				if (c == '0' || c == '1')
				{
					contC++;
				}
			}

			return contC == binario.Length;
		}
		/// <summary>
		/// Convierte un numero binario a decimal
		/// </summary>
		/// <param name="binario">Obtiene el string binario</param>
		/// <returns>Devuelve el numero transformado en decimal, en caso de no ser posible devuelve "valor no valido"</returns>
		public string BinarioDecimal(string binario)
		{
			int numero;
			string retorno = "Valor no valido";
			if (EsBinario(binario))
			{
				numero = Convert.ToInt32(binario, 2);
				retorno = Math.Abs(numero).ToString();
			}
			return retorno;
		}
		/// <summary>
		/// Convierte un numero de decimal a binario
		/// </summary>
		/// <param name="numero">Obtiene el numero a ser convertido</param>
		/// <returns>Devuelve el numero transformado a binario, en caso de no ser posible devuelve "valor no valido"</returns>
		public string DecimalBinario(double numero)
		{
			string retorno = "Valor no valido";
			if (!EsBinario(numero.ToString()))
			{
				string binary = Convert.ToString((int)numero, 2);
				if (EsBinario(binary) && numero > 0)
				{
					retorno = binary;
				}

			}
			return retorno;
		}
		/// <summary>
		/// Convierte un numero de decimal a binario 
		/// </summary>
		/// <param name="numero">Obtiene el numero en string a ser convertido</param>
		/// <returns>Devuelve el numero transformado a binario, en caso de no ser posible devuelve "valor no valido"</returns>
		public string DecimalBinario(string numero)
		{
			string retorno;
			this.Numero = numero;
			retorno = DecimalBinario(this.numero);
			return retorno;
		}
		#endregion

		#region Sobrecarga de operadores
		/// <summary>
		/// Sobrecarga del operador +
		/// </summary>
		/// <param name="n1">Obtiene el primer numero</param>
		/// <param name="n2">Obtiene el segundo numero</param>
		/// <returns>Devuelve la suma de los dos numeros</returns>
		public static double operator +(Operando n1, Operando n2)
		{
			return n1.numero + n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador -
		/// </summary>
		/// <param name="n1">Obtiene el primer numero</param>
		/// <param name="n2">Obtiene el segundo numero</param>
		/// <returns>Devuelve la resta de los dos numeros</returns>
		public static double operator -(Operando n1, Operando n2)
		{
			return n1.numero - n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador *
		/// </summary>
		/// <param name="n1">Obtiene el primer numero</param>
		/// <param name="n2">Obtiene el segundo numero</param>
		/// <returns>Devuelve la multiplicacion de los dos numeros</returns>
		public static double operator *(Operando n1, Operando n2)
		{
			return n1.numero * n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador +
		/// </summary>
		/// <param name="n1">Obtiene el primer numero</param>
		/// <param name="n2">Obtiene el segundo numero</param>
		/// <returns>Devuelve la division de los dos numeros</returns>
		public static double operator /(Operando n1, Operando n2)
		{
			return n2.numero != 0 ? n1.numero / n2.numero : double.MinValue;
		}
		#endregion

		#region Propiedades
		/// <summary>
		/// Propiedad numero, valida y asigna el operando al atributo numero
		/// </summary>
		private string Numero
		{
			set
			{
				this.numero = ValidarOperando(value);
			}
		}
		#endregion
	}
}
