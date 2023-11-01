using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Negocio
{
	public class CursaNegocio
	{
		ListaCursa objDatosCursa = new ListaCursa();

		public int abmCursa(string accion, Cursa objCursa)
		{
			return objDatosCursa.abmCursa(accion, objCursa);
		}

		public DataSet listadoCursa(string categoria)
		{
			return objDatosCursa.listadoCursa(categoria);
		}

		public DataSet Unir()
		{
			return objDatosCursa.Unir();
		}

		public bool ExisteCursa(int dniAlumno, int codigoMateria)
		{
			// Lógica para verificar si la combinación de DNI y materia ya existe en la tabla Cursa.
			// Utiliza un método en la capa de datos para realizar la consulta SQL.
			return objDatosCursa.ExisteCursa(dniAlumno, codigoMateria);
		}
		public DataSet ListaProductoEliminar(string id)
		{
			return objDatosCursa.ListaCursaEliminar(id);
		}
	}
}
