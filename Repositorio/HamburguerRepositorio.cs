using System.Collections.Generic;
using System.IO;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.Repositorio
{
    public class HamburguerRepositorio
    {
        private const string PATH = "DataBase/Hamburguer.csv";

        private List<Hamburguer> hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar()
        {
            var registro = File.ReadAllLines(PATH);
            foreach (var item in registro)
            {
                var valores =  item.Split(";");
                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Nome = valores[1];
                hamburguer.Preco = double.Parse(valores[2]);
                
                hamburgueres.Add(hamburguer);


            }
            return hamburgueres;
        }
        public double ObterPrecoDe(string NomeHamburguer)
        {
            var lista = Listar();

            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(NomeHamburguer))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    }
}