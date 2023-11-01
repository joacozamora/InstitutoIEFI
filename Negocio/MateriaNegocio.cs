using Entidades;
using Datos;
using System.Data;
using System.Collections.Generic;

namespace Negocio
{
	public class MateriaNegocio
	{
		ListaMateria objDatosMaterias = new ListaMateria();


		public int abmMateria(string accion, Materia objMateria)
		{
			return objDatosMaterias.abmMateria(accion, objMateria);
		}
		public DataSet listadoMateria(string categoria)
		{
			return objDatosMaterias.listadoMateria(categoria);
		}

		public List<Materia> ObtenerMateria()
		{
			return objDatosMaterias.ObtenerMateria();
		}

		//public DataSet listarMateriaBuscar(string cual)
		//{
		//    return objDatosMaterias.listarMateriaBuscar(cual);
		//}

		public DataSet ListaMateriaEliminar(string id)
		{
			return objDatosMaterias.ListaMateriaEliminar(id);
		}

	}
}