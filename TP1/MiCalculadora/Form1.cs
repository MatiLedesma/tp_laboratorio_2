using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
	public partial class FormCalculadora : Form
	{
		public FormCalculadora()
		{
			InitializeComponent();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Limpiar();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes) Application.Exit();
		}

		private void btnOperar_Click(object sender, EventArgs e)
		{
			double resultado = Operar(txtNum1.Text, txtNum2.Text, cbxOperador.SelectedItem.ToString());
			lbxResultados.Items.Add(txtNum1.Text + " " + cbxOperador.SelectedItem.ToString() + " " + txtNum2.Text + " = " + resultado);
		}

		private void btnConvertBinario_Click(object sender, EventArgs e)
		{
			string dec = lbxResultados.SelectedItem.ToString();
			string[] resultado = dec.Split(' ');
			string result = "";
			foreach (string c in resultado)
			{
				result = c;
			}
			Operando bin = new Operando();
			string resultadoBin = bin.DecimalBinario(result);
			lblBinary.Text = resultadoBin;
			lbxResultados.Items.Add(resultadoBin);

		}

		private void btnConvertDecimal_Click(object sender, EventArgs e)
		{
			string binary = lbxResultados.SelectedItem.ToString();
			Operando bin = new Operando();
			string resultado = bin.BinarioDecimal(binary);
			lblBinary.Text = resultado;
			lbxResultados.Items.Add(resultado);
			
		}

		private void Limpiar()
		{
			txtNum1.Text = "";
			txtNum2.Text = "";
			lblBinary.Text = "0";
			cbxOperador.SelectedIndex = 0;
			lbxResultados.Items.Clear();
		}

		private static double Operar(string numero1, string numero2, string operando)
		{
			double resultado;
			char opr = '+';
			foreach (char c in operando)
			{
				opr = c;
			}
			Operando num1 = new Operando(numero1);
			Operando num2 = new Operando(numero2);
			resultado = Calculadora.Operar(num1, num2, opr);
			return resultado;
		}

		private void FormCalculadora_Load(object sender, EventArgs e)
		{
			this.Limpiar();
		}
	}
}
