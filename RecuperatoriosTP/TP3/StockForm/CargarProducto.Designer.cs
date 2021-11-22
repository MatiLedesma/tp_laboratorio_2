
namespace StockForm
{
    partial class CargarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbAlimento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTecnologia = new System.Windows.Forms.RadioButton();
            this.cbxAlimento = new System.Windows.Forms.ComboBox();
            this.cbxTecnologia = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(275, 42);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(275, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(179, 23);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(108, 99);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(179, 23);
            this.txtPrecio.TabIndex = 8;
            // 
            // rbAlimento
            // 
            this.rbAlimento.AutoSize = true;
            this.rbAlimento.Checked = true;
            this.rbAlimento.Location = new System.Drawing.Point(30, 22);
            this.rbAlimento.Name = "rbAlimento";
            this.rbAlimento.Size = new System.Drawing.Size(74, 19);
            this.rbAlimento.TabIndex = 10;
            this.rbAlimento.TabStop = true;
            this.rbAlimento.Text = "Alimento";
            this.rbAlimento.UseVisualStyleBackColor = true;
            this.rbAlimento.CheckedChanged += new System.EventHandler(this.rbAlimento_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTecnologia);
            this.groupBox1.Controls.Add(this.rbAlimento);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Producto";
            // 
            // rbTecnologia
            // 
            this.rbTecnologia.AutoSize = true;
            this.rbTecnologia.Location = new System.Drawing.Point(30, 47);
            this.rbTecnologia.Name = "rbTecnologia";
            this.rbTecnologia.Size = new System.Drawing.Size(82, 19);
            this.rbTecnologia.TabIndex = 11;
            this.rbTecnologia.Text = "Tecnologia";
            this.rbTecnologia.UseVisualStyleBackColor = true;
            this.rbTecnologia.CheckedChanged += new System.EventHandler(this.rbTecnologia_CheckedChanged);
            // 
            // cbxAlimento
            // 
            this.cbxAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlimento.FormattingEnabled = true;
            this.cbxAlimento.Items.AddRange(new object[] {
            "Pedecedero",
            "No pedecedero"});
            this.cbxAlimento.Location = new System.Drawing.Point(12, 215);
            this.cbxAlimento.Name = "cbxAlimento";
            this.cbxAlimento.Size = new System.Drawing.Size(275, 23);
            this.cbxAlimento.TabIndex = 12;
            // 
            // cbxTecnologia
            // 
            this.cbxTecnologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTecnologia.FormattingEnabled = true;
            this.cbxTecnologia.Items.AddRange(new object[] {
            "Celular",
            "Televisor",
            "Computadora",
            "Monitor"});
            this.cbxTecnologia.Location = new System.Drawing.Point(12, 215);
            this.cbxTecnologia.Name = "cbxTecnologia";
            this.cbxTecnologia.Size = new System.Drawing.Size(275, 23);
            this.cbxTecnologia.TabIndex = 13;
            this.cbxTecnologia.Visible = false;
            // 
            // CargarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 376);
            this.Controls.Add(this.cbxTecnologia);
            this.Controls.Add(this.cbxAlimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbAlimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTecnologia;
        private System.Windows.Forms.ComboBox cbxAlimento;
        private System.Windows.Forms.ComboBox cbxTecnologia;
    }
}