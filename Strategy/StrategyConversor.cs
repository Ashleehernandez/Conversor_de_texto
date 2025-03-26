using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Servicio;

namespace Strategy
{
    public class StrategyConversor
    {
        private IConversor_de_texto _conversor;

        public StrategyConversor(IConversor_de_texto conversor_De_)
        {
            this._conversor = conversor_De_;
        }

        public void CambiarStrategy(IConversor_de_texto Canviar)
        {
            this._conversor = Canviar;
        }

        public void ConvertirTexto(string texto )
        {
            _conversor.Conversor(texto);
        }
    }
}
