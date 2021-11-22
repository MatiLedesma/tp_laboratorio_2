using System;
using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        private float precio;
        private int id;
        private string nombre;
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad Precio, devuelve el valor del atributo precio
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        /// <summary>
        /// Propiedad Id, devuelve el valor del atributo id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        /// <summary>
        /// Propiedad Nombre, devuelve el valor del atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor producto parametrizado, asigna el valor a los atributos de la clase
        /// </summary>
        /// <param name="precio">El precio del producto</param>
        /// <param name="id">El id del producto</param>
        /// <param name="nombre">El nombre del producto</param>
        public Producto(float precio, int id, string nombre)
        {
            this.precio = precio;
            this.id = id;
            this.nombre = nombre;
        }
        /// <summary>
        /// Contructor producto sin parametros, 
        /// inicializa los valores en caso de no ser inicializados
        /// </summary>
        public Producto() : this(0, 0, "")
        { }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo Mostrar(), crea una cadena con los datos del producto ingresado
        /// </summary>
        /// <returns>Devuelve la cadena creada</returns>
        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{p.id}\t\t\t{p.nombre}\t\t\t${p.precio}");
            return sb.ToString();
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador igual, si los productos tienen la misma id son iguales
        /// </summary>
        /// <param name="a">Producto a</param>
        /// <param name="b">Producto b</param>
        /// <returns>Devuelve true de ser iguales</returns>
        public static bool operator ==(Producto a, Producto b)
        {
            return a.id == b.id;
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        #endregion
        #region Polimorfismo
        /// <summary>
        /// Override del ToString, llama al metodo Mostrar cuando se haga .toString()
        /// </summary>
        /// <returns>Devuelve la cadena creada por el metodo Mostrar</returns>
        public override string ToString()
        {
            return Mostrar(this);
        }
        /// <summary>
        /// Override del equals
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>Devuelve true o false dependiendo si el objeto es igual al de la clase</returns>
        public override bool Equals(object obj)
        {
            return (Producto)obj == this;
        }
        #endregion
    }
}
