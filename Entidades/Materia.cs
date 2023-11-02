using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
namespace Entidades
{
	public class Materia
	{
		#region Atributos
		private int Codigo;
		private string Nombre;
		private int Año_Cursado;
		private string Dia_Cursado;
		private string Nombre_Carrera;
		#endregion

		#region propiedades
		public int codigo
		{
			get { return Codigo; }
			set { Codigo = value; }
		}

		public string nombre
		{
			get { return Nombre; }
			set { Nombre = value; }
		}
		public int año_cursado
		{
			get { return Año_Cursado; }
			set { Año_Cursado = value; }
		}
		public string dia_cursado
		{
			get { return Dia_Cursado; }
			set { Dia_Cursado = value; }
		}

		public string nombre_carrera
		{
			get { return Nombre_Carrera; }
			set { Nombre_Carrera = value; }
		}
		#endregion


		#region Constructores
		public Materia()
		{ }
		public Materia(int cod, string nom, int año, string dia_clases, string carrera)
		{
			Codigo = cod;
			Nombre = nom;
			Año_Cursado = año;
			Dia_Cursado = dia_clases;
			Nombre_Carrera = carrera;

		}
		#endregion
	}
}*/
namespace Entidades
{
	public class Materia
	{
		#region Atributos
		private int Codigo;
		private string Nombre;
		private int Año_Cursado;
		private string Dia_Cursado;
		private string Nombre_Carrera;
		#endregion

		#region propiedades
		public int id
		{
			get { return Codigo; }
			set { Codigo = value; }
		}

		public string nombre
		{
			get { return Nombre; }
			set { Nombre = value; }
		}
		public int año_cursado
		{
			get { return Año_Cursado; }
			set { Año_Cursado = value; }
		}
		public string dia_cursado
		{
			get { return Dia_Cursado; }
			set { Dia_Cursado = value; }
		}

		public string nombre_carrera
		{
			get { return Nombre_Carrera; }
			set { Nombre_Carrera = value; }
		}
		#endregion


		#region Constructores
		public Materia()
		{ }
		public Materia(int cod, string nom, int año, string dia_clases, string carrera)
		{
			Codigo = cod;
			Nombre = nom;
			Año_Cursado = año;
			Dia_Cursado = dia_clases;
			Nombre_Carrera = carrera;

		}
		#endregion
	}
}
