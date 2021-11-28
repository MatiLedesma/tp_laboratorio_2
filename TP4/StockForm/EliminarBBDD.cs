using Entidades;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockForm
{
    public partial class EliminarBBDD : Form
    {
        #region Atributos
        private Stock<Producto> stock = null;
        #endregion
        #region Constructores
        public EliminarBBDD()
        {
            InitializeComponent();
        }
        public EliminarBBDD(Stock<Producto> stock) : this()
        {
            this.stock = stock;
        }
        #endregion

        private void EliminarBBDD_Load(object sender, EventArgs e)
        {            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                if (cbxTipo.Text == "Alimento")
                {
                    conexion.EliminarAlimento(int.Parse(txtId.Text));
                }
                else
                {
                    conexion.EliminarTecnologia(int.Parse(txtId.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Close();
                this.txtId.Text = "";
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
