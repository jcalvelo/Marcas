using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MarcasServidor {
    class Service {
        private IMarcas blHandler;
        ServiceHost selfHost;


        public Service() {
            this.blHandler = new Marcas();
            this.selfHost = new ServiceHost(typeof(Marcas));
        }


        public void Start() {

            try {
                selfHost.Open();
                Console.WriteLine("El servicio está listo");
                Console.WriteLine("Presiones Enter para terminar el servicio");
            } catch (Exception e) {
                Console.WriteLine("Error: {0}", e);
                throw e;
            }
        }

        public void Stop() {
            selfHost.Close();
        }


    }
}
