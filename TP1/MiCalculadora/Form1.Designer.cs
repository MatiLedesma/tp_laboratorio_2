
namespace MiCalculadora
{
	partial class FormCalculadora
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.cbxOperador = new System.Windows.Forms.ComboBox();
			this.btnOperar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnConvertBinario = new System.Windows.Forms.Button();
			this.btnConvertDecimal = new System.Windows.Forms.Button();
			this.lbxResultados = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtNum1
			// 
			this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum1.Location = new System.Drawing.Point(12, 46);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 40);
			this.txtNum1.TabIndex = 0;
			this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNum2
			// 
			this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum2.Location = new System.Drawing.Point(184, 46);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 40);
			this.txtNum2.TabIndex = 2;
			this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbxOperador
			// 
			this.cbxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxOperador.FormattingEnabled = true;
			this.cbxOperador.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
			this.cbxOperador.Location = new System.Drawing.Point(118, 46);
			this.cbxOperador.Name = "cbxOperador";
			this.cbxOperador.Size = new System.Drawing.Size(60, 41);
			this.cbxOperador.TabIndex = 1;
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(12, 105);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(86, 44);
			this.btnOperar.TabIndex = 4;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(104, 105);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(88, 44);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(198, 105);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(86, 44);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnConvertBinario
			// 
			this.btnConvertBinario.Location = new System.Drawing.Point(12, 164);
			this.btnConvertBinario.Name = "btnConvertBinario";
			this.btnConvertBinario.Size = new System.Drawing.Size(127, 44);
			this.btnConvertBinario.TabIndex = 7;
			this.btnConvertBinario.Text = "Convertir a binario";
			this.btnConvertBinario.UseVisualStyleBackColor = true;
			// 
			// btnConvertDecimal
			// 
			this.btnConvertDecimal.Location = new System.Drawing.Point(157, 164);
			this.btnConvertDecimal.Name = "btnConvertDecimal";
			this.btnConvertDecimal.Size = new System.Drawing.Size(127, 44);
			this.btnConvertDecimal.TabIndex = 8;
			this.btnConvertDecimal.Text = "Convertir a decimal";
			this.btnConvertDecimal.UseVisualStyleBackColor = true;
			// 
			// lbxResultados
			// 
			this.lbxResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbxResultados.FormattingEnabled = true;
			this.lbxResultados.ItemHeight = 25;
			this.lbxResultados.Location = new System.Drawing.Point(290, 12);
			this.lbxResultados.Name = "lbxResultados";
			this.lbxResultados.Size = new System.Drawing.Size(242, 229);
			this.lbxResultados.TabIndex = 3;
			// 
			// FormCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 256);
			this.Controls.Add(this.lbxResultados);
			this.Controls.Add(this.btnConvertDecimal);
			this.Controls.Add(this.btnConvertBinario);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.cbxOperador);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Ledesma Matías 2°A";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.ComboBox cbxOperador;
		private System.Windows.Forms.Button btnOperar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnConvertBinario;
		private System.Windows.Forms.Button btnConvertDecimal;
		private System.Windows.Forms.ListBox lbxResultados;
	}
}

