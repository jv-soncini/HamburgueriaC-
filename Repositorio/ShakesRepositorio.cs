using System.Collections.Generic;
using System.IO;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.Repositorio
{
    public class ShakesRepositorio
    {
        private const string PATH = "DataBase/Shake.csv";

        private List<Shake> shakes = new List<Shake>();

        public List<Shake> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores =  item.Split(";");
                Shake shake = new Shake();
                shake.Nome = valores[1];
                shake.Preco = double.Parse(valores[2]);
                
                shakes.Add(shake);


            }
            return shakes;
        }

        public double ObterPrecoDe(string NomeShake)
        {
            var lista = Listar();

            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(NomeShake))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    }
}