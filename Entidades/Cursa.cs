using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Cursa
	{
		#region Atributos
		private int Id;
		private int DNI_Alumno;
		private int Codigo_Materia;
		private int Nota;
		private string Condicion;

		public int id
		{
			get { return Id; }
			set { Id = value; }
		}

		public int dni_alumno
		{
			get { return DNI_Alumno; }
			set { DNI_Alumno = value; }
		}
		public int codigo_materia
		{
			get { return Codigo_Materia; }
			set { Codigo_Materia = value; }
		}

		public int nota
		{
			get { return Nota; }
			set { Nota = value; }
		}

		public string condicion
		{
			get { return Condicion; }
			set { Condicion = value; }
		}
		#endregion

		#region Constructores
		public Cursa()
		{

		}

		public Cursa(int id, int dni_Alumno, int cod_Materia, int nota, string condicion)
		{
			Id = id;
			DNI_Alumno = dni_Alumno;
			Codigo_Materia = cod_Materia;
			Nota = nota;
			Condicion = condicion;
		}

		#endregion
	}
}
