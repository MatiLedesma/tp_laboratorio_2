using System;
using Entidades;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            try
            {
                Alimentos ali = new Alimentos(0, 123f, "Leche", "Leche Descremada la serenisima", TipoAlimento.no_pedecedero);
                Alimentos ali_dos = new Alimentos(3, 123f, "Yogurt", "Yogurt la serenisima", TipoAlimento.no_pedecedero);
                Tecnologia tec = new Tecnologia(1, 12100f, "Iphone X", "Iphone X de 256gb, 16gb de RAM", TipoArtefacto.Celular);
                Tecnologia tec_dos = new Tecnologia(2, 12000f, "Iphone 11", "Iphone 11 de 256gb, 16gb de RAM", TipoArtefacto.Celular);
                Stock<Producto> stock = new Stock<Producto>(12);

                stock += ali;
                //stock += ali; // no se agrega, tira una exepcion
                stock += ali_dos;
                stock += tec;
                stock += tec_dos;
                Console.WriteLine("\nID\t\t\tNombre\t\t\tPrecio\t\t\tDesc/Espec\t\t\tTipo");
                Console.WriteLine(stock.Mostrar());

                Console.WriteLine("\nRemuevo el primer alimento");
                stock -= ali;
                Console.WriteLine("ID\t\t\tNombre\t\t\tPrecio\t\t\tDesc/Espec\t\t\tTipo");
                Console.WriteLine(stock.Mostrar() + "\n");

                // Creo un archivo .xml y lo leo
                try
                {
                    SerializadorXML_JSON<Alimentos> serializador = new SerializadorXML_JSON<Alimentos>(IArchivo<Alimentos>.ETipoArchivo.XML);
                    serializador.Escribir(ali, "alimentos.xml");
                    
                    Alimentos ali_leer = serializador.Leer("alimentos.xml");
                    Console.WriteLine($"Leer archivo .xml: \nNombre: {ali_leer.Nombre} -- Tipo: {ali_leer.Descripcion}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // Creo un archivo .json y trato de leerlo
                try
                {
                    SerializadorXML_JSON<Alimentos> serializador_json = new SerializadorXML_JSON<Alimentos>(IArchivo<Alimentos>.ETipoArchivo.JSON);
                    serializador_json.Escribir(ali, "alimentos.xml");
                    Alimentos ali_leer = serializador_json.Leer("alimentos.xml");
                    Console.WriteLine($"Leer archivo .xml: \nNombre: {ali_leer.Nombre} -- Tipo: {ali_leer.Descripcion}");
                }
                catch (Exception e) // lanza excepcion por no ser el formato especificado
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch(Exception e) // en caso de surgir un error se genera un log
            {
                Console.WriteLine($"\n\n{e.Message}");
                archivo.Escribir(e.Message, "error.log");
            }
        }
    }
}
