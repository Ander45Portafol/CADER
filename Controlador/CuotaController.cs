using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class CuotaController
    {
        private int id_cuota;
        private int id_usuario;
        private double cantidad_cuota;
        private string fecha_cuota;

        public int Id_Cuota
        {
            get => id_cuota;
            set => id_cuota = value;
        }
        public int Id_Usuario
        {
            get => id_usuario;
            set => id_usuario = value;
        }
        public double Cantidad_Cuota
        {
            get => cantidad_cuota;
            set => cantidad_cuota = value;
        }
        public string Fecha_Cuota
        {
            get => fecha_cuota;
            set => fecha_cuota = value;
        }
        public static DataTable CargarCuotas()
        {
            DataTable datos = ModelCuota.CargarCuota(out string message);
            return datos;
        }
        public static DataTable CargarUsuarios()
        {
            DataTable data = ModelCuota.CargarUsuarios(out string message);
            return data;
        }
        public bool RegistrarCuota(out string message)
        {
            try
            {
                return ModelCuota.InsertarCuota(cantidad_cuota, fecha_cuota, id_usuario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarCuota()
        {
            DataTable datos = ModelCuota.CargarCuota(id_cuota, out string message);
            return datos;
        }
        public bool ActualzarCuota(out string message)
        {
            try
            {
                return ModelCuota.ActualizarCuota(id_cuota, cantidad_cuota, fecha_cuota, id_usuario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool EliminarCuota(out string message)
        {
            try
            {
                return ModelCuota.ELiminarCUota(id_cuota, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
