using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
	public class ListaCursa : DatosConexionBD
	{
		public int abmCursa(string accion, Cursa objCursa)
		{

			int resultado = -1;
			string orden = string.Empty;
			if (accion == "Alta")
				orden = $"insert into Cursa values ('{objCursa.dni_alumno}','{objCursa.codigo_materia}','{objCursa.nota}','{objCursa.condicion}')";

			if (accion == "Modificar")
				orden = $"update Cursa set DNI_Alumno = '{objCursa.dni_alumno}' where Id = {objCursa.id};  update Cursa set Codigo_Materia = '{objCursa.codigo_materia}' where Id = {objCursa.id}; update Cursa set Nota = '{objCursa.nota}' where Id = {objCursa.id}; update Cursa set Condicion = '{objCursa.condicion}' where Id = {objCursa.id}; ";

			if (accion == "Borrar")
			    orden = $"delete from Cursa where DNI_Alumno = {objCursa.dni_alumno}";


			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar,borrar o modificar {objCursa} ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public bool ExisteCursa(int dni, int codigoMateria)
		{
			
			string consulta = "SELECT COUNT(*) FROM Cursa WHERE DNI_Alumno = @dni AND Codigo_Materia = @codigoMateria";

			using (SqlConnection conexion = new SqlConnection(cadenaConexion))
			using (SqlCommand cmd = new SqlCommand(consulta, conexion))
			{
				cmd.Parameters.AddWithValue("@dni", dni);
				cmd.Parameters.AddWithValue("@codigoMateria", codigoMateria);

				conexion.Open();
				int cantidad = (int)cmd.ExecuteScalar();

				return cantidad > 0;
			}
		}

		//public DataSet listadoCursa(string id)
		//{
		//	string orden = string.Empty;
		//	if (id != "Todos")
		//		orden = $"select * from Cursa where Id = {int.Parse(id)};";
		//	else
		//		orden = "select * from Cursa;";
		//	SqlCommand cmd = new SqlCommand(orden, conexion);
		//	DataSet ds = new DataSet();
		//	SqlDataAdapter da = new SqlDataAdapter();
		//	try
		//	{
		//		Abrirconexion();
		//		cmd.ExecuteNonQuery();
		//		da.SelectCommand = cmd;
		//		da.Fill(ds);

		//		return ds;
		//	}
		//	catch (Exception e)
		//	{
		//		return ds = null;
		//		throw new Exception("Error al listar tabla Cursa", e);
		//	}
		//	finally
		//	{
		//		Cerrarconexion();
		//		cmd.Dispose();
		//	}
		//	//return ds;
		//}

		/*public int abmCursa(string accion, Cursa objCursa)
		{
			int resultado = -1;
			string orden = string.Empty;

			using (SqlConnection connection = new SqlConnection(cadenaConexion))
			{
				connection.Open();

				// Habilitar IDENTITY_INSERT para la tabla Cursa antes de una inserción
				if (accion == "Alta")
				{
					string habilitarIdentityInsert = "SET IDENTITY_INSERT Cursa ON";
					using (SqlCommand enableIdentityCmd = new SqlCommand(habilitarIdentityInsert, connection))
					{
						enableIdentityCmd.ExecuteNonQuery();
					}
				}

				SqlCommand cmd = new SqlCommand(orden, connection);

				if (accion == "Alta")
				{
					orden = "INSERT INTO Cursa (DNI_Alumno, Codigo_Materia, Nota, Condicion) VALUES (@dni_alumno, @codigo_materia, @nota, @condicion)";
					cmd.Parameters.AddWithValue("@dni_alumno", objCursa.dni_alumno);
					cmd.Parameters.AddWithValue("@codigo_materia", objCursa.codigo_materia);
					cmd.Parameters.AddWithValue("@nota", objCursa.nota);
					cmd.Parameters.AddWithValue("@condicion", objCursa.condicion);
				}
				else if (accion == "Modificar")
				{
					orden = "UPDATE Cursa SET DNI_Alumno = @dni_alumno, Codigo_Materia = @codigo_materia, Nota = @nota, Condicion = @condicion WHERE Id = @id";
					cmd.Parameters.AddWithValue("@dni_alumno", objCursa.dni_alumno);
					cmd.Parameters.AddWithValue("@codigo_materia", objCursa.codigo_materia);
					cmd.Parameters.AddWithValue("@nota", objCursa.nota);
					cmd.Parameters.AddWithValue("@condicion", objCursa.condicion);
					cmd.Parameters.AddWithValue("@id", objCursa.id);
				}
				// Resto de las condiciones (Baja) también deben usar parámetros.

				try
				{
					cmd.CommandText = orden;
					resultado = cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					throw new Exception($"Error al tratar de guardar, borrar o modificar {objCursa}", e);
				}

				// Deshabilitar IDENTITY_INSERT para la tabla Cursa después de una inserción
				if (accion == "Alta")
				{
					string deshabilitarIdentityInsert = "SET IDENTITY_INSERT Cursa OFF";
					using (SqlCommand disableIdentityCmd = new SqlCommand(deshabilitarIdentityInsert, connection))
					{
						disableIdentityCmd.ExecuteNonQuery();
					}
				}
			}

			return resultado;
		}*/

		/*public int abmCursa(string accion, Cursa objCursa)
		{
			int resultado = -1;
			string orden = string.Empty;

			using (SqlConnection connection = new SqlConnection(cadenaConexion))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand(orden, connection);

				if (accion == "Alta")
				{
					// No incluyas la columna 'Id' en la inserción
					orden = "INSERT INTO Cursa (DNI_Alumno, Codigo_Materia, Nota, Condicion) VALUES (@dni_alumno, @codigo_materia, @nota, @condicion)";
					cmd.Parameters.AddWithValue("@dni_alumno", objCursa.dni_alumno);
					cmd.Parameters.AddWithValue("@codigo_materia", objCursa.codigo_materia);
					cmd.Parameters.AddWithValue("@nota", objCursa.nota);
					cmd.Parameters.AddWithValue("@condicion", objCursa.condicion);
				}
				else if (accion == "Modificar")
				{
					// No incluyas la columna 'Id' en la actualización
					orden = "UPDATE Cursa SET DNI_Alumno = @dni_alumno, Codigo_Materia = @codigo_materia, Nota = @nota, Condicion = @condicion WHERE Id = @id";
					cmd.Parameters.AddWithValue("@dni_alumno", objCursa.dni_alumno);
					cmd.Parameters.AddWithValue("@codigo_materia", objCursa.codigo_materia);
					cmd.Parameters.AddWithValue("@nota", objCursa.nota);
					cmd.Parameters.AddWithValue("@condicion", objCursa.condicion);
					cmd.Parameters.AddWithValue("@id", objCursa.id);
				}
				// Resto de las condiciones (Baja) también deben usar parámetros.

				try
				{
					cmd.CommandText = orden;
					resultado = cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					throw new Exception($"Error al tratar de guardar, borrar o modificar {objCursa}", e);
				}
			}

			return resultado;
		}*/

		public DataSet listadoCursa(string id)
		{
			string orden = string.Empty;
			if (id != "Todos")
				orden = $"select * from Cursa where Id = {int.Parse(id)};";
			else
				orden = "select * from Cursa;";
			SqlCommand cmd = new SqlCommand(orden, conexion);
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter();
			try
			{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);

				return ds;
			}
			catch (Exception e)
			{
				return ds = null;
				throw new Exception("Error al listar tabla Cursa", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			//return ds;
		}

		public DataSet Unir()
		{

			string orden = $"select c.Id, a.DNI, m.Codigo, c.Nota, c.Condicion from Cursa as c inner join Alumno as a on c.DNI_Alumno=a.DNI inner join Materia as m on c.Codigo_Materia=m.Codigo\r\n";

			SqlCommand cmd = new SqlCommand(orden, conexion);
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter();
			try
			{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}
			catch (Exception e)
			{
				throw new Exception("Error al buscar los detalles del cursado", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}

		public DataSet ListaCursaEliminar(string id)
		{
			string orden = $"delete from Cursa where Id = {id};";

			SqlCommand cmd = new SqlCommand(orden, conexion);
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter();
			try
			{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}
			catch (Exception e)
			{
				throw new Exception("Error al eliminar el cursado", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}
	}
}
