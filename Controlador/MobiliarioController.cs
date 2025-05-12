using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class MobiliarioController
    {
        public int id_mobiliario;
        public int id_objeto;
        public int id_grupo;
        public DateTime fecha_uso;
        public DateTime fecha_regreso;

        public int Id_Mobiliario {
            get => id_mobiliario;
            set => id_mobiliario = value;
        }
        public int Id_Objeto { 
            get => id_objeto;
            set => id_objeto = value;
        }
        public int Id_Grupo { 
            get => id_grupo;
            set => id_grupo = value;
        }
        public DateTime Fecha_Uso { 
            get => fecha_uso;
            set => fecha_uso = value;
        }
        public DateTime Fecha_Regreso { 
            get => fecha_regreso;
            set => fecha_regreso = value;
        }

        //cargar grid de datos a tabla 
        public static DataTable CargarMobiliarios()
        {
            DataTable datos = ModelMobilirio.CargarMobiliarios(out string message);
            return datos;
        }
        public static DataTable CargarObjetos() { 
            DataTable data=ModelMobilirio.CargarObjetos(out string message);
            return data;
        }
        public static DataTable CargarGrupos()
        {
            DataTable data = ModelMobilirio.CargarGrupos(out string message);
            return data;
        }
    }
}
