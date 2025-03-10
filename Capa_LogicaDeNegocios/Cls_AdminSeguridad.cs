using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_AdminSeguridad
    {
        private readonly Cls_Acceso_Datos accesoDatos = new Cls_Acceso_Datos();

        // Obtener los administradores desde la base de datos
        public DataTable ObtenerAdministradores()
        {
            DataTable dt = new DataTable();
            string query = "SELECT IdSeguridad, IdEmpleado, StrUsuario, StrClave, DtmFechaModifica, StrUsuarioModifico FROM TBLSEGURIDAD";

            try
            {
                // Pasamos una lista vacía si no hay parámetros
                List<Cls_parametros> parametros = new List<Cls_parametros>();
                dt = accesoDatos.EjecutarConsulta(query, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los administradores: " + ex.Message);
            }

            return dt;
        }




        // Modificar un administrador
        public int ModificarAdministrador(int idEmpleado, string usuario, string clave, string usuarioModifico)
        {
            int filasAfectadas = 0;
            string query = "UPDATE TBLSEGURIDAD SET StrUsuario = @usuario, StrClave = @clave, StrUsuarioModifico = @usuarioModifico, DtmFechaModifica = GETDATE() WHERE IdEmpleado = @idEmpleado";

            try
            {
                List<Cls_parametros> parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@idEmpleado", idEmpleado),
                    new Cls_parametros("@usuario", usuario),
                    new Cls_parametros("@clave", clave),
                    new Cls_parametros("@usuarioModifico", usuarioModifico)
                };

                // Ejecutar el comando de actualización
                filasAfectadas = accesoDatos.EjecutarComando(query, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el administrador: " + ex.Message);
            }

            return filasAfectadas;
        }

        // Agregar un nuevo administrador
        public int AgregarAdministrador(int idEmpleado, string usuario, string clave, string usuarioModifico)
        {
            int filasAfectadas = 0;
            string query = "INSERT INTO TBLSEGURIDAD (IdEmpleado, StrUsuario, StrClave, StrUsuarioModifico, DtmFechaModifica) VALUES (@idEmpleado, @usuario, @clave, @usuarioModifico, GETDATE())";

            try
            {
                List<Cls_parametros> parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@idEmpleado", idEmpleado),
                    new Cls_parametros("@usuario", usuario),
                    new Cls_parametros("@clave", clave),
                    new Cls_parametros("@usuarioModifico", usuarioModifico)
                };

                // Ejecutar el comando de inserción
                filasAfectadas = accesoDatos.EjecutarComando(query, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el administrador: " + ex.Message);
            }

            return filasAfectadas;
        }

        // Eliminar un administrador
        public int EliminarAdministrador(int idEmpleado)
        {
            int filasAfectadas = 0;
            string query = "DELETE FROM TBLSEGURIDAD WHERE IdEmpleado = @idEmpleado";

            try
            {
                List<Cls_parametros> parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@idEmpleado", idEmpleado)
                };

                // Ejecutar el comando de eliminación
                filasAfectadas = accesoDatos.EjecutarComando(query, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el administrador: " + ex.Message);
            }

            return filasAfectadas;
        }
    }
}
