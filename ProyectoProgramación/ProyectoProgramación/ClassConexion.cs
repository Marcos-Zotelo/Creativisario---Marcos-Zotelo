using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.IO;
using System.Xml;

namespace ProyectoProgramación
{

	public class ClassConexion
	{
		public SqlConnection conexion;
	
		public bool Conectar()
		{
			try
			{
				if (conexion.State != ConnectionState.Open)
				{
					conexion.Open();
				}
				return true;
			}
			catch (SqlException ex)
			{
				switch (ex.Number)
				{
					case 0:
						MessageBox.Show("Cannot connect to server.  Contact administrator");
						break;
	
					case 1045:
						MessageBox.Show("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}
	
		public bool Desconectar()
		{
			try
			{
				conexion.Close();
				return true;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
	
		public bool CrearConexion()
		{
		    try
		    {
		        string strConexion = "Server=localhost;Database=BD_proyecto;Integrated Security=True";
		        conexion = new SqlConnection(strConexion);
		        return true;
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al crear la conexión: " + ex.Message);
		        return false;
		    }
		}
	
	
		public DataRow ObtenerData(String Consulta)
		{
			try
			{
				// Se abre la conexion
				if (this.Conectar())
				{
					// Se crea un MySqlAdapter para obtener los datos de la base
					SqlDataAdapter adaptadorDatos = new SqlDataAdapter(Consulta, conexion);
	
					//crea un datatable
					DataTable dtDatos = new DataTable();
	
					adaptadorDatos.Fill(dtDatos);
	
					// Se cierra la conexión a la base de datos
					this.Desconectar();
	
					return dtDatos.Rows[0];
				}
				else
				{
					return null;
				}
			}
			catch
			{
				return null;
			}
		}

				
		public void EjecutarComandoSQL(string sql)
		{
		    try
		    {
		        if (this.Conectar())
		        {
		            SqlCommand cmd = new SqlCommand(sql, conexion);
		            cmd.ExecuteNonQuery();
		            this.Desconectar();
		        }
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al ejecutar el comando SQL: " + ex.Message);
		    }
		}

			public object ObtenerIdUsuario(string query)
	    {
	        try
	        {
	            if (this.Conectar())
	            {
	                SqlCommand cmd = new SqlCommand(query, conexion);
	                object result = cmd.ExecuteScalar();
	                this.Desconectar();
	                return result;
	            }
	            else
	            {
	                return null;
	            }
	        }
	        catch (Exception ex)
	        {
	            MessageBox.Show("Error al obtener ID de usuario: " + ex.Message);
	            return null;
	        }
	    }
			
					public void ActualizarNivelUsuario(int userId, int nuevoNivel)
		{
		    try
		    {
		        if (this.Conectar())
		        {
		            string qry = "UPDATE usuarios SET usua_nivel = @NuevoNivel WHERE usua_id = @UserId";
		            using (SqlCommand command = new SqlCommand(qry, conexion))
		            {
		                command.Parameters.AddWithValue("@NuevoNivel", nuevoNivel);
		                command.Parameters.AddWithValue("@UserId", userId);
		
		                command.ExecuteNonQuery();
		            }
		            this.Desconectar();
		        }
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al actualizar el nivel del usuario: " + ex.Message);
		    }
		}
			
		public string ObtenerNombreUsuario(int userId)
		{
		    try
		    {
		        string qry = "exec sp_ObtenerNombreUsuario " + userId;    
		        if (this.Conectar())
		        {
		            SqlCommand command = new SqlCommand(qry, conexion);
		            object resultado = command.ExecuteScalar();
		            this.Desconectar();
		            return resultado != null ? resultado.ToString() : ""; // Devuelve el resultado o una cadena vacía si es nulo
		        }
		        else
		        {
		            return "";
		        }
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Error al obtener el nombre del usuario: " + ex.Message);
		        return "";
		    }
	}

					
			public int ObtenerNivelUsuario(string nombreUsuario)
			{
		    int nivel = 0;
		    string qry = "EXEC sp_ObtenerNivelUsuario @NombreUsuario";
		
		    using (SqlCommand command = new SqlCommand(qry, conexion))
		    {
		        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
		
		        try
		        {
		        	conexion.Open();
		            object resultado = command.ExecuteScalar();
		            if (resultado != null && int.TryParse(resultado.ToString(), out nivel))
		            {
		            }
		           
		        }
		        catch (SqlException )
		        {
		        	
		        }
		        finally
		        {
		            conexion.Close();
		        }
		    }
		
		    return nivel;
		}

		
		
		public bool ValidarUsuario(string nombreUsuario){
			try
			{
				string query = "EXEC sp_ValidarUsuario @NombreUsuario";
				using (SqlCommand cmd = new SqlCommand(query, conexion))
				{
					cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
					
					conexion.Open();
					int resultado = (int)cmd.ExecuteScalar();
					conexion.Close();
					
					return resultado != 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al validar usuario: " + ex.Message);
				return false;
			}
		}
		
		public DataSet EjecutarSentencia(string consulta)
		{
			try
			{
				if (this.Conectar())
				{
					// Se crea un SqlDataAdapter para obtener los datos de la base
					SqlDataAdapter adaptadorDatos = new SqlDataAdapter(consulta, conexion);
	
					// Se crea un DataSet para almacenar el resultado de la consulta
					DataSet dsResultado = new DataSet();
	
					// Llena el DataSet con los datos obtenidos de la consulta
					adaptadorDatos.Fill(dsResultado);
	
					// Cierra la conexión a la base de datos
					this.Desconectar();
	
					return dsResultado;
				}
				else
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);
				return null;
			}
		}
	
	}
}

