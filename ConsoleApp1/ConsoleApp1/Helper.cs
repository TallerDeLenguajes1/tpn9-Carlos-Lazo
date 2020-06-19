using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Helpers
{
    static public class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string ruta, string NombreArchivo)
        {
            string Extencion = ".dat";

            if (!File.Exists(ruta + NombreArchivo + Extencion))
            {
                File.Create(ruta + NombreArchivo + Extencion);
            }
        }

        public static string LeerConfiguracion(string ruta, string NombreArchivo)
        {
            string Extencion = ".dat";
            if (!File.Exists(ruta + NombreArchivo + Extencion))
            {
                return File.ReadAllText(ruta + NombreArchivo + Extencion);
            }

            return "Vacio o no existe";
        }
    }
}
