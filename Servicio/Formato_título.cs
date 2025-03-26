using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
namespace Servicio
{
    public class Formato_título : IConversor_de_texto
    {
        public void Conversor(string texto )
        {
            Console.WriteLine("Texto en formato título: " + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto));
        }
    }
}
