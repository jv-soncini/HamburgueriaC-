using System;
using System.Collections.Generic;
using System.IO;
using AppEstacionamento.Models;

namespace AppEstacionamento.Repositorio
{
    public class RegistroRepositorio
    {
        private const string PATH = "DataBase/Registros.csv";



        public bool  Inserir(Registro registro )
        {

            try{

            if(!File.Exists("DataBase/Registros.csv"))
            {
                File.Create("DataBase/Registros.csv").Close();
            }

            var reegistro = $"{registro.Cliente.NomeCondutor};{registro.Carro.Placa};{registro.Carro.modelo};{registro.Carro.marca}\n";

            File.AppendAllText("DataBase/Registros.csv", reegistro);
            } catch(Exception e)
            {
                System.Console.WriteLine("Chegou no catch");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }
    }
}