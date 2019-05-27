using System;
using System.IO;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.Repositorio
{
    public class PedidoRepositorio
    {
        private const string PATH = "DataBase/Pedido.csv";
        public bool  Inserir(Pedido pedido)
        {

            try{

            if(!File.Exists("DataBase/Pedido.csv"))
            {
                File.Create("DataBase/Pedido.csv").Close();
            }

            var registro = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Telefone};{pedido.Cliente.Endererco};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Hamburguer.Preco};{pedido.Shake.Nome};{pedido.Shake.Preco};{pedido.DataPedido}\n";

            File.AppendAllText("DataBase/Pedido.csv", registro);
            } catch(Exception e)
            {
                System.Console.WriteLine("Chegou no catch");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }
    }
}