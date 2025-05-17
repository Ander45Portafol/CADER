using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class EventoController
    {
        private int id_evento;
        private string lugar_evento;
        private string fecha_evento;
        private string tipo_evento;

        public int Id_Evento
        {
            get => id_evento;
            set => id_evento = value;
        }
        public string Lugar_Evento
        {
            get => lugar_evento;
            set => lugar_evento = value;
        }
        public string Fecha_Evento
        {
            get => fecha_evento;
            set => fecha_evento = value;
        }
        public string Tipo_Evento
        {
            get => tipo_evento;
            set => tipo_evento = value;
        }
        public static DataTable CargarEventos()
        {
            DataTable datos = ModelEvento.CargarEvento(out string message);
            return datos;
        }

        public bool RegistrarEento(out string message)
        {
            try
            {
                return ModelEvento.InsertarEvento(lugar_evento, fecha_evento, tipo_evento, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarEvento()
        {
            DataTable datos = ModelEvento.CargarEvento(id_evento, out string message);
            return datos;
        }
        public bool ActualizarEvento(out string message)
        {
            try
            {
                return ModelEvento.ActualizarEvento(id_evento, lugar_evento, fecha_evento, tipo_evento, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool EliminarEvento(out string message)
        {
            try
            {
                return ModelEvento.EliminarEvento(id_evento, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
    }
}
