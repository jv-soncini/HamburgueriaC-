using Microsoft.Extensions.Primitives;

namespace AppEstacionamento.Models
{
    public class Marca
    {
     

        public string NomeDaMarca {get; set;}

        public Marca(string NomeDaMarca){

            this.NomeDaMarca = NomeDaMarca;
        }

        public Marca(){

        }
    }
}