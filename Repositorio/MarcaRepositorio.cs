using System.Collections.Generic;
using System.IO;
using AppEstacionamento.Models;

namespace AppEstacionamento.Repositorio
{
    public class MarcaRepositorio
    {
      private const string PATH = "DataBase/Marcas.csv";

        private List<Marca> Marcas = new List<Marca>();

        public List<Marca> Listar()
        {
            var registro = File.ReadAllLines(PATH);
            Marca marca;
            foreach (var item in registro)
            {
                var valores =  item.Split(";");
                 marca = new Marca();
                marca.NomeDaMarca = valores[1];
                
                Marcas.Add(marca);


            }
            return Marcas;
        }  
    }
}