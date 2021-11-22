using System;
using System.Windows.Forms;
using Entidades;


namespace StockForm
{
    public partial class CargarProducto : Form
    {
        #region Atributos
        Stock<Producto> stock;
        #endregion
        #region Propiedades
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
        #endregion
        #region Constructores
        public CargarProducto()
        {
            InitializeComponent();
        }

        public CargarProducto(Stock<Producto> stock) : this()
        {
            this.stock = stock;
        }
        #endregion
        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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
                }
                if (rbAlimento.Checked)
                {
                    string tipoAli = cbxAlimento.Text;
                    TipoAlimento tipoAlimento = tipoAli == "Pedecedero" ? TipoAlimento.pedecedero : TipoAlimento.no_pedecedero;
                    prod = new Alimentos(id, precio, nombre, descripcion, tipoAlimento);
                }

                this.stock += prod;
            }
            catch(Exception exception)
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

        private void rbTecnologia_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoAlimStatus();
        }
        private void rbAlimento_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoAlimStatus();
        }
        #endregion
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
    }
}
