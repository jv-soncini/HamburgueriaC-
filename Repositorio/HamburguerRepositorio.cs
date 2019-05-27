using System.Collections.Generic;
using System.IO;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.Repositorio
{
    public class HamburguerRepositorio
    {
        private const string PATH = "DataBase/Hamburguer";

        private List<Hamburguer> hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar()
        {
            var registro = File.ReadAllLines(PATH);
            foreach (var item in registro)
            {
                var valores =  item.Split(";");
                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Nome = valores[1];
                
                hamburgueres.Add(hamburguer);


            }
            return hamburgueres;
        }
    }
}