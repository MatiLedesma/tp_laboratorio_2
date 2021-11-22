using System;
using System.Windows.Forms;
using Entidades;

namespace StockForm
{
    public partial class AgregarBBDD : Form
    {
        #region Atributos
        Stock<Producto> stock;
        #endregion
        public Stock<Producto> Stock
        {
            set
            {
                this.stock = value;
            }
            get
            {
                return this.stock;
            }

        }
        public AgregarBBDD()
        {
            InitializeComponent();
        }

        public AgregarBBDD(Stock<Producto> stock) : this()
        {
            this.stock = stock;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                Producto prod = null;
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                float precio = float.Parse(txtPrecio.Text);

                if (rbTecnologia.Checked)
                {
                    string tipoArt = cbxTecnologia.Text;
                    TipoArtefacto tipoArtefacto = tipoArt == "Celular" ? TipoArtefacto.Celular :
                        tipoArt == "Televisor" ? TipoArtefacto.Televisor : tipoArt == "Computadora" ?
                        TipoArtefacto.Computadora : TipoArtefacto.Monitor;
                    prod = new Tecnologia(id, precio, nombre, descripcion, tipoArtefacto);
                    conexion.AgregarTecnologia((Tecnologia)prod);
                }
                if (rbAlimento.Checked)
                {
                    string tipoAli = cbxAlimento.Text;
                    TipoAlimento tipoAlimento = tipoAli == "Pedecedero" ? TipoAlimento.pedecedero : TipoAlimento.no_pedecedero;
                    prod = new Alimentos(id, precio, nombre, descripcion, tipoAlimento);
                    conexion.AgregarAlimento((Alimentos)prod);
                }

                this.stock += prod;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            finally
            {
                this.Close();
                this.txtId.Text = "";
                this.txtNombre.Text = "";
                this.txtDescripcion.Text = "";
                this.txtPrecio.Text = "";
                this.DialogResult = DialogResult.OK;
            }
        }

        #region Metodos
        private void CheckTipoAlimStatus()
        {
            if (rbTecnologia.Checked)
            {
                cbxAlimento.Visible = false;
                cbxTecnologia.Visible = true;
            }
            else
            {
                cbxAlimento.Visible = true;
                cbxTecnologia.Visible = false;
            }
        }
        #endregion

        private void rbAlimento_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoAlimStatus();
        }

        private void rbTecnologia_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoAlimStatus();
        }
    }
}
