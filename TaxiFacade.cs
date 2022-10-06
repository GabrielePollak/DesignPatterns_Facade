using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFacade
{
    internal class TaxiFacade
    {
      public TaxiFacade()
      {
            TiposCarro tipos_Carros = new TiposCarro();
            
      }

        public void BuscarCarroConvencional()
        {
            TiposCarro.BuscarCarroConvencioal();
        }

        public void BuscarCarroConfort()
        {
            TiposCarro.BuscarCarroConfort();
        }

       



    }
}
