using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ServiciosController
    {
        private int id_servicio;
        private int id_grupo;
        private string nombre_encargado;
        private string horario;
        private string tipo_servicio;

        public int Id_Servicio
        {
            get => id_servicio;
            set => id_servicio = value;
        }
        public int Id_Grupo
        {
            get => id_grupo;
            set => id_grupo = value;
        }
        public string Nombre_Encargado
        {
            get => nombre_encargado;
            set => nombre_encargado = value;
        }
        public string Horario
        {
            get => horario;
            set => horario = value;
        }
        public string Tipo_Servicio
        {
            get => tipo_servicio;
            set => tipo_servicio = value;
        }

        //cargar grid de datos a tabla 
        public static DataTable CargarServicios()
        {
            DataTable datos = ModelServicios.CargarServicios(out string message);
            return datos;
        }
        public static DataTable CargarGrupos()
        {
            DataTable data = ModelServicios.cargarGrupos(out string message);
            return data;
        }
        public DataTable CargarServicio()
        {
            DataTable data = ModelServicios.CargarServicio(id_servicio,out string message);
            return data;
        }
        public bool RegistrarServicios(out string message)
        {
            try
            {
                return ModelServicios.InsertarServicios(id_grupo, nombre_encargado, horario,tipo_servicio, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public bool ActualizarServicios(out string message)
        {
            try
            {
                return ModelServicios.ActualizarCuota(id_servicio,id_grupo, nombre_encargado,horario, tipo_servicio, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool ELiminarServicios(out string message)
        {
            try
            {
                return ModelServicios.EliminarServicio(id_servicio, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
