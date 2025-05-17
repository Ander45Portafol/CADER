using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class OfrendaController
    {
        private int id_ofrenda;
        private double cantidad_ofrenda;
        private string fecha_ofrenda;

        public int Id_Ofrenda
        {
            get => id_ofrenda;
            set => id_ofrenda = value;
        }
        public double Cantidad_Ofrenda
        {
            get => cantidad_ofrenda;
            set => cantidad_ofrenda = value;
        }
        public string Fecha_Ofrenda
        {
            get => fecha_ofrenda;
            set => fecha_ofrenda = value;
        }

        public static DataTable CargarOfrendas()
        {
            DataTable datos = ModelOfrenda.CargarOfrendas(out string message);
            return datos;
        }
        public bool RegistrarOfrenda(out string message)
        {
            try
            {
                return ModelOfrenda.InsertarOfrenda(cantidad_ofrenda,fecha_ofrenda, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarOfrenda()
        {
            DataTable datos = ModelOfrenda.CargarOfrenda(id_ofrenda, out string message);
            return datos;
        }
        public bool ActualizarOfrenda(out string message)
        {
            try
            {
                return ModelOfrenda.ActualizarOfrenda(id_ofrenda, cantidad_ofrenda, fecha_ofrenda, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool ELiminarOfrenda(out string message)
        {
            try
            {
                return ModelOfrenda.EliminarOfrenda(id_ofrenda, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
