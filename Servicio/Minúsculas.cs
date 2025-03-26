using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Servicio
{
    public class Minúsculas : IConversor_de_texto
    {
        public void Conversor(string texto )
        {
            Console.WriteLine("El texto en minuscula es  " + texto.ToLower());
        }
    }
}
