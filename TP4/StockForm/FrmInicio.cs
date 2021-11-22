using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace StockForm
{
    public partial class FrmInicio : Form
    {
        #region Atributos
        private CargarProducto cargar;
        private EliminarProducto eliminar;
        private AgregarBBDD agregar;
        private EliminarBBDD eliminarBBDD;
        private Stock<Producto> stock = new Stock<Producto>(4);
        private SerializadorXML_JSON<List<Tecnologia>> serializadorXml_tecnologia;
        private SerializadorXML_JSON<List<Alimentos>> serializadorXml_alimentos;
        private List<Tecnologia> list_tec;
        private List<Alimentos> list_alim;
        private string path_tecnologia = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stock_tecnologia.xml");
        private string path_alimentos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stock_alimentos.xml");
        #endregion
        #region Constructores
        public FrmInicio()
        {
            InitializeComponent();
            InitializeDataStock();
            this.cargar = new CargarProducto(stock);
            this.eliminar = new EliminarProducto(stock);
            this.agregar = new AgregarBBDD(stock);
            this.eliminarBBDD = new EliminarBBDD();
            this.serializadorXml_tecnologia = new SerializadorXML_JSON<List<Tecnologia>>(IArchivo<List<Tecnologia>>.ETipoArchivo.XML);
            this.serializadorXml_alimentos = new SerializadorXML_JSON<List<Alimentos>>(IArchivo<List<Alimentos>>.ETipoArchivo.XML);
            this.list_tec = new List<Tecnologia>();
            this.list_alim = new List<Alimentos>();
        }
        #endregion
        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Inicializa la cantidad de columnas y los nombres para la carga de stock
        /// </summary>
        private void InitializeDataStock()
        {
            dtStock.ColumnCount = 5;
            dtStock.Columns[0].Name = "Id";
            dtStock.Columns[1].Name = "Nombre";
            dtStock.Columns[2].Name = "Descripcion";
            dtStock.Columns[3].Name = "Tipo";
            dtStock.Columns[4].Name = "Precio";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.cargar.ShowDialog();
            if (this.cargar.DialogResult == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            this.eliminar.ShowDialog();
            if (this.eliminar.DialogResult == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnGuardarStock_Click(object sender, EventArgs e)
        {            
            try
            {
                if (this.stock.Stock_a.Count > 0)
                {
                    foreach(Producto p in this.stock.Stock_a)
                    {
                        if (p is Tecnologia)
                        {
                            this.list_tec.Add((Tecnologia)p);
                        }
                        if (p is Alimentos)
                        {
                            this.list_alim.Add((Alimentos)p);
                        }
                    }
                    this.serializadorXml_tecnologia.Escribir(this.list_tec, path_tecnologia);
                    this.serializadorXml_alimentos.Escribir(this.list_alim, path_alimentos);
                    MessageBox.Show($"Archivos guardados en \n{path_tecnologia}\n{path_alimentos}");
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un producto de cada tipo ingresado en el stock para poder guardar los archivos", "Error");
                }
            }
            catch(Exception exception)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{exception.Message}", path);
            }
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            try
            {
                this.stock.Stock_a.Clear();
                this.list_alim = new List<Alimentos>(this.serializadorXml_alimentos.Leer(this.path_alimentos));
                this.list_tec = new List<Tecnologia>(this.serializadorXml_tecnologia.Leer(this.path_tecnologia));
                foreach (Alimentos a in this.list_alim)
                {
                    this.stock.Stock_a.Add(a);
                }
                foreach(Tecnologia t in this.list_tec)
                {
                    this.stock.Stock_a.Add(t);
                }
                MessageBox.Show("Stock cargado, actualice para mostrar los cambios", "Alerta");
            }
            catch(Exception exception)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{exception.Message}", path);
            }
        }

        private void btnCBBDD_Click(object sender, EventArgs e)
        {
            this.agregar.ShowDialog();
            if (this.agregar.DialogResult == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => this.TraerDatos());
            task.Start();
        }

        #endregion
        #region Metodos
        /// <summary>
        /// Actaliza los datos en el data grid
        /// </summary>
        private void CargarDatos()
        {
            dtStock.Rows.Clear();
            foreach (Producto prod in this.stock.Stock_a)
            {
                if (prod is Alimentos)
                {
                    Alimentos ali = (Alimentos)prod;
                    string[] ali_arr = { ali.Id.ToString(), ali.Nombre, ali.Descripcion,
                            ali.TipoAlim, ali.Precio.ToString() };
                    dtStock.Rows.Add(ali_arr);
                }
                if (prod is Tecnologia)
                {
                    Tecnologia tec = (Tecnologia)prod;
                    string[] tec_arr = { tec.Id.ToString(), tec.Nombre, tec.Especificaciones,
                            tec.TipoArtef, tec.Precio.ToString() };
                    dtStock.Rows.Add(tec_arr);
                }
            }

        }
        /// <summary>
        /// Obtiene los datos de la base de datos
        /// </summary>
        private void TraerDatos()
        {
            try
            {
                Conexion conexion = new Conexion();

                this.stock.Stock_a = conexion.ObtenerProductos();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            }

        #endregion

        private void btnEBBDD_Click(object sender, EventArgs e)
        {
            this.eliminarBBDD.ShowDialog();
            if (this.eliminarBBDD.DialogResult == DialogResult.OK)
            {
                Task task = new Task(() => this.TraerDatos());
                task.Start();
            }
        }
    }
}
