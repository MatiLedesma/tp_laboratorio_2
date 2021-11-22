using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestProductos
    {
        /// <summary>
        /// Comprueba si se ingresa el elemento al stock, y si no supera el mismo
        /// </summary>
        [TestMethod]
        public void Add_Stock_Test_True()
        {
            int cantidadStock = 2;
            Alimentos alimento_uno = new Alimentos(0, 200, "Leche", "Serenisima", TipoAlimento.no_pedecedero);
            Tecnologia tecnologia_uno = new Tecnologia(1, 1000, "Iphone", "Iphone X", TipoArtefacto.Celular);
            Stock<Producto> stock_productos = new Stock<Producto>(cantidadStock);
            stock_productos += alimento_uno;
            stock_productos += tecnologia_uno;


            Assert.AreEqual(cantidadStock, stock_productos.Stock_a.Count);
        }
        /// <summary>
        /// Comprueba si se ingresa el elemento al stock, y si no supera el mismo
        /// </summary>
        [TestMethod]
        public void Add_Stock_Test_False()
        {
            int cantidadStock = 2;
            Alimentos alimento_uno = new Alimentos(0, 200, "Leche", "Serenisima", TipoAlimento.no_pedecedero);
            Tecnologia tecnologia_uno = new Tecnologia(1, 1000, "Iphone", "Iphone X", TipoArtefacto.Celular);
            Tecnologia tecnologia_dos = new Tecnologia(2, 999, "Samsung", "Samsung S9", TipoArtefacto.Celular);
            Stock<Producto> stock_productos = new Stock<Producto>(cantidadStock + 1);
            stock_productos += alimento_uno;
            stock_productos += tecnologia_uno;
            stock_productos += tecnologia_dos;


            Assert.AreNotEqual(cantidadStock, stock_productos.Stock_a.Count);
        }
        /// <summary>
        /// Comprueba si se elimina un producto del stock
        /// </summary>
        [TestMethod]
        public void Remove_Stock_Test_True()
        {
            int cantidadStock = 2;
            int resultado = 1;
            Alimentos alimento_uno = new Alimentos(0, 200, "Leche", "Serenisima", TipoAlimento.no_pedecedero);
            Tecnologia tecnologia_uno = new Tecnologia(1, 1000, "Iphone", "Iphone X", TipoArtefacto.Celular);
            Stock<Producto> stock_productos = new Stock<Producto>(cantidadStock);
            stock_productos += alimento_uno;
            stock_productos += tecnologia_uno;
            stock_productos -= alimento_uno;

            Assert.AreEqual(resultado, stock_productos.Stock_a.Count);
        }
        /// <summary>
        /// Comprueba si se elimina un producto del stock
        /// </summary>
        [TestMethod]
        public void Remove_Stock_Test_False()
        {
            int cantidadStock = 2;
            int resultado = 1;
            Alimentos alimento_uno = new Alimentos(0, 200, "Leche", "Serenisima", TipoAlimento.no_pedecedero);
            Tecnologia tecnologia_uno = new Tecnologia(1, 1000, "Iphone", "Iphone X", TipoArtefacto.Celular);
            Tecnologia tecnologia_dos = new Tecnologia(2, 999, "Samsung", "Samsung S10", TipoArtefacto.Celular);
            Stock<Producto> stock_productos = new Stock<Producto>(cantidadStock);
            stock_productos += alimento_uno;
            stock_productos += tecnologia_uno;
            stock_productos -= alimento_uno;
            stock_productos += tecnologia_dos;

            Assert.AreNotEqual(resultado, stock_productos.Stock_a.Count);
        }
        /// <summary>
        /// Comprueba si las tecnologias ingresadas son iguales
        /// son iguales si la id y la descripcion son la misma
        /// </summary>
        [TestMethod]
        public void Compare_Tecnologia_True()
        {
            bool areEquals;
            Tecnologia tecnologia_uno = new Tecnologia(1, 1000, "Iphone", "Iphone X", TipoArtefacto.Celular);
            Tecnologia tecnologia_dos = new Tecnologia(1, 1000, "Iphone X", "Iphone X", TipoArtefacto.Celular);
            areEquals = tecnologia_uno == tecnologia_dos;

            Assert.IsTrue(areEquals);
        }
    }
}
