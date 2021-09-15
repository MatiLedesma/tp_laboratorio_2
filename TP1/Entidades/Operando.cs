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
		public Operando()
		{
			this.numero = 0;
		}

		public Operando(double numero)
		{
			this.numero = numero;
		}

		public Operando(string numero)
		{
			this.Numero = numero;
		}
		#endregion
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

		public string DecimalBinario(double numero)
		{
			string retorno = "Valor no valido";
			string binary = Convert.ToString((int)numero, 2);
			if (EsBinario(binary) && numero > 0)
			{
				retorno = binary;
			}
			return retorno;
		}

		public string DecimalBinario(string numero)
		{
			string retorno;
			this.Numero = numero;
			retorno = DecimalBinario(this.numero);
			return retorno;
		}
		#endregion

		#region Sobrecarga de operadores
		public static double operator +(Operando n1, Operando n2)
		{
			return n1.numero + n2.numero;
		}
		public static double operator -(Operando n1, Operando n2)
		{
			return n1.numero - n2.numero;
		}
		public static double operator *(Operando n1, Operando n2)
		{
			return n1.numero * n2.numero;
		}
		public static double operator /(Operando n1, Operando n2)
		{
			return n2.numero != 0 ? n1.numero / n2.numero : double.MinValue;
		}
		#endregion

		#region Propiedades
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
