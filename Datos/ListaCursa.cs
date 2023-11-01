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
				orden = $"insert into Cursa values ('{objCursa.id}','{objCursa.dni_alumno}','{objCursa.codigo_materia}','{objCursa.nota}','{objCursa.condicion}')";

			if (accion == "Modificar")
				orden = $"update Cursa set DNI_Alumno = '{objCursa.dni_alumno}' where Id = {objCursa.id};  update Cursa set Codigo_Materia = '{objCursa.codigo_materia}' where Id = {objCursa.id}; update Cursa set Nota = '{objCursa.nota}' where Id = {objCursa.id}; update Cursa set Condicion = '{objCursa.condicion}' where Id = {objCursa.id}; ";

			//if (accion == "Baja")
			//    orden = $"delete from Caja where Id = {objCaja.Id}";


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

			string orden = $"select c.Id, c.Nota, c.Condicion, a.NombreApellido, a.Fecha_Nac, a.Email, a.Analitico, m.Nombre, m.Año_Cursado, m.Dia_Cursado , m.Nombre_Carrera from Cursa as c inner join Alumno as a on c.DNI_Alumno=a.DNI inner join Materia as m on c.Codigo_Materia=m.Codigo";

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
