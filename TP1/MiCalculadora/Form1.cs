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
			txtNum1.Text = "";
			txtNum2.Text = "";
			cbxOperador.SelectedIndex = 0;
			lbxResultados.Items.Clear();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnOperar_Click(object sender, EventArgs e)
		{
			string tNum1 = txtNum1.Text;
			string tNum2 = txtNum2.Text;
			string op = cbxOperador.SelectedItem.ToString();
			char operando = '+';
			foreach (char c in op)
			{
				operando = c;
			}
			Operando num1 = new Operando(tNum1);
			Operando num2 = new Operando(tNum2);
			lbxResultados.Items.Add(tNum1 + " " + operando + " " + tNum2 + " = " + Calculadora.Operar(num1, num2, operando));
		}
	}
}
