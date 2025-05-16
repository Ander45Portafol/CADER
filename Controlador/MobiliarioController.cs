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
        private int id_mobiliario;
        private int id_objeto;
        private int id_grupo;
        private string fecha_uso;
        private string fecha_regreso;

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
        public string Fecha_Uso { 
            get => fecha_uso;
            set => fecha_uso = value;
        }
        public string Fecha_Regreso { 
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
        public  bool RegistrarMobiliario( out string message)
        {
            try
            {
                return ModelMobilirio.InsertarMobiliario(id_objeto, id_grupo, fecha_uso, fecha_regreso,out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarMobiliario() {
            DataTable datos = ModelMobilirio.CargarMobiliario(id_mobiliario, out string message);
            return datos;
        }
        public bool ActualizarMobiliario(out string message)
        {
            try
            {
                return ModelMobilirio.ActualizarMobiliario(id_mobiliario,id_objeto, id_grupo, fecha_uso, fecha_regreso, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool EliminarMobiliario(out string message) {
            try
            {
                return ModelMobilirio.EliminarMobiliario(id_mobiliario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
