using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MarcasServidor {
    class Program {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");

        public static IMarcas blHandler;
        static void Main(string[] args) {

            var exitCode = HostFactory.Run(x => {
                x.Service<Service>(s => {
                    s.ConstructUsing(marcasService => new Service());
                    s.WhenStarted(marcasService => marcasService.Start());
                    s.WhenStopped(marcasService => marcasService.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("MarcasPresentismo");
                x.SetDisplayName("Marcas de Presentismo");
                x.SetDescription("Servicio de marcas generado por José Calvelo - SSI Ltda.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;

        }
    }
}