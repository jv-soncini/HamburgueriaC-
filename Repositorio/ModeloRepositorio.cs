using System.Collections.Generic;
using System.IO;
using AppEstacionamento.Models;

namespace AppEstacionamento.Repositorio {
    public class ModeloRepositorio {
        private const string PATH = "DataBase/Modelos.csv";

        private List<Modelo> Modelos = new List<Modelo> ();

        public List<Modelo> Listar () {
            var registro = File.ReadAllLines (PATH);
            foreach (var item in registro) {
                var valores = item.Split (";");
                Modelo modelo = new Modelo ();
                modelo.NomeDoModelo = valores[1];

                Modelos.Add (modelo);

            }
            return Modelos;
        }
    }
}