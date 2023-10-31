using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class DatosConexionBD
	{
		protected SqlConnection conexion;
		protected string cadenaConexion = @"Data Source=LAPTOP-ET77U67F;Initial Catalog=IEFI_programacion;Integrated Security=True";
		// JOACO = Data Source=LAPTOP-ET77U67F;Initial Catalog=IEFI_programacion;Integrated Security=True

		// LUCAS = Data Source = DESKTOP - 147O4T7\SQLEXPRESS;Initial Catalog=IEFI_programacion;Integrated Security=True
		public DatosConexionBD()
		{
			conexion = new SqlConnection(cadenaConexion);
		}
		public void Abrirconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Broken || conexion.State ==
			   ConnectionState.Closed)
					conexion.Open();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de abrir la conexión", e);
			}
		}


		public void Cerrarconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Open)
					conexion.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de cerrar la conexión", e);
			}
		}
	}

}
