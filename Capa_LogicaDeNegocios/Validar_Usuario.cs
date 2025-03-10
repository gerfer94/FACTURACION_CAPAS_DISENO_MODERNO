using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Validar_Usuario
    {
        // Atributos de la clase
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int IdEmpleado { get; private set; }

        // Instancia de la capa de acceso a datos
        private Cls_Acceso_Datos accesoDatos = new Cls_Acceso_Datos();

        // Método para validar usuario
        public bool ValidarUsuario()
        {
            try
            {
                // Consulta SQL para verificar usuario en la base de datos
                string consulta = "SELECT IdEmpleado FROM TBLSeguridad WHERE StrUsuario = @Usuario AND StrClave = @Clave";

                // Lista de parámetros para la consulta
                List<Cls_parametros> parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@Usuario", Usuario),
                    new Cls_parametros("@Clave", Clave)
                };

                // Ejecutamos la consulta y obtenemos los datos
                DataTable resultado = accesoDatos.EjecutarConsulta(consulta, parametros);

                // Verificamos si hay datos
                if (resultado.Rows.Count > 0)
                {
                    IdEmpleado = Convert.ToInt32(resultado.Rows[0]["IdEmpleado"]);
                    return true; // Usuario válido
                }
                else
                {
                    return false; // Usuario no encontrado o credenciales incorrectas
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
        }
    }
}
