using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class Conexion
    {
        #region Atributos
        private static string datos_conexion;
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataReader dataReader;
        #endregion
        #region Constructores
        static Conexion()
        {
            Conexion.datos_conexion = @"Server=matias;Database=LedesmaMatias_TP4_Stock;Trusted_Connection=True;";
        }
        /// <summary>
        /// Hace la conexión a la base de datos
        /// </summary>
        public Conexion()
        {
            this.conexion = new SqlConnection(Conexion.datos_conexion);
        }
        #endregion
        #region Metodos

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            List<Alimentos> alimentos = new List<Alimentos>();
            List<Tecnologia> tecnologias = new List<Tecnologia>();
            try
            {
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM dbo.productos";
                this.command.Connection = this.conexion;

                this.conexion.Open();
                this.dataReader = this.command.ExecuteReader();

                while(this.dataReader.Read())
                {
                    Alimentos ali = new Alimentos();

                    ali.Id = int.Parse(this.dataReader["id"].ToString());
                    ali.Nombre = this.dataReader["nombre"].ToString();
                    ali.Descripcion = this.dataReader["descripcion"].ToString();
                    ali.Precio = float.Parse(this.dataReader["precio"].ToString());
                    ali.TipoAlim = this.dataReader["tipo"].ToString();

                    alimentos.Add(ali);
                }
                this.conexion.Close();
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM dbo.tecnologia";
                this.command.Connection = this.conexion;

                this.conexion.Open();
                this.dataReader = this.command.ExecuteReader();


                while (this.dataReader.Read())
                {
                    Tecnologia tec = new Tecnologia();

                    tec.Id = int.Parse(this.dataReader["id"].ToString());
                    tec.Nombre = this.dataReader["nombre"].ToString();
                    tec.Especificaciones = this.dataReader["descripcion"].ToString();
                    tec.Precio = float.Parse(this.dataReader["precio"].ToString());
                    tec.TipoArtef = this.dataReader["tipo"].ToString();

                    tecnologias.Add(tec);
                }

                foreach(Alimentos a in alimentos)
                {
                    productos.Add(a);
                }
                foreach(Tecnologia t in tecnologias)
                {
                    productos.Add(t);
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return productos;
        }

        public bool AgregarAlimento(Alimentos alimentos)
        {
            bool status = false;
            try
            {
                string query = $"INSERT INTO dbo.productos (id, nombre, descripcion, tipo, precio) VALUES ({alimentos.Id}, '{alimentos.Nombre}', '{alimentos.Descripcion}', '{alimentos.TipoAlim}', {alimentos.Precio})";
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = query;
                this.command.Connection = this.conexion;

                this.conexion.Open();

                int rowsChange = this.command.ExecuteNonQuery();
                if (rowsChange != 0)
                {
                    status = true;
                }

            }
            catch(Exception e)
            {
                throw new Exception($"{e.Message}\n{e.StackTrace}");
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return status;
        }
        public bool AgregarTecnologia(Tecnologia tecnologia)
        {
            bool status = false;
            try
            {
                string query = $"INSERT INTO dbo.tecnologia (id, nombre, descripcion, tipo, precio) VALUES ({tecnologia.Id}, '{tecnologia.Nombre}', '{tecnologia.Especificaciones}', '{tecnologia.TipoArtef}', {tecnologia.Precio})";
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = query;
                this.command.Connection = this.conexion;
                this.conexion.Open();

                int rowsChange = this.command.ExecuteNonQuery();
                if (rowsChange != 0)
                {
                    status = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}\n{e.StackTrace}");
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return status;
        }

        #endregion
    }
}
