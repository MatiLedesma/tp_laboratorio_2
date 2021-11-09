using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
	public partial class MiCalculadora : Form
	{
		public MiCalculadora()
		{
			InitializeComponent();
		}

		private void btnOperar_Click(object sender, EventArgs e)
		{
			double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cbxOperadores.SelectedItem.ToString());
			string operador = cbxOperadores.SelectedItem.ToString() == " " ? "+" : cbxOperadores.SelectedItem.ToString();
			string num1 = txtNumero1.Text == " " ? "0" : txtNumero1.Text;
			string num2 = txtNumero2.Text == " " ? "0" : txtNumero2.Text;
			if (resultado != Double.MinValue)
			{
				lstOperaciones.Items.Add(num1 + " " + operador + " " + num2 + " = " + resultado);
				lblBinary.Text = resultado.ToString();
			}
			else
			{
				lstOperaciones.Items.Add(num1 + " " + operador + " " + num2 + " = Syntax error");
				lblBinary.Text = "Syntax error";
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnConvertirBinario_Click(object sender, EventArgs e)
		{
			string result = "";
			if (lblBinary.Text != "" || lblBinary.Text != "Syntax error")
            {
				result = lblBinary.Text;
            }
			Operando bin = new Operando();
			string resultadoBin = bin.DecimalBinario(result);
			lblBinary.Text = resultadoBin;
			lstOperaciones.Items.Add(resultadoBin);
		}

		private void btnConvertirDecimal_Click(object sender, EventArgs e)
		{
			string result = "";
			if (lblBinary.Text != "" || lblBinary.Text != "Syntax error")
			{
				result = lblBinary.Text;
			}
			Operando bin = new Operando();
			string resultado = bin.BinarioDecimal(result);
			lblBinary.Text = resultado;
			lstOperaciones.Items.Add(resultado);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Limpiar();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Limpiar();
		}

		private void Limpiar()
		{
			txtNumero1.Text = "";
			txtNumero2.Text = "";
			lblBinary.Text = "0";
			cbxOperadores.SelectedIndex = 0;
			lstOperaciones.Items.Clear();
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

        private void MiCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
			DialogResult result = MessageBox.Show("¿Seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}
    }
}
