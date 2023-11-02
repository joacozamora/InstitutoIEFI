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

		public List<Alumno> ObtenerAlumno()
		{
			return objDatosAlumno.ObtenerAlumno();
		}

		public DataSet ListaProductoEliminar(string id)
		{
			return objDatosAlumno.ListaAlumnoEliminar(id);
		}
		public DataSet ListarAlumnoEliminar(string id)
		{
			return objDatosAlumno.ListaAlumnoEliminar(id);
		}
	}
}
/*
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

		public List<Alumno> ObtenerAlumno()
		{
			return objDatosAlumno.ObtenerAlumno();
		}

		

		public DataSet ListaProductoEliminar(string id)
		{
			return objDatosAlumno.ListaAlumnoEliminar(id);
		}
	}
}*/
