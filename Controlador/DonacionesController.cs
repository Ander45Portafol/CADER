using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class DonacionesController
    {
        private int id_donacion;
        private int id_usuario;
        private double cantidad_donacion;
        private string fecha_donacion;
        private string descripcion_donacion;

        public int Id_Donacion
        {
            get => id_donacion;
            set => id_donacion = value;
        }
        public int Id_Usuario
        {
            get => id_usuario;
            set => id_usuario = value;
        }
        public double Cantidad_Donacion
        {
            get => cantidad_donacion;
            set => cantidad_donacion = value;
        }
        public string Fecha_Donacion
        {
            get => fecha_donacion;
            set => fecha_donacion = value;
        }
        public string Descripcion_Donacion
        {
            get => descripcion_donacion;
            set => descripcion_donacion = value;
        }
        public static DataTable CargarDonaciones()
        {
            DataTable datos = ModelDonacion.CargarDonaciones(out string message);
            return datos;
        }
        public static DataTable CargarUsuarios()
        {
            DataTable data = ModelDonacion.CargarUsuarios(out string message);
            return data;
        }
        public bool RegistrarDonacion(out string message)
        {
            try
            {
                return ModelDonacion.InsertarDonacion(id_usuario, cantidad_donacion, fecha_donacion, descripcion_donacion, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarDonacion()
        {
            DataTable datos = ModelDonacion.CargarDonacion(id_donacion, out string message);
            return datos;
        }
        public bool ActualizarDonacion(out string message)
        {
            try
            {
                return ModelDonacion.ActualizarDonacion(id_donacion, id_usuario, cantidad_donacion, fecha_donacion, descripcion_donacion, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool EliminarDonacion(out string message)
        {
            try
            {
                return ModelDonacion.EliminarDonacion(id_donacion, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
