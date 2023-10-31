using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

			//if (accion == "Baja")

			//    orden = $"delete from Producto where Id = {objProducto.Id}";


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
	}
}
