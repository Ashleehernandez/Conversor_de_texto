using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryConversor
    {
        public FactoryConversor()
        {
            
        }

        public static IConversor_de_texto GetConversor(string tipo)
        {
            switch (tipo)
            {
                case "Mayúsculas":
                    return new Servicio.Mayúsculas();
                case "Minúsculas":
                    return new Servicio.Minúsculas();
                case "Formato_título":
                    return new Servicio.Formato_título();
                default:
                    return null;
            }
        }
    }
}
