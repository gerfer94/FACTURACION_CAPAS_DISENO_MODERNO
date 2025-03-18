using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Cliente
    {
        private readonly string connectionString = "Server=DESKTOP-UH46M7G\\SQLEXPRESS;Database=DBFACTURAS;Integrated Security=True;TrustServerCertificate=True;";

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public long Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }

        // Obtener un cliente por ID
        public Cls_Cliente ObtenerClientePorID(int idCliente)
        {
            Cls_Cliente cliente = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM TBLCLIENTES WHERE IdCliente = @IdCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Cls_Cliente
                                {
                                    IdCliente = idCliente,
                                    Nombre = reader["StrNombre"].ToString(),
                                    Documento = Convert.ToInt64(reader["NumDocumento"]),
                                    Direccion = reader["StrDireccion"].ToString(),
                                    Telefono = reader["StrTelefono"].ToString(),
                                    Email = reader["StrEmail"].ToString(),
                                    FechaModifica = Convert.ToDateTime(reader["DtmFechaModifica"]),
                                    UsuarioModifica = reader["StrUsuarioModifica"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el cliente: " + ex.Message);
                }
            }
            return cliente;
        }

        // Obtener lista de clientes
        public List<Cls_Cliente> ObtenerTodosLosClientes()
        {
            List<Cls_Cliente> listaClientes = new List<Cls_Cliente>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM TBLCLIENTES";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaClientes.Add(new Cls_Cliente
                                {
                                    IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                    Nombre = reader["StrNombre"].ToString(),
                                    Documento = Convert.ToInt64(reader["NumDocumento"]),
                                    Direccion = reader["StrDireccion"].ToString(),
                                    Telefono = reader["StrTelefono"].ToString(),
                                    Email = reader["StrEmail"].ToString(),
                                    FechaModifica = Convert.ToDateTime(reader["DtmFechaModifica"]),
                                    UsuarioModifica = reader["StrUsuarioModifica"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la lista de clientes: " + ex.Message);
                }
            }
            return listaClientes;
        }

        // Guardar o actualizar cliente
        public bool GuardarCliente()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query;
                    if (IdCliente > 0)
                    {
                        query = "UPDATE TBLCLIENTES SET StrNombre = @Nombre, NumDocumento = @Documento, StrDireccion = @Direccion, " +
                                "StrTelefono = @Telefono, StrEmail = @Email, DtmFechaModifica = @FechaModifica, StrUsuarioModifica = @UsuarioModifica " +
                                "WHERE IdCliente = @IdCliente";
                    }
                    else
                    {
                        query = "INSERT INTO TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica) " +
                                "VALUES (@Nombre, @Documento, @Direccion, @Telefono, @Email, @FechaModifica, @UsuarioModifica)";
                    }
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Documento", Documento);
                        cmd.Parameters.AddWithValue("@Direccion", Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", Telefono);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UsuarioModifica", UsuarioModifica);
                        if (IdCliente > 0)
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el cliente: " + ex.Message);
                }
            }
        }

        // Eliminar un cliente
        public bool EliminarCliente(int idCliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM TBLCLIENTES WHERE IdCliente = @IdCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }
    }
}
