using System.Collections.Generic;
using System.IO;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.Repositorio
{
    public class ShakesRepositorio
    {
        private const string PATH = "DataBase/Shake";

        private List<Shake> shakes = new List<Shake>();

        public List<Shake> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores =  item.Split(";");
                Shake shake = new Shake();
                shake.Nome = valores[1];
                
                shakes.Add(shake);


            }
            return shakes;
        }
    }
}