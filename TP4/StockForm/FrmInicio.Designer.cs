
namespace StockForm
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCargarStock = new System.Windows.Forms.Button();
            this.btnGuardarStock = new System.Windows.Forms.Button();
            this.dtStock = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGBBDD = new System.Windows.Forms.Button();
            this.btnCBBDD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 33);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(433, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(203, 36);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar producto";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(433, 54);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(203, 36);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCargarStock
            // 
            this.btnCargarStock.Location = new System.Drawing.Point(433, 138);
            this.btnCargarStock.Name = "btnCargarStock";
            this.btnCargarStock.Size = new System.Drawing.Size(203, 36);
            this.btnCargarStock.TabIndex = 4;
            this.btnCargarStock.Text = "Cargar stock";
            this.btnCargarStock.UseVisualStyleBackColor = true;
            this.btnCargarStock.Click += new System.EventHandler(this.btnCargarStock_Click);
            // 
            // btnGuardarStock
            // 
            this.btnGuardarStock.Location = new System.Drawing.Point(433, 96);
            this.btnGuardarStock.Name = "btnGuardarStock";
            this.btnGuardarStock.Size = new System.Drawing.Size(203, 36);
            this.btnGuardarStock.TabIndex = 5;
            this.btnGuardarStock.Text = "Guardar stock";
            this.btnGuardarStock.UseVisualStyleBackColor = true;
            this.btnGuardarStock.Click += new System.EventHandler(this.btnGuardarStock_Click);
            // 
            // dtStock
            // 
            this.dtStock.AllowUserToAddRows = false;
            this.dtStock.AllowUserToDeleteRows = false;
            this.dtStock.AllowUserToResizeRows = false;
            this.dtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStock.Location = new System.Drawing.Point(12, 12);
            this.dtStock.Name = "dtStock";
            this.dtStock.RowTemplate.Height = 25;
            this.dtStock.Size = new System.Drawing.Size(412, 343);
            this.dtStock.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(433, 264);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGBBDD
            // 
            this.btnGBBDD.Location = new System.Drawing.Point(433, 180);
            this.btnGBBDD.Name = "btnGBBDD";
            this.btnGBBDD.Size = new System.Drawing.Size(203, 36);
            this.btnGBBDD.TabIndex = 9;
            this.btnGBBDD.Text = "Guardar Stock BBDD";
            this.btnGBBDD.UseVisualStyleBackColor = true;
            // 
            // btnCBBDD
            // 
            this.btnCBBDD.Location = new System.Drawing.Point(433, 222);
            this.btnCBBDD.Name = "btnCBBDD";
            this.btnCBBDD.Size = new System.Drawing.Size(203, 36);
            this.btnCBBDD.TabIndex = 8;
            this.btnCBBDD.Text = "Cargar Stock BBDD";
            this.btnCBBDD.UseVisualStyleBackColor = true;
            this.btnCBBDD.Click += new System.EventHandler(this.btnCBBDD_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 367);
            this.Controls.Add(this.btnGBBDD);
            this.Controls.Add(this.btnCBBDD);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtStock);
            this.Controls.Add(this.btnGuardarStock);
            this.Controls.Add(this.btnCargarStock);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCargarStock;
        private System.Windows.Forms.Button btnGuardarStock;
        private System.Windows.Forms.DataGridView dtStock;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGBBDD;
        private System.Windows.Forms.Button btnCBBDD;
    }
}

