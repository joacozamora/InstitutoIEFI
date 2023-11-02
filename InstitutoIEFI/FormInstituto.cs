using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace InstitutoIEFI
{
	public partial class FormInstituto : Form
	{
		Alumno NuevoAlumno;
		public FormInstituto()
		{
			InitializeComponent();
			dgvAlumno.ColumnCount = 5;
			dgvAlumno.Columns[0].HeaderText = "DNI";
			dgvAlumno.Columns[1].HeaderText = "Nombre Apellido";
			dgvAlumno.Columns[2].HeaderText = "Fecha de Nacimiento";
			dgvAlumno.Columns[3].HeaderText = "Email";
			dgvAlumno.Columns[4].HeaderText = "Analitico";


			dgvMateria.ColumnCount = 5;
			dgvMateria.Columns[0].HeaderText = "Codigo";
			dgvMateria.Columns[1].HeaderText = "Nombre Materia";
			dgvMateria.Columns[2].HeaderText = "Año";
			dgvMateria.Columns[3].HeaderText = "Dia de Cursado";
			dgvMateria.Columns[4].HeaderText = "Carrera";

			dgvCursa.ColumnCount = 5;
			dgvCursa.Columns[0].HeaderText = "Id";
			dgvCursa.Columns[1].HeaderText = "DNI_Alumno";
			dgvCursa.Columns[2].HeaderText = "Codigo";
			dgvCursa.Columns[3].HeaderText = "Nota";
			dgvCursa.Columns[4].HeaderText = "Condicion";

			//cb_Condicion.Items.Add("Libre");
			//cb_Condicion.Items.Add("Regular");
			//cb_Condicion.Items.Add("Promocion");




			LlenarDGVAlumno();
			LlenarDGVMateria();
			LlenarDGVCursa();
			LlenarCombos();
			LlenarCombos2();
			btn_ModificarMateria.Visible = false;
			btn_ModificarAlumno.Visible = false;
			btn_ModificarCursado.Visible = false;
			dgvCursa.CellClick += new DataGridViewCellEventHandler(dgvCursa_CellClick);
			dgvAlumno.CellClick += new DataGridViewCellEventHandler(dgvAlumno_CellClick);
			dgvMateria.CellClick += new DataGridViewCellEventHandler(dgvMateria_CellClick);

		}

		public Alumno objEntAlumno = new Alumno();
		public Materia objEntMateria = new Materia();
		public Cursa objEntCursa = new Cursa();

		public AlumnoNegocio objNegAlumno = new AlumnoNegocio();
		public MateriaNegocio objNegMateria = new MateriaNegocio();
		public CursaNegocio objNegCursa = new CursaNegocio();

		#region Botones Cargar

		private void btn_CargarAlumno_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposAlumno();
			int nGrabados = -1;
			string dni = txb_dni.Text;

			DataSet ds = objNegAlumno.listadoAlumno(dni);

			if (ds.Tables[0].Rows.Count > 0)
			{
				
				MessageBox.Show("Ya existe un alumno con este DNI.");
			}
			else
			{
				if (validar == true)
				{
					Txb_a_ObjAlumno();
					nGrabados = objNegAlumno.abmAlumno("Alta", objEntAlumno);
					if (nGrabados == -1)
					{
						MessageBox.Show("No se logró agregar el Alumno al sistema");
					}
					else
					{
						MessageBox.Show("Se logró agregar al Alumno con éxito");
						LlenarDGVAlumno();
						LimpiarAlumno();
						LlenarCombos();
						tabControl1.SelectTab(tabAlumno);
					}
				}
			}
			
		}

		private void btn_CargarMateria_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposMateria();
			int nGrabados = -1;
			string cod = txb_CodMat.Text;

			DataSet ds = objNegMateria.listadoMateria(cod);

			if (ds.Tables[0].Rows.Count > 0)
			{
				
				MessageBox.Show("Ya existe una materia con este Codigo.");
			}
			else
			{
				if (validar == true)
				{
					Txb_a_ObjMateria();
					nGrabados = objNegMateria.abmMateria("Alta", objEntMateria);
					if (nGrabados == -1)
					{
						MessageBox.Show("No se logró agregar la Materia al sistema");
					}
					else
					{
						MessageBox.Show("Se logró agregar la Materia con éxito");
						LlenarDGVMateria();
						LimpiarMateria();
						LlenarCombos2();
						tabControl1.SelectTab(tabMateria);
					}
				}
			}
				
		}

		private void btn_CargarCursado_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposCursa();
			int nGrabados = -1;
			//int dniAlumno = int.Parse(cb_CursaAlumno.SelectedItem.ToString());
			//int codigoMateria = int.Parse(cb_CursaMateria.SelectedItem.ToString());
			//bool existeCursa = objNegCursa.ExisteCursa(dniAlumno, codigoMateria);
			////DataSet ds = objNegCursa.listadoCursa(dniAlumno.ToString(), codigoMateria.ToString());
			//if (existeCursa)
			//{
			//	MessageBox.Show("Este alumno ya tiene su nota final cargada.");
			//}
			//else
			//{
				if (validar == true)
				{
					Txb_a_ObjCursa();
					nGrabados = objNegCursa.abmCursa("Alta", objEntCursa);
					if (nGrabados == -1)
					{
						MessageBox.Show("No se logró agregar el Cursado al sistema");
					}
					else
					{
						MessageBox.Show("Se logró agregar el Cursado con éxito");
						LlenarDGVCursa();
						LimpiarCursa();
						tabControl1.SelectTab(tabCursa);

					}
				}
			

		}

		#endregion

		#region DGV

		private void LlenarDGVAlumno()
		{
			dgvAlumno.Rows.Clear();
			DataSet ds = new DataSet();
			ds = objNegAlumno.listadoAlumno("Todos");
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					dgvAlumno.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString(), dr[3], dr[4].ToString());
				}
			}
		}

		private void LlenarDGVMateria()
		{
			dgvMateria.Rows.Clear();
			DataSet ds = new DataSet();
			ds = objNegMateria.listadoMateria("Todos");
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					dgvMateria.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString(), dr[3], dr[4]);
				}
			}
		}

		private void LlenarDGVCursa()
		{

			dgvCursa.Rows.Clear();
			DataSet ds = new DataSet();
			ds = objNegCursa.Unir();
			if (ds.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					dgvCursa.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4]);
				}
			}
		}

		private void LimpiarAlumno()
		{
			txb_NomApAlumno.Text = string.Empty;
			txb_dni.Text = string.Empty;
			txb_email.Text = string.Empty;
			FechaNacAlumno.Value = DateTime.Today;
			
		}

		private void LimpiarMateria()
		{
			txb_CodMat.Text = string.Empty;
			txb_NombreMateria.Text = string.Empty;
			txb_DiaCursado.Text = string.Empty;
			txb_NombreCarrera.Text = string.Empty;
			
		}

		private void LimpiarCursa()
		{
			txb_Nota.Text = string.Empty;
			cb_CursaAlumno.SelectedIndex = 0;
			cb_CursaMateria.SelectedIndex = 0;
			cb_Condicion.SelectedIndex = 0;
			
		}
		#endregion

		#region Validaciones

		public bool ValidacionCamposAlumno()
		{
			// Nombre
			if (txb_NomApAlumno.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un nombre de Alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NomApAlumno.Text.Length > 50 || txb_NomApAlumno.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten nombres de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			//DNI Alumno
			if (txb_dni.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_dni.Text.Length > 8 || txb_dni.Text.Length < 7)
			{
				MessageBox.Show("Solo se permiten DNI entre 7 y 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			string expresionEmail = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";
			bool valido = Regex.IsMatch(txb_email.Text, expresionEmail);

			//Email
			/*if (txb_email.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un Email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (!valido)
			{
				MessageBox.Show("Solo se permiten emails validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 30)
			{
				MessageBox.Show("La observación no puede superar los 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}*/
			return true;
			// Nombre
			/*if (txb_NomApAlumno.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un nombre de Alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NomApAlumno.Text.Length > 50 || txb_NomApAlumno.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten nombres de 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}



			//DNI Alumno
			if (txb_dni.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_dni.Text.Length > 50 || txb_dni.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten DNI entre 7 y 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			//Email
			if (txb_email.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un Email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 50 || txb_email.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten emails validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 30)
			{
				MessageBox.Show("La observación no puede superar los 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
			*/

		}

		public bool ValidacionCamposMateria()
		{
			string expresionCodigo = "^[a-zA-Z]{3}\\d{3}$\r\n";
			bool valido = Regex.IsMatch(txb_CodMat.Text, expresionCodigo);
			// Codigo Materia
			if (txb_CodMat.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un Codigo de materia valido, ej MAT123", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_CodMat.Text.Length < 6)
			{
				MessageBox.Show("El codigo necesita 6 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}



			//Nombre Materia
			if (txb_NombreMateria.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un nombre valido para la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NombreMateria.Text.Length > 50 || txb_NombreMateria.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten nombres entre 10 y 15 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			/*
			//Año
			if (num_AñoMateria.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un año valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 50 || txb_email.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten emails validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 30)
			{
				MessageBox.Show("La observación no puede superar los 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}*/

			//Dia Cursado

			if (txb_DiaCursado.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un dia valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_DiaCursado.Text.Length > 50 || txb_DiaCursado.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten dias validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			// Nombre Carrera

			if (txb_NombreCarrera.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una carrera valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NombreCarrera.Text.Length > 50 || txb_NombreCarrera.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten carreras hasta 30 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
			/*
			// Codigo Materia
			if (txb_CodMat.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un Codigo de materia valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			//else if (txb_NomApAlumno.Text.Length > 50 || txb_NomApAlumno.Text.Length < 2)
			//{
			//	MessageBox.Show("Solo se permiten codigos de 4 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//	return false;
			//}



			//Nombre Materia
			if (txb_NombreMateria.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un nombre valido para la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NombreMateria.Text.Length > 50 || txb_NombreMateria.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten nombres entre 10 y 15 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			//Año
			/*if (num_AñoMateria.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un año valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_email.Text.Length > 50 || txb_email.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten emails validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			/*else if (txb_email.Text.Length > 30)
			{
				MessageBox.Show("La observación no puede superar los 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//Dia Cursado

			if (txb_DiaCursado.Text == string.Empty)
			{
				MessageBox.Show("Ingrese un dia valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_DiaCursado.Text.Length > 50 || txb_DiaCursado.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten dias validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			// Nombre Carrera

			if (txb_NombreCarrera.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una carrera valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_NombreCarrera.Text.Length > 50 || txb_NombreCarrera.Text.Length < 2)
			{
				MessageBox.Show("Solo se permiten carreras hasta 30 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
			*/

		}

		public bool ValidacionCamposCursa()
		{
			if (txb_Nota.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una nota valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_Nota.Text.Length > 2 || txb_Nota.Text.Length < 1)
			{
				MessageBox.Show("Solo se permiten notas del 1 al 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (txb_Nota.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una nota valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_Nota.Text.Length > 2 || txb_Nota.Text.Length < 1)
			{
				MessageBox.Show("Solo se permiten notas del 1 al 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			return true;
			/*
			if (txb_Nota.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una nota valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_Nota.Text.Length > 2 || txb_Nota.Text.Length < 1)
			{
				MessageBox.Show("Solo se permiten notas del 1 al 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (txb_Nota.Text == string.Empty)
			{
				MessageBox.Show("Ingrese una nota valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (txb_Nota.Text.Length > 2 || txb_Nota.Text.Length < 1)
			{
				MessageBox.Show("Solo se permiten notas del 1 al 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			return true;*/
		}

		private void txb_NomApAlumno_KeyPress(object sender, KeyPressEventArgs e)
		{
			//evitar que escriba numeros
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			//evitar que escriba muchos letras
			if (txb_NomApAlumno.Text.Length >= 30)
			{
				e.Handled = true;
			}
		}

		private void txb_dni_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				// No bloquear teclas de control
				e.Handled = false;
				return;
			}
			//comprobar que solo escriba numeros
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true; return;
			}

			//evitar que escriba mas de 10 numeros
			if (txb_dni.Text.Length >= 9)
			{
				e.Handled = true;
			}
		}

		private void txb_CodMat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				// No bloquear teclas de control
				e.Handled = false;
				return;
			}

			//evitar que escriba mas de 6 numeros
			if (txb_CodMat.Text.Length >= 6)
			{
				e.Handled = true;
			}
		}

		private void txb_Nota_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				// No bloquear teclas de control
				e.Handled = false;
				return;
			}
			//comprobar que solo escriba numeros
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true; return;
			}

			//evitar que escriba mas de 1 numero
			if (txb_Nota.Text.Length > 1)
			{
				e.Handled = true;
			}
		}



		#endregion

		#region METODOS Texto a Objeto
		private void Txb_a_ObjAlumno()
		{
			objEntAlumno.dni = int.Parse(txb_dni.Text);
			objEntAlumno.nombreapellido = txb_NomApAlumno.Text;

			// Validar la fecha ingresada
			DateTime fechaNac;
			if (DateTime.TryParse(FechaNacAlumno.Value.ToString(), out fechaNac))
			{
				objEntAlumno.fecha_nac = fechaNac;
			}
			else
			{
				// Mostrar un mensaje de error o realizar alguna acción para manejar la fecha no válida.
				MessageBox.Show("La fecha ingresada no es válida.");
				return; // Puedes salir del método aquí para evitar guardar datos incorrectos.
			}

			objEntAlumno.email = txb_email.Text;
			objEntAlumno.analitico = chbx_analitico.Checked;
			//objEntAlumno.dni = int.Parse(txb_dni.Text);
			//objEntAlumno.nombreapellido = txb_NomApAlumno.Text;
			//objEntAlumno.fecha_nac = DateTime.TryParse(FechaNacAlumno.Value);
			//objEntAlumno.email = txb_email.Text;
			//objEntAlumno.analitico = chbx_analitico.Checked;


		}

		private void Txb_a_ObjMateria()
		{
			objEntMateria.id = int.Parse(txb_CodMat.Text);
			objEntMateria.nombre = txb_NombreMateria.Text;
			objEntMateria.año_cursado = int.Parse(num_AñoMateria.Text);
			objEntMateria.dia_cursado = txb_DiaCursado.Text;
			objEntMateria.nombre_carrera = txb_NombreCarrera.Text;


		}

		private void Txb_a_ObjCursa()
		{
			//objEntCursa.id = int.Parse(txb_id.Text);
			objEntCursa.nota = int.Parse(txb_Nota.Text);
			objEntCursa.condicion = cb_Condicion.Text.ToString();
			objEntCursa.dni_alumno = int.Parse(cb_CursaAlumno.SelectedValue.ToString());
			objEntCursa.codigo_materia = int.Parse(cb_CursaMateria.SelectedValue.ToString());


		}


		#endregion

		#region Llenar Combos
		private void LlenarCombos()
		{
			cb_CursaAlumno.DataSource = objNegAlumno.ObtenerAlumno();
			cb_CursaAlumno.DisplayMember = "DNI";
			cb_CursaAlumno.ValueMember = "DNI";
		}

		private void LlenarCombos2()
		{
			cb_CursaMateria.DataSource = objNegMateria.ObtenerMateria();
			cb_CursaMateria.DisplayMember = "Codigo";
			cb_CursaMateria.ValueMember = "Id";
		}


		#endregion

		private void FormInstituto_Load(object sender, EventArgs e)
		{

		}

		#region Modificar
		private void btn_ModificarAlumno_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposAlumno();
			int nResultado = -1;
			if (validar == true)
			{
				Txb_a_ObjAlumno();
				nResultado = objNegAlumno.abmAlumno("Modificar", objEntAlumno);
				if (nResultado != -1)
				{
					MessageBox.Show("el Alumno fue modificada con éxito");
					LimpiarAlumno();
					LlenarDGVAlumno();
					LlenarCombos();
					
				}
				else
				{
					MessageBox.Show("Se produjo un error al intentar modificar el Alumno");
				}
			}

		}



		private void btn_ModificarMateria_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposMateria();
			int nResultado = -1;
			if (validar == true)
			{
				Txb_a_ObjMateria();
				nResultado = objNegMateria.abmMateria("Modificar", objEntMateria);
				if (nResultado != -1)
				{
					MessageBox.Show("La materia fue modificada con éxito");
					LimpiarMateria();
					LlenarDGVMateria();
					LlenarCombos2();
					
				}
				else
				{
					MessageBox.Show("Se produjo un error al intentar modificar la Materia");
				}
			}
		}

		private void btn_ModificarCursado_Click(object sender, EventArgs e)
		{
			bool validar = ValidacionCamposCursa();
			int nResultado = -1;
			if (validar == true)
			{
				Txb_a_ObjCursa();
				nResultado = objNegCursa.abmCursa("Modificar", objEntCursa);
				if (nResultado != -1)
				{
					MessageBox.Show("El cursado del alumno fue modificado con éxito");
					LimpiarCursa();
					LlenarDGVCursa();
					
				}
				else
				{
					MessageBox.Show("Se produjo un error al intentar modificar el cursado");
				}
			}
		}
		#endregion

		private void dgvCursa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txb_id.Text = dgvCursa.Rows[e.RowIndex].Cells[0].Value.ToString();
				object dniValue = dgvCursa.Rows[e.RowIndex].Cells[1].Value;
				object codigoValue = dgvCursa.Rows[e.RowIndex].Cells[2].Value;
				object notaValue = dgvCursa.Rows[e.RowIndex].Cells[3].Value;
				
				int index = cb_CursaAlumno.FindStringExact(dniValue.ToString());
				int indexa = cb_CursaMateria.FindStringExact(codigoValue.ToString());
				
				txb_Nota.Text = notaValue.ToString();

				
				if (index != -1)
				{
					cb_CursaAlumno.SelectedIndex = index;
				}
				if (indexa != -1)
				{
					cb_CursaMateria.SelectedIndex = indexa;
				}
				
				string valorCelda = dgvCursa.Rows[e.RowIndex].Cells[4].Value.ToString(); // Obtiene el valor de la cuarta columna

				// Busca y selecciona el valor en el ComboBox cb_Condicion
				if (cb_Condicion.Items.Contains(valorCelda))
				{
					cb_Condicion.SelectedItem = valorCelda;
				}
				btn_ModificarCursado.Visible = true;

			}
				/*DataGridViewRow fila = dgvCursa.Rows[e.RowIndex];
				string valorDNI = fila.Cells[1].Value.ToString();
				string valorMateria = fila.Cells[2].Value.ToString();*/

				// Establece el valor seleccionado en el ComboBox del alumno.
				//cb_CursaAlumno.SelectedValue = fila.Cells[1].Value.ToString();

				// Establece el valor seleccionado en el ComboBox de la materia.
				//cb_CursaMateria.SelectedValue = valorMateria;
			
			/*DataGridViewRow fila = dgvCursa.Rows[e.RowIndex];
			cb_CursaAlumno.SelectedItem = fila.Cells[1].Value;
			cb_CursaMateria.SelectedItem = fila.Cells[1].Value;
			*/
		}
		

		private void dgvAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvAlumno.Rows[e.RowIndex];
				txb_dni.Text = fila.Cells[0].Value.ToString(); 
				txb_NomApAlumno.Text = fila.Cells[1].Value.ToString(); 
				FechaNacAlumno.Value = Convert.ToDateTime(fila.Cells[2].Value); 
				txb_email.Text = fila.Cells[3].Value.ToString(); 
				chbx_analitico.Checked = Convert.ToBoolean(fila.Cells[4].Value);
				btn_ModificarAlumno.Visible = true;
			}
		}

		private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvMateria.Rows[e.RowIndex];

				
				txb_CodMat.Text = row.Cells[0].Value.ToString();
				txb_NombreMateria.Text = row.Cells[1].Value.ToString();
				num_AñoMateria.Text = row.Cells[2].Value.ToString();
				txb_DiaCursado.Text = row.Cells[3].Value.ToString();
				txb_NombreCarrera.Text = row.Cells[4].Value.ToString();
				btn_ModificarMateria.Visible = true;
			}
		}

		private void EliminarAlumno_Click(object sender, EventArgs e)
		{
			if (true)
			{

				DgEliminarAlumnoDNI();

				LlenarDGVAlumno();

				MessageBox.Show("Se elimino el alumno");
			}
		}

		public void DgEliminarAlumnoDNI()
		{
			DataRow DNIAEliminar = null;
			DataSet ds = objNegAlumno.listadoAlumno("Todos");
			DateTime fechaNacimiento = DateTime.MinValue;
			string dniAlumno = txb_dni.Text;

			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[0].ToString() == dniAlumno)
				{
					DNIAEliminar = dr;
					break;
				}
			}

			if (DNIAEliminar != null)
			{
				int dni = int.Parse(DNIAEliminar[0].ToString());

				Alumno producto = new Alumno(dni, null, fechaNacimiento, null, false); // Ajusta los valores adecuados en el constructor de Productos

				int resultado = objNegAlumno.abmAlumno("Borrar", producto);

				if (resultado > 0)
				{
					MessageBox.Show("Alumno eliminado correctamente");
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Alumno");
				}
			}
			else
			{
				MessageBox.Show("El Alumno no se encontró en la lista");
			}
		}


		private void btn_EliminarMateria_Click(object sender, EventArgs e)
			{
				if (true)
				{

					DgEliminarMateriaId();

					LlenarDGVMateria();

					MessageBox.Show("Se eliminaron los detalles del Movimiento");
				}
			}
		public void DgEliminarMateriaId()
		{
			DataRow codAEliminar = null;
			DataSet ds = objNegMateria.listadoMateria("Todos");
			DateTime fechaNacimiento = DateTime.MinValue;
			string codmat = txb_CodMat.Text;

			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[0].ToString() == codmat)
				{
					codAEliminar = dr;
					break;
				}
			}

			if (codAEliminar != null)
			{
				int cod = int.Parse(codAEliminar[0].ToString());

				Materia materia = new Materia(cod, null, 0, null, null); // Ajusta los valores adecuados en el constructor de Productos

				int resultado = objNegMateria.abmMateria("Borrar", materia);

				if (resultado > 0)
				{
					MessageBox.Show("Materia eliminado correctamente");
				}
				else
				{
					MessageBox.Show("No se pudo eliminar  Materia");
				}
			}
			else
			{
				MessageBox.Show("La materia no se encontró en la lista");
			}
		}

		private void btn_EliminarCursa_Click(object sender, EventArgs e)
		{
			DataRow DNIAEliminar = null;
			DataSet ds = objNegCursa.listadoCursa("Todos");
			DateTime fechaNacimiento = DateTime.MinValue;
			string dniAlumno = cb_CursaAlumno.SelectedValue.ToString();

			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[1].ToString() == dniAlumno)
				{
					DNIAEliminar = dr;
					break;
				}
			}

			if (DNIAEliminar != null)
			{
				int dni = int.Parse(DNIAEliminar[1].ToString());

				Cursa cursa = new Cursa(0,dni, 0, 0, null); // Ajusta los valores adecuados en el constructor de Productos

				int resultado = objNegCursa.abmCursa("Borrar", cursa);

				if (resultado > 0)
				{
					MessageBox.Show("Cursa eliminado correctamente");
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Cursa");
				}
			}
			else
			{
				MessageBox.Show("El Cursa no se encontró en la lista");
			}
		}
	}
}
