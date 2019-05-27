using Microsoft.Extensions.Primitives;

namespace HamburgueriaWeb.Models
{
    public class Hamburguer
    {
        public Hamburguer()
        {
        }

        public Hamburguer(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public string Nome {get; set;}
    }
}