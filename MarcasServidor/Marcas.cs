using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MarcasServidor
{
    public class Marcas : IMarcas
    {
        public void MarcaEntrada(String user, String login_computer)
        {
            DateTime now = DateTime.Now;
            String path = @"C:\Datos\MarcasPresentismo\" + DateTime.Now.ToString("MMMM") + "-" + now.Year + ".csv";

            if (File.Exists(path)) {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(now.ToShortDateString() + ";" + now.ToShortTimeString() + ";" + user + ";" + login_computer + ";" + "INICIO");
                }
            } else
            {
                String line = now.ToShortDateString() + ";" + now.ToShortTimeString() + ";" + user + ";" + login_computer + ";" + "INICIO" + Environment.NewLine;
                File.WriteAllText(path, line);
            }
            
        }

        public void MarcaSalida(String user, String login_computer)
        {
            DateTime now = DateTime.Now;
            String path = @"C:\Datos\MarcasPresentismo\" + DateTime.Now.ToString("MMMM") + "-" + now.Year + ".csv";


            if (File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(now.ToShortDateString() + ";" + now.ToShortTimeString() + ";" + user + ";" + login_computer + ";" + "CIERRE");
                }
            } 
            else
            {
                String line = now.ToShortDateString() + ";" + now.ToShortTimeString() + ";" + user + ";" + login_computer + ";" + "CIERRE" + Environment.NewLine;
                File.WriteAllText(path, line);
            }
        }
    }
}
