using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
namespace Datos
{
	public class ListaAlumno : DatosConexionBD
	{
		public int abmAlumno(string accion, Alumno objAlumno)
		{
			int resultado = -1;
			string orden = string.Empty;

			if (accion == "Alta")
			{
				orden = $"INSERT INTO Alumno VALUES ('{objAlumno.dni}','{objAlumno.nombreapellido}','{objAlumno.fecha_nac}','{objAlumno.email}','{objAlumno.analitico}')";
			}

			if (accion == "Modificar")
			{
				orden = $"UPDATE Alumno SET NombreApellido = '{objAlumno.nombreapellido}' WHERE DNI = {objAlumno.dni};  UPDATE Alumno SET Fecha_Nac = '{objAlumno.fecha_nac}' WHERE DNI = {objAlumno.dni}; UPDATE Alumno SET Email = '{objAlumno.email}' WHERE DNI = {objAlumno.dni}; UPDATE Alumno SET Analitico = '{objAlumno.analitico}' WHERE DNI = {objAlumno.dni}; ";
			}


			if (accion == "Baja")
			{
				orden = $"DELETE FROM Alumno WHERE ALumno.DNI = {objAlumno.dni}";
			}

			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar, borrar o modificar {objAlumno}", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public DataSet listadoAlumno(string id)
		{
			string orden = string.Empty;
			if (id != "Todos")
			{
				orden = $"SELECT * FROM Alumno WHERE DNI = {int.Parse(id)};";
			}
			else
			{
				orden = "SELECT * FROM Alumno;";
			}

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
				throw new Exception("Error al listar Alumnos", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
		}

		public DataSet ListaAlumnoEliminar(string id)
		{
			string orden = $"DELETE FROM Alumno WHERE DNI = {id};";

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
				throw new Exception("Error al eliminar el Alumno", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}

		public List<Alumno> ObtenerAlumno()
		{
			List<Alumno> lista = new List<Alumno>();

			string OrdenEjecucion = "SELECT DNI, NombreApellido, Fecha_Nac , Email, Analitico FROM Alumno";

			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{
					//string nombre = dataReader.GetString(1);
					int dni = dataReader.GetInt32(0);
					string nombredni = $"{dni}";

					Alumno alumno = new Alumno();

					alumno.dni = dataReader.GetInt32(0);

					//alumno.nombreapellido = nombredni;

					lista.Add(alumno);
				}
			}
			catch (Exception e)
			{
				throw new Exception("Error al obtener la lista de alumnos", e);
			}

			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return lista;
		}
	}
}*/
namespace Datos
{
	public class ListaAlumno : DatosConexionBD
	{
		public int abmAlumno(string accion, Alumno objAlumno)
		{

			int resultado = -1;
			string orden = string.Empty;
			if (accion == "Alta")
				orden = $"insert into Alumno values ('{objAlumno.dni}','{objAlumno.nombreapellido}','{objAlumno.fecha_nac}','{objAlumno.email}','{objAlumno.analitico}')";

			if (accion == "Modificar")
				orden = $"update Alumno set NombreApellido = '{objAlumno.nombreapellido}' where DNI = {objAlumno.dni};  update Alumno set Fecha_Nac = '{objAlumno.fecha_nac}' where DNI = {objAlumno.dni}; update Alumno set Email = '{objAlumno.email}' where DNI = {objAlumno.dni}; update Alumno set Analitico = '{objAlumno.analitico}' where DNI = {objAlumno.dni}; ";

			if (accion == "Borrar")
			    orden = $"delete from Alumno where DNI = {objAlumno.dni}";


			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar,borrar o modificar {objAlumno} ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public DataSet listadoAlumno(string id)
		{
			string orden = string.Empty;
			if (id != "Todos")
				orden = $"select * from Alumno where DNI = {int.Parse(id)};";
			else
				orden = "select * from Alumno;";
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
				throw new Exception("Error al listar Alumnos", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			//return ds;
		}

		public DataSet ListaAlumnoEliminar(string id)
		{
			string orden = $"delete from Alumno where DNI = {id};";

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
				throw new Exception("Error al eliminar el Alumno", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}

		

		public List<Alumno> ObtenerAlumno()
		{

			List<Alumno> lista = new List<Alumno>();


			string OrdenEjecucion = "Select DNI, NombreApellido , Fecha_Nac , Email, Analitico from Alumno";




			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{


					//string nombre = dataReader.GetString(1);
					int dni = dataReader.GetInt32(0);
					string nombredni = $"{dni}";



					Alumno alumno = new Alumno();

					alumno.dni = dataReader.GetInt32(0);

					

					//alumno.nombreapellido = nombredni;

					lista.Add(alumno);
				}
			}
			catch (Exception e)
			{

				throw new Exception("Error al obtener la lista de alumnos", e);
			}

			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}

			return lista;
		}
	}
}
