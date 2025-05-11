using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControllerConexion
    {
        public static bool ConexionVerificar()
        {
            return Conexion.VerficiarConexion();
        }
    }
}
