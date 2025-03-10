using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;


namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        // Propiedades de la clase
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public DateTime C_DtmIngreso { get; set; }
        public DateTime? C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }
        public int C_IdDepartamento { get; set; }
        public int C_IdPuesto { get; set; }
        public double C_DblSalario { get; set; }
        public DateTime C_DtFechaContratacion { get; set; }
        public string C_TxtDatosAdicionales { get; set; }
        public string C_StrEstatus { get; set; }
        public string C_StrUsuarioAuditoria { get; set; }

        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Método para obtener un empleado por ID
        public DataRow ObtenerEmpleado(int idEmpleado)
        {
            string sentencia = "SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = @IdEmpleado";
            try
            {
                var parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@IdEmpleado", idEmpleado)
                };

                DataTable resultado = AccesoDatos.EjecutarConsulta(sentencia, parametros);
                return resultado.Rows.Count > 0 ? resultado.Rows[0] : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerEmpleado: " + ex.Message);
                return null;
            }
        }

        // Método para obtener la lista de empleados
        public DataTable ObtenerListaEmpleados()
        {
            string sentencia = "SELECT * FROM TBLEMPLEADO";
            try
            {
                return AccesoDatos.EjecutarConsulta(sentencia, new List<Cls_parametros>());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerListaEmpleados: " + ex.Message);
                return null;
            }
        }

        // Método para guardar o actualizar un empleado
        public string GuardarEmpleado(DataRow empleado)
        {
            try
            {
                bool esNuevo = empleado["IdEmpleado"] == DBNull.Value;

                string sentencia = esNuevo
                    ? "INSERT INTO TBLEMPLEADO (strNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro, strDatosAdicionales) " +
                      "VALUES (@Nombre, @Documento, @Direccion, @Telefono, @Email, @Rol, @Ingreso, @Retiro, @DatosAdicionales)"
                    : "UPDATE TBLEMPLEADO SET strNombre = @Nombre, NumDocumento = @Documento, StrDireccion = @Direccion, StrTelefono = @Telefono, " +
                      "StrEmail = @Email, IdRolEmpleado = @Rol, DtmIngreso = @Ingreso, DtmRetiro = @Retiro, strDatosAdicionales = @DatosAdicionales " +
                      "WHERE IdEmpleado = @IdEmpleado";

                var parametros = new List<Cls_parametros>
        {
            new Cls_parametros("@Nombre", empleado["strNombre"]),
            new Cls_parametros("@Documento", empleado["NumDocumento"]),
            new Cls_parametros("@Direccion", empleado["StrDireccion"]),
            new Cls_parametros("@Telefono", empleado["StrTelefono"]),
            new Cls_parametros("@Email", empleado["StrEmail"]),
            new Cls_parametros("@Rol", empleado["IdRolEmpleado"]),
            new Cls_parametros("@Ingreso", empleado["DtmIngreso"]),
            new Cls_parametros("@Retiro", empleado["DtmRetiro"] == DBNull.Value ? (object)DBNull.Value : empleado["DtmRetiro"]),
            new Cls_parametros("@DatosAdicionales", empleado["strDatosAdicionales"])
        };

                if (!esNuevo)
                    parametros.Add(new Cls_parametros("@IdEmpleado", empleado["IdEmpleado"]));

                int filasAfectadas = AccesoDatos.EjecutarConsulta(sentencia, parametros).Rows.Count;

                return filasAfectadas > 0 ? "✅ Empleado guardado exitosamente." : " Se realizaron cambios en la base de datos.";
            }
            catch (Exception ex)
            {
                return "❌ Error al guardar empleado: " + ex.Message;
            }
        }



        // Método para consultar un empleado por ID
        public DataTable ConsultaEmpleado()
        {
            string sentencia = "SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = @IdEmpleado";
            try
            {
                var parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@IdEmpleado", C_IdEmpleado)
                };
                return AccesoDatos.EjecutarConsulta(sentencia, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ConsultaEmpleado: " + ex.Message);
                return null;
            }
        }

        // Método para filtrar empleados por nombre
        public DataTable Filtrar_Empleado(string filtro)
        {
            return FiltrarEmpleado(filtro);
        }

        public DataTable FiltrarEmpleado(string filtro)
        {
            string sentencia = "SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE @filtro";
            try
            {
                var parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@filtro", "%" + filtro + "%")
                };
                return AccesoDatos.EjecutarConsulta(sentencia, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en FiltrarEmpleado: " + ex.Message);
                return null;
            }
        }

        // Método para obtener los roles de los empleados
        public DataTable ConsultarRol()
        {
            string sentencia = "SELECT * FROM TBLROLES";
            try
            {
                return AccesoDatos.EjecutarConsulta(sentencia, new List<Cls_parametros>());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ConsultarRol: " + ex.Message);
                return null;
            }
        }

        // Método para eliminar un empleado
        public string EliminaEmpleado()
        {
            return EliminarEmpleado();
        }

        public string EliminarEmpleado()
        {
            try
            {
                var parametros = new List<Cls_parametros>
                {
                    new Cls_parametros("@IdEmpleado", C_IdEmpleado)
                };
                int filasAfectadas = AccesoDatos.Ejecutar_procedimiento("eliminar_Empleado", parametros);
                return filasAfectadas > 0 ? "Empleado eliminado correctamente." : "No se encontró el empleado.";
            }
            catch (Exception ex)
            {
                return "FALLÓ BORRADO EN EMPLEADO! " + ex.Message;
            }
        }
    }
}
