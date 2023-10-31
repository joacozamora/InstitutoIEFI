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
	public class AlumnoNegocio
	{
		ListaAlumno objDatosAlumno = new ListaAlumno();

		public int abmAlumno(string accion, Alumno objAlumno)
		{
			return objDatosAlumno.abmAlumno(accion, objAlumno);
		}

		public DataSet listadoAlumno(string categoria)
		{
			return objDatosAlumno.listadoAlumno(categoria);
		}

		public DataSet ListaProductoEliminar(string id)
		{
			return objDatosAlumno.ListaAlumnoEliminar(id);
		}
	}
}
