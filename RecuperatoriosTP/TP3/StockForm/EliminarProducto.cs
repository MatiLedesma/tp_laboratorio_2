using System;
using System.Windows.Forms;
using Entidades;

namespace StockForm
{
    public partial class EliminarProducto : Form
    {
        #region Atributos
        private Stock<Producto> stock = null;
        #endregion

        #region Constructores
        public EliminarProducto()
        {
            InitializeComponent();
        }
        public EliminarProducto(Stock<Producto> stock) : this()
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoAlimento tipoAlimento;
            TipoArtefacto tipoArtefacto;
            try
            {
                foreach(Producto p in this.stock.Stock_a)
                {
                    Alimentos ali;
                    Tecnologia tecno;
                    if (int.Parse(txtId.Text) == p.Id && txtDescripcion.Text == p.Nombre)
                    {
                        if (p is Alimentos)
                        {
                            Alimentos a = (Alimentos)p;
                            tipoAlimento = a.TipoAlim == "Pedecedero" ? TipoAlimento.pedecedero : TipoAlimento.no_pedecedero;
                            ali = new Alimentos(a.Id, a.Precio, a.Nombre, a.Descripcion, tipoAlimento);
                            break;
                        }
                        if (p is Tecnologia)
                        {
                            Tecnologia a = (Tecnologia)p;
                            tipoArtefacto = a.TipoArtef == "Celular" ? TipoArtefacto.Celular :
                                   a.TipoArtef == "Computadora" ? TipoArtefacto.Computadora :
                                   a.TipoArtef == "Televisor" ? TipoArtefacto.Televisor : TipoArtefacto.Monitor;
                            tecno = new Tecnologia(a.Id, a.Precio, a.Nombre, a.Especificaciones, tipoArtefacto);
                            break;
                        }

                    }
                    /*if (p is Alimentos)
                    {
                        Alimentos a = (Alimentos)p;
                        if (int.Parse(txtId.Text) == a.Id && a.Nombre == txtDescripcion.Text)
                        {
                            tipoAlimento = a.TipoAlim == "Pedecedero" ? TipoAlimento.pedecedero : TipoAlimento.no_pedecedero;
                            prod = new Alimentos(a.Id, a.Precio, a.Nombre, a.Descripcion, tipoAlimento);
                        }
                    }
                    if (p is Tecnologia)
                    {
                        Tecnologia a = (Tecnologia)p;
                        if (int.Parse(txtId.Text) == a.Id && a.Nombre == txtDescripcion.Text)
                        {
                            tipoArtefacto = a.TipoArtef == "Celular" ? TipoArtefacto.Celular :
                                a.TipoArtef == "Computadora" ? TipoArtefacto.Computadora :
                                a.TipoArtef == "Televisor" ? TipoArtefacto.Televisor : TipoArtefacto.Monitor;
                            prod = new Tecnologia(a.Id, a.Precio, a.Nombre, a.Especificaciones, tipoArtefacto);
                        }
                    }*/
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        #endregion
    }
}
