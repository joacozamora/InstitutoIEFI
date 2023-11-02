using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/*
namespace Datos
{
	public class ListaMateria : DatosConexionBD
	{
		public int abmMateria(string accion, Materia objMateria)
		{
			int resultado = -1;
			string orden = string.Empty;

			if (accion == "Alta")
			{
				orden = $"INSERT INTO Materia VALUES('{objMateria.codigo}','{objMateria.nombre}','{objMateria.año_cursado}','{objMateria.dia_cursado}','{objMateria.nombre_carrera}')";
			}

			if (accion == "Modificar")
			{
				orden = $"UPDATE Materia SET Nombre = '{objMateria.nombre}' WHERE Codigo = {objMateria.codigo}; UPDATE Materia SET Año_Cursado = '{objMateria.año_cursado}' WHERE Codigo = {objMateria.codigo}; UPDATE Materia SET Dia_Cursado = '{objMateria.dia_cursado}' WHERE Codigo = {objMateria.codigo}; UPDATE Materia SET Nombre_Carrera = '{objMateria.nombre_carrera}' WHERE Codigo = {objMateria.codigo}; ";
			}

			if (accion == "Baja")
			{
				orden = $"DELETE FROM Materia WHERE Materia.Codigo = {objMateria.codigo}";
			}

			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar, borrar o modificar {objMateria} ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public DataSet listadoMateria(string id)
		{
			string orden = string.Empty;

			if (id != "Todos")
			{
				orden = $"SELECT * FROM Materia WHERE Codigo = {int.Parse(id)};";
			}
			else
			{
				orden = "SELECT * FROM Materia;";
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
				throw new Exception("Error al listar Materias", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
		}

		public DataSet ListaMateriaEliminar(string id)
		{
			string orden = $"DELETE FROM Materia WHERE Codigo = {id};";

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
				throw new Exception("Error al eliminar la materia", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}

		public List<Materia> ObtenerMateria()
		{
			List<Materia> lista = new List<Materia>();

			string OrdenEjecucion = "SELECT Codigo, Nombre , Año_Cursado , Dia_Cursado , Nombre_Carrera FROM Materia";

			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{
					int codigo = dataReader.GetInt32(0);
					string nombre = dataReader.GetString(1);
					string nombremateria = $"{codigo}";
					//string nombremateria = $"{nombre},{codigo}";

					Materia materia = new Materia();

					materia.codigo = dataReader.GetInt32(0);

					//materia.nombre = nombremateria;

					lista.Add(materia);
				}
			}
			catch (Exception e)
			{
				throw new Exception("Error al obtener la lista de la materia para agregar al alumno", e);
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
*/
namespace Datos
{
	public class ListaMateria : DatosConexionBD
	{

		public int abmMateria(string accion, Materia objMateria)
		{


			int resultado = -1;
			string orden = string.Empty;
			if (accion == "Alta")

				orden = $"insert into Materia values ('{objMateria.id}','{objMateria.nombre}','{objMateria.año_cursado}','{objMateria.dia_cursado}','{objMateria.nombre_carrera}')";

			if (accion == "Modificar")
				orden = $"update Materia set Nombre = '{objMateria.nombre}' where Codigo = {objMateria.id}; update Materia set Año_Cursado = '{objMateria.año_cursado}' where Codigo = {objMateria.id}; update Materia set Dia_Cursado = '{objMateria.dia_cursado}' where Codigo = {objMateria.id}; update Materia set Nombre_Carrera = '{objMateria.nombre_carrera}' where Codigo = {objMateria.id}; "; //;// update Producto set ExisteProducto = {objProducto.ExisteProducto} where id = {objProducto.IdProducto}; ";

			if (accion == "Borrar")

			    orden = $"delete from Materia where Codigo = {objMateria.id}";


			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar,borrar o modificar {objMateria} ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public DataSet listadoMateria(string id)
		{
			string orden = string.Empty;
			if (id != "Todos")
				orden = $"select * from Materia where Codigo = {int.Parse(id)};";
			else
				orden = "select * from Materia;";
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
				throw new Exception("Error al listar Materias", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			//return ds;
		}

		public DataSet ListaMateriaEliminar(string id)
		{
			string orden = $"delete from Materia where Codigo = {id};";

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
				throw new Exception("Error al eliminar la materia", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}

		public List<Materia> ObtenerMateria()
		{
			List<Materia> lista = new List<Materia>();

			string OrdenEjecucion = "Select Codigo, Nombre , Año_Cursado , Dia_Cursado ,  Nombre_Carrera from Materia";

			SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

			SqlDataReader dataReader;

			try
			{
				Abrirconexion();

				dataReader = cmd.ExecuteReader();

				while (dataReader.Read())
				{


					int codigo = dataReader.GetInt32(0);
					string nombremateria = $"{codigo}";

					Materia materia = new Materia();

					materia.id = codigo;

					lista.Add(materia);

				}
			}
			catch (Exception e)
			{

				throw new Exception("Error al obtener la lista de la materia para agregar al alumno", e);
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
