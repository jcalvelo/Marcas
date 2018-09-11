using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marcas.ServiceReferenceMarcas;
using System.ServiceModel.Configuration;

namespace Marcas
{
    class Program
    {
        static void Main(string[] args)
        {
            MarcasClient mc = new MarcasClient();
            if (args[0].Equals("inicio")) {
                mc.MarcaEntrada(Environment.UserName, Environment.MachineName);
            } else if (args[0].Equals("cierre"))
                mc.MarcaSalida(Environment.UserName, Environment.MachineName);
        }
    }
}
