using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MarcasServidor
{
    class Program
    {
        public static IMarcas blHandler;
        static void Main(string[] args)
        {
            SetupDependencies();
            SetupService();
        }

        private static void SetupDependencies()
        {
            blHandler = new Marcas();
        }

        private static void SetupService()
        {
            try
            {
                ServiceHost selfHost = new ServiceHost(typeof(Marcas));
                selfHost.Open();
                Console.WriteLine("El servicio está listo");
                Console.WriteLine("Presiones Enter para terminar el servicio");
                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                throw;
            }
        }
    }
}