using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MarcasServidor {
    class Program {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");

        public static IMarcas blHandler;
        static void Main(string[] args) {
            try {
                SetupDependencies();
                SetupService();

            } catch (Exception e) {
                log.Error(e);

            }
        }

        private static void SetupDependencies() {
            blHandler = new Marcas();
        }

        private static void SetupService() {
            ServiceHost selfHost = new ServiceHost(typeof(Marcas));
            selfHost.Open();
            Console.WriteLine("El servicio está listo");
            Console.WriteLine("Presiones Enter para terminar el servicio");
            Console.WriteLine();
            Console.ReadLine();

            selfHost.Close();
        }
    }
}