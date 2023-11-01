namespace InstitutoIEFI
{
	partial class FormInstituto
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAlumno = new System.Windows.Forms.TabPage();
            this.btn_CargarAlumno = new System.Windows.Forms.Button();
            this.chbx_analitico = new System.Windows.Forms.CheckBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.FechaNacAlumno = new System.Windows.Forms.DateTimePicker();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_NomApAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.btn_CargarMateria = new System.Windows.Forms.Button();
            this.txb_NombreCarrera = new System.Windows.Forms.TextBox();
            this.num_AñoMateria = new System.Windows.Forms.NumericUpDown();
            this.txb_DiaCursado = new System.Windows.Forms.TextBox();
            this.txb_NombreMateria = new System.Windows.Forms.TextBox();
            this.txb_CodMat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCursa = new System.Windows.Forms.TabPage();
            this.cb_Condicion = new System.Windows.Forms.ComboBox();
            this.cb_CursaMateria = new System.Windows.Forms.ComboBox();
            this.cb_CursaAlumno = new System.Windows.Forms.ComboBox();
            this.btn_CargarCursado = new System.Windows.Forms.Button();
            this.txb_Nota = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.dgvCursa = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabAlumno.SuspendLayout();
            this.tabMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AñoMateria)).BeginInit();
            this.tabCursa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlumno);
            this.tabControl1.Controls.Add(this.tabMateria);
            this.tabControl1.Controls.Add(this.tabCursa);
            this.tabControl1.Location = new System.Drawing.Point(26, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 185);
            this.tabControl1.TabIndex = 6;
            // 
            // tabAlumno
            // 
            this.tabAlumno.Controls.Add(this.btn_CargarAlumno);
            this.tabAlumno.Controls.Add(this.chbx_analitico);
            this.tabAlumno.Controls.Add(this.txb_email);
            this.tabAlumno.Controls.Add(this.FechaNacAlumno);
            this.tabAlumno.Controls.Add(this.txb_dni);
            this.tabAlumno.Controls.Add(this.txb_NomApAlumno);
            this.tabAlumno.Controls.Add(this.label4);
            this.tabAlumno.Controls.Add(this.label1);
            this.tabAlumno.Controls.Add(this.label3);
            this.tabAlumno.Controls.Add(this.label2);
            this.tabAlumno.Location = new System.Drawing.Point(4, 22);
            this.tabAlumno.Name = "tabAlumno";
            this.tabAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumno.Size = new System.Drawing.Size(900, 159);
            this.tabAlumno.TabIndex = 0;
            this.tabAlumno.Text = "Alumno";
            this.tabAlumno.UseVisualStyleBackColor = true;
            // 
            // btn_CargarAlumno
            // 
            this.btn_CargarAlumno.Location = new System.Drawing.Point(56, 82);
            this.btn_CargarAlumno.Name = "btn_CargarAlumno";
            this.btn_CargarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAlumno.TabIndex = 10;
            this.btn_CargarAlumno.Text = "Cargar";
            this.btn_CargarAlumno.UseVisualStyleBackColor = true;
            this.btn_CargarAlumno.Click += new System.EventHandler(this.btn_CargarAlumno_Click);
            // 
            // chbx_analitico
            // 
            this.chbx_analitico.AutoSize = true;
            this.chbx_analitico.Location = new System.Drawing.Point(777, 41);
            this.chbx_analitico.Name = "chbx_analitico";
            this.chbx_analitico.Size = new System.Drawing.Size(66, 17);
            this.chbx_analitico.TabIndex = 9;
            this.chbx_analitico.Text = "Analitico";
            this.chbx_analitico.UseVisualStyleBackColor = true;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(590, 41);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(118, 20);
            this.txb_email.TabIndex = 8;
            // 
            // FechaNacAlumno
            // 
            this.FechaNacAlumno.Location = new System.Drawing.Point(353, 41);
            this.FechaNacAlumno.Name = "FechaNacAlumno";
            this.FechaNacAlumno.Size = new System.Drawing.Size(200, 20);
            this.FechaNacAlumno.TabIndex = 7;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(200, 42);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(118, 20);
            this.txb_dni.TabIndex = 6;
            this.txb_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_dni_KeyPress);
            // 
            // txb_NomApAlumno
            // 
            this.txb_NomApAlumno.Location = new System.Drawing.Point(11, 42);
            this.txb_NomApAlumno.Name = "txb_NomApAlumno";
            this.txb_NomApAlumno.Size = new System.Drawing.Size(147, 20);
            this.txb_NomApAlumno.TabIndex = 5;
            this.txb_NomApAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_NomApAlumno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // tabMateria
            // 
            this.tabMateria.Controls.Add(this.btn_CargarMateria);
            this.tabMateria.Controls.Add(this.txb_NombreCarrera);
            this.tabMateria.Controls.Add(this.num_AñoMateria);
            this.tabMateria.Controls.Add(this.txb_DiaCursado);
            this.tabMateria.Controls.Add(this.txb_NombreMateria);
            this.tabMateria.Controls.Add(this.txb_CodMat);
            this.tabMateria.Controls.Add(this.label10);
            this.tabMateria.Controls.Add(this.label9);
            this.tabMateria.Controls.Add(this.label8);
            this.tabMateria.Controls.Add(this.label7);
            this.tabMateria.Controls.Add(this.label6);
            this.tabMateria.Location = new System.Drawing.Point(4, 22);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria.Size = new System.Drawing.Size(815, 159);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Materias";
            this.tabMateria.UseVisualStyleBackColor = true;
            // 
            // btn_CargarMateria
            // 
            this.btn_CargarMateria.Location = new System.Drawing.Point(61, 107);
            this.btn_CargarMateria.Name = "btn_CargarMateria";
            this.btn_CargarMateria.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarMateria.TabIndex = 12;
            this.btn_CargarMateria.Text = "Cargar";
            this.btn_CargarMateria.UseVisualStyleBackColor = true;
            this.btn_CargarMateria.Click += new System.EventHandler(this.btn_CargarMateria_Click);
            // 
            // txb_NombreCarrera
            // 
            this.txb_NombreCarrera.Location = new System.Drawing.Point(693, 57);
            this.txb_NombreCarrera.Name = "txb_NombreCarrera";
            this.txb_NombreCarrera.Size = new System.Drawing.Size(90, 20);
            this.txb_NombreCarrera.TabIndex = 11;
            // 
            // num_AñoMateria
            // 
            this.num_AñoMateria.Location = new System.Drawing.Point(354, 56);
            this.num_AñoMateria.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.num_AñoMateria.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.num_AñoMateria.Name = "num_AñoMateria";
            this.num_AñoMateria.Size = new System.Drawing.Size(120, 20);
            this.num_AñoMateria.TabIndex = 10;
            this.num_AñoMateria.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // txb_DiaCursado
            // 
            this.txb_DiaCursado.Location = new System.Drawing.Point(518, 57);
            this.txb_DiaCursado.Name = "txb_DiaCursado";
            this.txb_DiaCursado.Size = new System.Drawing.Size(90, 20);
            this.txb_DiaCursado.TabIndex = 9;
            // 
            // txb_NombreMateria
            // 
            this.txb_NombreMateria.Location = new System.Drawing.Point(207, 57);
            this.txb_NombreMateria.Name = "txb_NombreMateria";
            this.txb_NombreMateria.Size = new System.Drawing.Size(90, 20);
            this.txb_NombreMateria.TabIndex = 8;
            // 
            // txb_CodMat
            // 
            this.txb_CodMat.Location = new System.Drawing.Point(51, 57);
            this.txb_CodMat.Name = "txb_CodMat";
            this.txb_CodMat.Size = new System.Drawing.Size(100, 20);
            this.txb_CodMat.TabIndex = 7;
            this.txb_CodMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_CodMat_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre de Carrera";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dia de cursado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // tabCursa
            // 
            this.tabCursa.Controls.Add(this.cb_Condicion);
            this.tabCursa.Controls.Add(this.cb_CursaMateria);
            this.tabCursa.Controls.Add(this.cb_CursaAlumno);
            this.tabCursa.Controls.Add(this.btn_CargarCursado);
            this.tabCursa.Controls.Add(this.txb_Nota);
            this.tabCursa.Controls.Add(this.label14);
            this.tabCursa.Controls.Add(this.label13);
            this.tabCursa.Controls.Add(this.label12);
            this.tabCursa.Controls.Add(this.label11);
            this.tabCursa.Location = new System.Drawing.Point(4, 22);
            this.tabCursa.Name = "tabCursa";
            this.tabCursa.Size = new System.Drawing.Size(900, 159);
            this.tabCursa.TabIndex = 2;
            this.tabCursa.Text = "Cursado";
            this.tabCursa.UseVisualStyleBackColor = true;
            // 
            // cb_Condicion
            // 
            this.cb_Condicion.FormattingEnabled = true;
            this.cb_Condicion.Items.AddRange(new object[] {
            "Libre",
            "Regular",
            "Promocion"});
            this.cb_Condicion.Location = new System.Drawing.Point(471, 63);
            this.cb_Condicion.Name = "cb_Condicion";
            this.cb_Condicion.Size = new System.Drawing.Size(121, 21);
            this.cb_Condicion.TabIndex = 19;
            // 
            // cb_CursaMateria
            // 
            this.cb_CursaMateria.FormattingEnabled = true;
            this.cb_CursaMateria.Location = new System.Drawing.Point(208, 64);
            this.cb_CursaMateria.Name = "cb_CursaMateria";
            this.cb_CursaMateria.Size = new System.Drawing.Size(121, 21);
            this.cb_CursaMateria.TabIndex = 18;
            // 
            // cb_CursaAlumno
            // 
            this.cb_CursaAlumno.FormattingEnabled = true;
            this.cb_CursaAlumno.Location = new System.Drawing.Point(60, 62);
            this.cb_CursaAlumno.Name = "cb_CursaAlumno";
            this.cb_CursaAlumno.Size = new System.Drawing.Size(121, 21);
            this.cb_CursaAlumno.TabIndex = 17;
            // 
            // btn_CargarCursado
            // 
            this.btn_CargarCursado.Location = new System.Drawing.Point(478, 102);
            this.btn_CargarCursado.Name = "btn_CargarCursado";
            this.btn_CargarCursado.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarCursado.TabIndex = 16;
            this.btn_CargarCursado.Text = "Cargar";
            this.btn_CargarCursado.UseVisualStyleBackColor = true;
            this.btn_CargarCursado.Click += new System.EventHandler(this.btn_CargarCursado_Click);
            // 
            // txb_Nota
            // 
            this.txb_Nota.Location = new System.Drawing.Point(346, 64);
            this.txb_Nota.Name = "txb_Nota";
            this.txb_Nota.Size = new System.Drawing.Size(90, 20);
            this.txb_Nota.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(468, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Condicion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nota";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Id_Materia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "DNI Alumno";
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(26, 202);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.Size = new System.Drawing.Size(823, 150);
            this.dgvAlumno.TabIndex = 7;
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(26, 358);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.Size = new System.Drawing.Size(823, 150);
            this.dgvMateria.TabIndex = 8;
            // 
            // dgvCursa
            // 
            this.dgvCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursa.Location = new System.Drawing.Point(26, 514);
            this.dgvCursa.Name = "dgvCursa";
            this.dgvCursa.Size = new System.Drawing.Size(823, 150);
            this.dgvCursa.TabIndex = 9;
            // 
            // FormInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 676);
            this.Controls.Add(this.dgvCursa);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormInstituto";
            this.Text = "FormInstituto";
            this.Load += new System.EventHandler(this.FormInstituto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAlumno.ResumeLayout(false);
            this.tabAlumno.PerformLayout();
            this.tabMateria.ResumeLayout(false);
            this.tabMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AñoMateria)).EndInit();
            this.tabCursa.ResumeLayout(false);
            this.tabCursa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursa)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabAlumno;
		private System.Windows.Forms.Button btn_CargarAlumno;
		private System.Windows.Forms.CheckBox chbx_analitico;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.DateTimePicker FechaNacAlumno;
		private System.Windows.Forms.TextBox txb_dni;
		private System.Windows.Forms.TextBox txb_NomApAlumno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabMateria;
		private System.Windows.Forms.TextBox txb_NombreCarrera;
		private System.Windows.Forms.NumericUpDown num_AñoMateria;
		private System.Windows.Forms.TextBox txb_DiaCursado;
		private System.Windows.Forms.TextBox txb_NombreMateria;
		private System.Windows.Forms.TextBox txb_CodMat;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabCursa;
		private System.Windows.Forms.TextBox txb_Nota;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btn_CargarMateria;
		private System.Windows.Forms.Button btn_CargarCursado;
		private System.Windows.Forms.DataGridView dgvAlumno;
		private System.Windows.Forms.DataGridView dgvMateria;
		private System.Windows.Forms.DataGridView dgvCursa;
		private System.Windows.Forms.ComboBox cb_CursaMateria;
		private System.Windows.Forms.ComboBox cb_CursaAlumno;
		private System.Windows.Forms.ComboBox cb_Condicion;
	}
}