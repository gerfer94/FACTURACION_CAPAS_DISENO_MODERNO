using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Facturas
    {
        private string connectionString = "Server=DESKTOP-UH46M7G\\SQLEXPRESS;Database=DBFACTURAS;Integrated Security=True;TrustServerCertificate=True;";

        public DataTable ObtenerFacturas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdFactura, DtmFecha, IdCliente, IdEmpleado, NumDescuento, NumImpuesto, NumValorTotal, IdEstado FROM TBLFACTURA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerFacturaPorId(int idFactura)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdFactura, DtmFecha, IdCliente, IdEmpleado, NumDescuento, NumImpuesto, NumValorTotal, IdEstado FROM TBLFACTURA WHERE IdFactura = @IdFactura";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool InsertarFactura(DateTime fecha, int idCliente, int idEmpleado, float descuento, float impuesto, float valorTotal, int idEstado, string usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TBLFACTURA (DtmFecha, IdCliente, IdEmpleado, NumDescuento, NumImpuesto, NumValorTotal, IdEstado, DtmFechaModifica, StrUsuarioModifica) " +
                               "VALUES (@Fecha, @IdCliente, @IdEmpleado, @Descuento, @Impuesto, @ValorTotal, @IdEstado, GETDATE(), @Usuario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@Descuento", descuento);
                cmd.Parameters.AddWithValue("@Impuesto", impuesto);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@IdEstado", idEstado);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool ActualizarFactura(int idFactura, DateTime fecha, int idCliente, int idEmpleado, float descuento, float impuesto, float valorTotal, int idEstado, string usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE TBLFACTURA SET DtmFecha = @Fecha, IdCliente = @IdCliente, IdEmpleado = @IdEmpleado, NumDescuento = @Descuento, " +
                               "NumImpuesto = @Impuesto, NumValorTotal = @ValorTotal, IdEstado = @IdEstado, DtmFechaModifica = GETDATE(), StrUsuarioModifica = @Usuario " +
                               "WHERE IdFactura = @IdFactura";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@Descuento", descuento);
                cmd.Parameters.AddWithValue("@Impuesto", impuesto);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@IdEstado", idEstado);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool EliminarFactura(int idFactura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TBLFACTURA WHERE IdFactura = @IdFactura";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
