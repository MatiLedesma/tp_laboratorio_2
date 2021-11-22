using System;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// clase Alimentos que hereda de producto
    /// </summary>
    public class Alimentos : Producto
    {
        #region Atributos
        private string descripcion;
        private TipoAlimento tipoAlimento;
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad Descripcion, devuelve el valor del atributo descripcion
        /// </summary>
        public string Descripcion
        {
            get 
            { 
                return this.descripcion; 
            }
            set
            {
                this.descripcion = value;
            }
        }
        /// <summary>
        /// Propiedad TipoAlim, devuelve un string dependiendo el valor del atributo tipoAlimento 
        /// </summary>
        public string TipoAlim
        {
            get 
            { 
                return this.tipoAlimento == TipoAlimento.no_pedecedero ? "No pedecedero" : "Pedecedero"; 
            }
            set
            {
                this.tipoAlimento = value == "No pedecedero" ? TipoAlimento.no_pedecedero : TipoAlimento.pedecedero;
            }
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructo parametrizado, se usa el base para asignar los valores al producto
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="precio">precio del producto</param>
        /// <param name="nombre">nombre del producto</param>
        /// <param name="descripcion">descripcion del alimento</param>
        /// <param name="tipoAlimento">tipo de alimento</param>
        public Alimentos(int id, float precio, string nombre, string descripcion, TipoAlimento tipoAlimento) 
            : base(precio, id, nombre)
        {
            this.descripcion = descripcion;
            this.tipoAlimento = tipoAlimento;
        }
        /// <summary>
        /// Constructor sin parametro, inicializa los valores si no se llama al constructor
        /// </summary>
        public Alimentos() : this(0, 0, "", "", TipoAlimento.no_pedecedero)
        { }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo mostrar, muestra los datos del Alimento
        /// </summary>
        /// <returns>Devuelve un string con los datos del alimento</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}\t\t\t{this.descripcion}\t\t\t{TipoAlim}");
            return sb.ToString();
        }
        #endregion
        #region Polimorfismo
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (Alimentos)obj == this;
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador ==, si los productos a y b son iguales y sus descripciones son iguales 
        /// entonces los alimentos son iguales
        /// </summary>
        /// <param name="a">Alimento a</param>
        /// <param name="b">Alimento b</param>
        /// <returns>Devuelve true or false en caso de cumplir la igualdad</returns>
        public static bool operator ==(Alimentos a, Alimentos b)
        {
            return (Producto)a == (Producto)b && a.Nombre == b.Nombre;
        }
        public static bool operator !=(Alimentos a, Alimentos b)
        {
            return !(a == b);
        }
        #endregion
    }
}
