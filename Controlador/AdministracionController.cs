using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Modelo;

namespace Controlador
{
    public class AdministracionController
    {
        private int id_usuario;
        private int id_iglesia;
        private string nombre_usuario;
        private string apellido_usuario;
        private string clave_usuario;
        private string correo_usuario;
        private string dui_usuario;
        private string telefono_usuario;
        private string tipo_usuario;

        public int Id_Usuario
        {
            get => id_usuario;
            set => id_usuario = value;
        }
        public string Nombre_Usuario
        {
            get => nombre_usuario;
            set => nombre_usuario = value;
        }
        public string Apellido_Usuario
        {
            get => apellido_usuario;
            set => apellido_usuario = value;
        }
        public string Clave_Usuario
        {
            get => clave_usuario;
            set => clave_usuario = value;
        }
        public string Correo_Usuario
        {
            get => correo_usuario;
            set => correo_usuario = value;
        }
        public string Telefono_Usuario { 
            get => telefono_usuario;
            set => telefono_usuario = value;
        }
        public string Dui_Usuario { 
            get => dui_usuario;
            set => dui_usuario=value;
        }
        public string Tipo_Usuario {
            get => tipo_usuario;
            set => tipo_usuario = value;
        }

        public static DataTable CargarUsuarios() {
            DataTable datos = ModelAdministracion.CargarUsuarios(out string message);
            return datos;
        }
        public bool RegistrarUsuario(out string message)
        {
            try
            {
                return ModelAdministracion.InsertarUsuario(nombre_usuario, apellido_usuario, correo_usuario, clave_usuario,telefono_usuario,dui_usuario,tipo_usuario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar la accion: {ex.Message}";
                return false;
            }
        }
        public DataTable CargarUsuario()
        {
            DataTable datos = ModelAdministracion.CargarUsuario(id_usuario, out string message);
            return datos;
        }
        public bool ActualizarUsuario(out string message)
        {
            try
            {
                return ModelAdministracion.ActualizarUsuario(id_usuario, nombre_usuario, apellido_usuario, correo_usuario, clave_usuario,telefono_usuario,dui_usuario,tipo_usuario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al actualizar la accion: {ex.Message}";
                return false;
            }
        }
        public bool EliminarUsuario(out string message)
        {
            try
            {
                return ModelAdministracion.EliminarUsuario(id_usuario, out message);
            }
            catch (Exception ex)
            {
                message = $"Error al eliminar el registro: {ex.Message}";
                return false;
            }
        }
        public bool Login() {
            return ModelLogin.Autenticar(correo_usuario,clave_usuario,out string message);
        }
    }
}
