using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public ParameterDirection Direccion { get; set; }

        public Cls_parametros(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
            Direccion = ParameterDirection.Input;
        }
    }

    public class Cls_Acceso_Datos
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-UH46M7G\\SQLEXPRESS;Database=DBFACTURAS;Integrated Security=True;TrustServerCertificate=True;");

        public void AbrirBD()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarBD()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public int Ejecutar_procedimiento(string nombreProcedimiento, List<Cls_parametros> parametros)
        {
            int filasAfectadas;
            SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            foreach (var param in parametros)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            AbrirBD();
            filasAfectadas = comando.ExecuteNonQuery();
            CerrarBD();

            return filasAfectadas;
        }

        public int EjecutarComando(string consultaSQL, List<Cls_parametros> parametros)
        {
            int filasAfectadas;
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);

            foreach (var param in parametros)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            AbrirBD();
            filasAfectadas = comando.ExecuteNonQuery();
            CerrarBD();

            return filasAfectadas;
        }

        public DataTable EjecutarConsulta(string consultaSQL, List<Cls_parametros> parametros)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);

            // Agregar parámetros a la consulta
            foreach (var param in parametros)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            AbrirBD();
            adaptador.Fill(dt);
            CerrarBD();

            return dt;
        }

    }
}

