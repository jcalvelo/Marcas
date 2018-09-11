using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MarcasServidor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMarcaEntrada" in both code and config file together.
    [ServiceContract]
    public interface IMarcas
    {
        [OperationContract]
        void MarcaEntrada(String user, String login_computer);
        [OperationContract]
        void MarcaSalida(String user, String login_computer);
    }
}
