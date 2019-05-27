using System.Collections.Generic;
using HamburgueriaWeb.Models;

namespace HamburgueriaWeb.ViewModel
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get; set;}
        public List<Shake> Shakess {get; set;}
    }
}