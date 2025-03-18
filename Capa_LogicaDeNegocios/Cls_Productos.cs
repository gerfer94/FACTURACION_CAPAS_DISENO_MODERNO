using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        private readonly string connectionString = "Server=DESKTOP-UH46M7G\\SQLEXPRESS;Database=DBFACTURAS;Integrated Security=True;TrustServerCertificate=True;";

        // Método para obtener todos los productos con la descripción de la categoría
        public DataTable ObtenerProductos()
        {
            DataTable dtProductos = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT P.IdProducto, P.StrNombre, P.StrCodigo, P.NumPrecioCompra, P.NumPrecioVenta, 
                                            P.NumStock, C.StrDescripcion AS Categoria, P.StrDetalle, P.StrFoto 
                                     FROM TBLPRODUCTO P
                                     LEFT JOIN TBLCATEGORIA_PROD C ON P.IdCategoria = C.IdCategoria";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dtProductos);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
            return dtProductos;
        }

        // Método para obtener todas las categorías
        public DataTable ObtenerCategorias()
        {
            DataTable dtCategorias = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtCategorias);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }
            return dtCategorias;
        }

        // Método para insertar un producto
        public bool InsertarProducto(string nombre, string codigo, decimal precioCompra, decimal precioVenta, int stock, int idCategoria, string detalles, string foto, string usuarioModifica)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO TBLPRODUCTO (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, NumStock, IdCategoria, StrDetalle, StrFoto, DtmFechaModifica, StrUsuarioModifica) 
                                     VALUES (@Nombre, @Codigo, @PrecioCompra, @PrecioVenta, @Stock, @IdCategoria, @Detalles, @Foto, GETDATE(), @UsuarioModifica)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Detalles", detalles);
                        cmd.Parameters.AddWithValue("@Foto", foto);
                        cmd.Parameters.AddWithValue("@UsuarioModifica", usuarioModifica);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el producto: " + ex.Message);
            }
        }

        // Método para actualizar un producto
        public bool ActualizarProducto(int id, string nombre, string codigo, decimal precioCompra, decimal precioVenta, int stock, int idCategoria, string detalles, string foto, string usuarioModifica)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE TBLPRODUCTO SET StrNombre = @Nombre, StrCodigo = @Codigo, NumPrecioCompra = @PrecioCompra, NumPrecioVenta = @PrecioVenta, 
                                     NumStock = @Stock, IdCategoria = @IdCategoria, StrDetalle = @Detalles, StrFoto = @Foto, DtmFechaModifica = GETDATE(), StrUsuarioModifica = @UsuarioModifica 
                                     WHERE IdProducto = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Detalles", detalles);
                        cmd.Parameters.AddWithValue("@Foto", foto);
                        cmd.Parameters.AddWithValue("@UsuarioModifica", usuarioModifica);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el producto: " + ex.Message);
            }
        }

        // Método para eliminar un producto
        public bool EliminarProducto(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM TBLPRODUCTO WHERE IdProducto = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
        }
    }
}
