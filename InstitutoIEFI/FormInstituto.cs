using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace InstitutoIEFI
{
	public partial class FormInstituto : Form
	{
		Alumno NuevoAlumno;
		public FormInstituto()
		{
			InitializeComponent();
		}

		private void btn_CargarAlumno_Click(object sender, EventArgs e)
		{
			int nGrabados = -1;
			//string Analitico = Check_Analitico();
			DateTime fecha_nac = FechaNacAlumno.Value;
			//string fecha_nac = Fecha_Nacimiento(FechaNacimiento);

			NuevoAlumno = new Alumno(int.Parse(txb_dni.Text), txb_NomApAlumno.Text, fecha_nac, txb_email.Text, chbx_analitico.Enabled);

			//nGrabados = objNegProducto.abmProductos("Alta", NuevoProd);

			if (nGrabados == -1)
			{
				MessageBox.Show("No se pudo grabar el Producto en el sistema");

			}
			else
			{

				//nuevo = true;
				//LlenarDGV();
			}

			MessageBox.Show("Producto Instanciado"); 
		}
	}
}
