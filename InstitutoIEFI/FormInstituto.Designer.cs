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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabAlumno = new System.Windows.Forms.TabPage();
			this.btn_ModificarAlumno = new System.Windows.Forms.Button();
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
			this.btn_ModificarMateria = new System.Windows.Forms.Button();
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
			this.label5 = new System.Windows.Forms.Label();
			this.txb_id = new System.Windows.Forms.TextBox();
			this.btn_ModificarCursado = new System.Windows.Forms.Button();
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
			this.EliminarAlumno = new System.Windows.Forms.Button();
			this.btn_EliminarMateria = new System.Windows.Forms.Button();
			this.btn_EliminarCursa = new System.Windows.Forms.Button();
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
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(26, 11);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(10, 5);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(908, 185);
			this.tabControl1.TabIndex = 6;
			// 
			// tabAlumno
			// 
			this.tabAlumno.BackColor = System.Drawing.Color.SteelBlue;
			this.tabAlumno.Controls.Add(this.EliminarAlumno);
			this.tabAlumno.Controls.Add(this.btn_ModificarAlumno);
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
			this.tabAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.tabAlumno.Location = new System.Drawing.Point(4, 26);
			this.tabAlumno.Name = "tabAlumno";
			this.tabAlumno.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlumno.Size = new System.Drawing.Size(900, 155);
			this.tabAlumno.TabIndex = 0;
			this.tabAlumno.Text = "Alumno";
			// 
			// btn_ModificarAlumno
			// 
			this.btn_ModificarAlumno.BackColor = System.Drawing.Color.CadetBlue;
			this.btn_ModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ModificarAlumno.Location = new System.Drawing.Point(331, 110);
			this.btn_ModificarAlumno.Name = "btn_ModificarAlumno";
			this.btn_ModificarAlumno.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarAlumno.TabIndex = 21;
			this.btn_ModificarAlumno.Text = "Modificar";
			this.btn_ModificarAlumno.UseVisualStyleBackColor = false;
			this.btn_ModificarAlumno.Click += new System.EventHandler(this.btn_ModificarAlumno_Click);
			// 
			// btn_CargarAlumno
			// 
			this.btn_CargarAlumno.BackColor = System.Drawing.Color.MidnightBlue;
			this.btn_CargarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CargarAlumno.Location = new System.Drawing.Point(163, 110);
			this.btn_CargarAlumno.Name = "btn_CargarAlumno";
			this.btn_CargarAlumno.Size = new System.Drawing.Size(75, 23);
			this.btn_CargarAlumno.TabIndex = 10;
			this.btn_CargarAlumno.Text = "Cargar";
			this.btn_CargarAlumno.UseVisualStyleBackColor = false;
			this.btn_CargarAlumno.Click += new System.EventHandler(this.btn_CargarAlumno_Click);
			// 
			// chbx_analitico
			// 
			this.chbx_analitico.AutoSize = true;
			this.chbx_analitico.Location = new System.Drawing.Point(671, 61);
			this.chbx_analitico.Name = "chbx_analitico";
			this.chbx_analitico.Size = new System.Drawing.Size(75, 17);
			this.chbx_analitico.TabIndex = 9;
			this.chbx_analitico.Text = "Analitico";
			this.chbx_analitico.UseVisualStyleBackColor = true;
			// 
			// txb_email
			// 
			this.txb_email.Location = new System.Drawing.Point(503, 56);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(100, 20);
			this.txb_email.TabIndex = 8;
			// 
			// FechaNacAlumno
			// 
			this.FechaNacAlumno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FechaNacAlumno.Location = new System.Drawing.Point(181, 58);
			this.FechaNacAlumno.Name = "FechaNacAlumno";
			this.FechaNacAlumno.Size = new System.Drawing.Size(100, 20);
			this.FechaNacAlumno.TabIndex = 7;
			// 
			// txb_dni
			// 
			this.txb_dni.Location = new System.Drawing.Point(356, 56);
			this.txb_dni.Name = "txb_dni";
			this.txb_dni.Size = new System.Drawing.Size(100, 20);
			this.txb_dni.TabIndex = 6;
			// 
			// txb_NomApAlumno
			// 
			this.txb_NomApAlumno.Location = new System.Drawing.Point(25, 56);
			this.txb_NomApAlumno.Name = "txb_NomApAlumno";
			this.txb_NomApAlumno.Size = new System.Drawing.Size(100, 20);
			this.txb_NomApAlumno.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.DodgerBlue;
			this.label4.Location = new System.Drawing.Point(500, 13);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(5);
			this.label4.Size = new System.Drawing.Size(47, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(109, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.DodgerBlue;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(178, 13);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(5);
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha de Nacimiento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(353, 13);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(5);
			this.label2.Size = new System.Drawing.Size(39, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "DNI";
			// 
			// tabMateria
			// 
			this.tabMateria.BackColor = System.Drawing.Color.SteelBlue;
			this.tabMateria.Controls.Add(this.btn_EliminarMateria);
			this.tabMateria.Controls.Add(this.btn_ModificarMateria);
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
			this.tabMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabMateria.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.tabMateria.Location = new System.Drawing.Point(4, 26);
			this.tabMateria.Name = "tabMateria";
			this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
			this.tabMateria.Size = new System.Drawing.Size(900, 155);
			this.tabMateria.TabIndex = 1;
			this.tabMateria.Text = "Materias";
			// 
			// btn_ModificarMateria
			// 
			this.btn_ModificarMateria.BackColor = System.Drawing.Color.CadetBlue;
			this.btn_ModificarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ModificarMateria.Location = new System.Drawing.Point(287, 113);
			this.btn_ModificarMateria.Name = "btn_ModificarMateria";
			this.btn_ModificarMateria.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarMateria.TabIndex = 22;
			this.btn_ModificarMateria.Text = "Modificar";
			this.btn_ModificarMateria.UseVisualStyleBackColor = false;
			this.btn_ModificarMateria.Click += new System.EventHandler(this.btn_ModificarMateria_Click);
			// 
			// btn_CargarMateria
			// 
			this.btn_CargarMateria.BackColor = System.Drawing.Color.MidnightBlue;
			this.btn_CargarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CargarMateria.Location = new System.Drawing.Point(148, 113);
			this.btn_CargarMateria.Name = "btn_CargarMateria";
			this.btn_CargarMateria.Size = new System.Drawing.Size(75, 23);
			this.btn_CargarMateria.TabIndex = 12;
			this.btn_CargarMateria.Text = "Cargar";
			this.btn_CargarMateria.UseVisualStyleBackColor = false;
			this.btn_CargarMateria.Click += new System.EventHandler(this.btn_CargarMateria_Click);
			// 
			// txb_NombreCarrera
			// 
			this.txb_NombreCarrera.Location = new System.Drawing.Point(660, 56);
			this.txb_NombreCarrera.Name = "txb_NombreCarrera";
			this.txb_NombreCarrera.Size = new System.Drawing.Size(100, 20);
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
			this.num_AñoMateria.Size = new System.Drawing.Size(100, 20);
			this.num_AñoMateria.TabIndex = 10;
			this.num_AñoMateria.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
			// 
			// txb_DiaCursado
			// 
			this.txb_DiaCursado.Location = new System.Drawing.Point(497, 57);
			this.txb_DiaCursado.Name = "txb_DiaCursado";
			this.txb_DiaCursado.Size = new System.Drawing.Size(100, 20);
			this.txb_DiaCursado.TabIndex = 9;
			// 
			// txb_NombreMateria
			// 
			this.txb_NombreMateria.Location = new System.Drawing.Point(193, 57);
			this.txb_NombreMateria.Name = "txb_NombreMateria";
			this.txb_NombreMateria.Size = new System.Drawing.Size(100, 20);
			this.txb_NombreMateria.TabIndex = 8;
			// 
			// txb_CodMat
			// 
			this.txb_CodMat.Location = new System.Drawing.Point(27, 57);
			this.txb_CodMat.Name = "txb_CodMat";
			this.txb_CodMat.Size = new System.Drawing.Size(100, 20);
			this.txb_CodMat.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.DodgerBlue;
			this.label10.Location = new System.Drawing.Point(657, 23);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(5);
			this.label10.Size = new System.Drawing.Size(123, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "Nombre de Carrera";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.DodgerBlue;
			this.label9.Location = new System.Drawing.Point(494, 23);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(5);
			this.label9.Size = new System.Drawing.Size(103, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Dia de cursado";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.DodgerBlue;
			this.label8.Location = new System.Drawing.Point(351, 23);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(5);
			this.label8.Size = new System.Drawing.Size(39, 23);
			this.label8.TabIndex = 2;
			this.label8.Text = "Año";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.DodgerBlue;
			this.label7.Location = new System.Drawing.Point(190, 23);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(5);
			this.label7.Size = new System.Drawing.Size(60, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.DodgerBlue;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(24, 23);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(5);
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Código";
			// 
			// tabCursa
			// 
			this.tabCursa.BackColor = System.Drawing.Color.SteelBlue;
			this.tabCursa.CausesValidation = false;
			this.tabCursa.Controls.Add(this.btn_EliminarCursa);
			this.tabCursa.Controls.Add(this.label5);
			this.tabCursa.Controls.Add(this.txb_id);
			this.tabCursa.Controls.Add(this.btn_ModificarCursado);
			this.tabCursa.Controls.Add(this.cb_Condicion);
			this.tabCursa.Controls.Add(this.cb_CursaMateria);
			this.tabCursa.Controls.Add(this.cb_CursaAlumno);
			this.tabCursa.Controls.Add(this.btn_CargarCursado);
			this.tabCursa.Controls.Add(this.txb_Nota);
			this.tabCursa.Controls.Add(this.label14);
			this.tabCursa.Controls.Add(this.label13);
			this.tabCursa.Controls.Add(this.label12);
			this.tabCursa.Controls.Add(this.label11);
			this.tabCursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCursa.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.tabCursa.Location = new System.Drawing.Point(4, 26);
			this.tabCursa.Name = "tabCursa";
			this.tabCursa.Size = new System.Drawing.Size(900, 155);
			this.tabCursa.TabIndex = 2;
			this.tabCursa.Text = "Cursado";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.label5.Location = new System.Drawing.Point(662, 28);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(5);
			this.label5.Size = new System.Drawing.Size(28, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "Id";
			// 
			// txb_id
			// 
			this.txb_id.Location = new System.Drawing.Point(665, 64);
			this.txb_id.Name = "txb_id";
			this.txb_id.Size = new System.Drawing.Size(100, 20);
			this.txb_id.TabIndex = 24;
			// 
			// btn_ModificarCursado
			// 
			this.btn_ModificarCursado.BackColor = System.Drawing.Color.CadetBlue;
			this.btn_ModificarCursado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ModificarCursado.Location = new System.Drawing.Point(386, 112);
			this.btn_ModificarCursado.Name = "btn_ModificarCursado";
			this.btn_ModificarCursado.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarCursado.TabIndex = 23;
			this.btn_ModificarCursado.Text = "Modificar";
			this.btn_ModificarCursado.UseVisualStyleBackColor = false;
			this.btn_ModificarCursado.Click += new System.EventHandler(this.btn_ModificarCursado_Click);
			// 
			// cb_Condicion
			// 
			this.cb_Condicion.FormattingEnabled = true;
			this.cb_Condicion.Items.AddRange(new object[] {
            "Libre",
            "Regular",
            "Promocion"});
			this.cb_Condicion.Location = new System.Drawing.Point(502, 63);
			this.cb_Condicion.Name = "cb_Condicion";
			this.cb_Condicion.Size = new System.Drawing.Size(100, 21);
			this.cb_Condicion.TabIndex = 19;
			// 
			// cb_CursaMateria
			// 
			this.cb_CursaMateria.FormattingEnabled = true;
			this.cb_CursaMateria.Location = new System.Drawing.Point(208, 64);
			this.cb_CursaMateria.Name = "cb_CursaMateria";
			this.cb_CursaMateria.Size = new System.Drawing.Size(100, 21);
			this.cb_CursaMateria.TabIndex = 18;
			// 
			// cb_CursaAlumno
			// 
			this.cb_CursaAlumno.FormattingEnabled = true;
			this.cb_CursaAlumno.Location = new System.Drawing.Point(60, 65);
			this.cb_CursaAlumno.Name = "cb_CursaAlumno";
			this.cb_CursaAlumno.Size = new System.Drawing.Size(100, 21);
			this.cb_CursaAlumno.TabIndex = 17;
			// 
			// btn_CargarCursado
			// 
			this.btn_CargarCursado.BackColor = System.Drawing.Color.MidnightBlue;
			this.btn_CargarCursado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CargarCursado.Location = new System.Drawing.Point(207, 112);
			this.btn_CargarCursado.Name = "btn_CargarCursado";
			this.btn_CargarCursado.Size = new System.Drawing.Size(75, 23);
			this.btn_CargarCursado.TabIndex = 16;
			this.btn_CargarCursado.Text = "Cargar";
			this.btn_CargarCursado.UseVisualStyleBackColor = false;
			this.btn_CargarCursado.Click += new System.EventHandler(this.btn_CargarCursado_Click);
			// 
			// txb_Nota
			// 
			this.txb_Nota.Location = new System.Drawing.Point(361, 64);
			this.txb_Nota.Name = "txb_Nota";
			this.txb_Nota.Size = new System.Drawing.Size(100, 20);
			this.txb_Nota.TabIndex = 15;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.DodgerBlue;
			this.label14.Location = new System.Drawing.Point(508, 28);
			this.label14.Name = "label14";
			this.label14.Padding = new System.Windows.Forms.Padding(5);
			this.label14.Size = new System.Drawing.Size(73, 23);
			this.label14.TabIndex = 4;
			this.label14.Text = "Condicion";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.DodgerBlue;
			this.label13.Location = new System.Drawing.Point(368, 28);
			this.label13.Name = "label13";
			this.label13.Padding = new System.Windows.Forms.Padding(5);
			this.label13.Size = new System.Drawing.Size(44, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "Nota";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.DodgerBlue;
			this.label12.Location = new System.Drawing.Point(205, 28);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(5);
			this.label12.Size = new System.Drawing.Size(77, 23);
			this.label12.TabIndex = 2;
			this.label12.Text = "Id_Materia";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.DodgerBlue;
			this.label11.Location = new System.Drawing.Point(57, 28);
			this.label11.Name = "label11";
			this.label11.Padding = new System.Windows.Forms.Padding(5);
			this.label11.Size = new System.Drawing.Size(84, 23);
			this.label11.TabIndex = 1;
			this.label11.Text = "DNI Alumno";
			// 
			// dgvAlumno
			// 
			this.dgvAlumno.BackgroundColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAlumno.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAlumno.Location = new System.Drawing.Point(26, 202);
			this.dgvAlumno.Name = "dgvAlumno";
			this.dgvAlumno.Size = new System.Drawing.Size(904, 150);
			this.dgvAlumno.TabIndex = 7;
			// 
			// dgvMateria
			// 
			this.dgvMateria.BackgroundColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMateria.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMateria.Location = new System.Drawing.Point(26, 358);
			this.dgvMateria.Name = "dgvMateria";
			this.dgvMateria.Size = new System.Drawing.Size(904, 150);
			this.dgvMateria.TabIndex = 8;
			// 
			// dgvCursa
			// 
			this.dgvCursa.BackgroundColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCursa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCursa.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvCursa.Location = new System.Drawing.Point(26, 514);
			this.dgvCursa.Name = "dgvCursa";
			this.dgvCursa.Size = new System.Drawing.Size(904, 150);
			this.dgvCursa.TabIndex = 9;
			// 
			// EliminarAlumno
			// 
			this.EliminarAlumno.BackColor = System.Drawing.Color.LightCoral;
			this.EliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.EliminarAlumno.Location = new System.Drawing.Point(472, 110);
			this.EliminarAlumno.Name = "EliminarAlumno";
			this.EliminarAlumno.Size = new System.Drawing.Size(75, 23);
			this.EliminarAlumno.TabIndex = 27;
			this.EliminarAlumno.Text = "Eliminar";
			this.EliminarAlumno.UseVisualStyleBackColor = false;
			this.EliminarAlumno.Click += new System.EventHandler(this.EliminarAlumno_Click);
			// 
			// btn_EliminarMateria
			// 
			this.btn_EliminarMateria.BackColor = System.Drawing.Color.LightCoral;
			this.btn_EliminarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_EliminarMateria.Location = new System.Drawing.Point(423, 113);
			this.btn_EliminarMateria.Name = "btn_EliminarMateria";
			this.btn_EliminarMateria.Size = new System.Drawing.Size(75, 23);
			this.btn_EliminarMateria.TabIndex = 28;
			this.btn_EliminarMateria.Text = "Eliminar";
			this.btn_EliminarMateria.UseVisualStyleBackColor = false;
			this.btn_EliminarMateria.Click += new System.EventHandler(this.btn_EliminarMateria_Click);
			// 
			// btn_EliminarCursa
			// 
			this.btn_EliminarCursa.BackColor = System.Drawing.Color.LightCoral;
			this.btn_EliminarCursa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_EliminarCursa.Location = new System.Drawing.Point(502, 112);
			this.btn_EliminarCursa.Name = "btn_EliminarCursa";
			this.btn_EliminarCursa.Size = new System.Drawing.Size(75, 23);
			this.btn_EliminarCursa.TabIndex = 28;
			this.btn_EliminarCursa.Text = "Eliminar";
			this.btn_EliminarCursa.UseVisualStyleBackColor = false;
			this.btn_EliminarCursa.Click += new System.EventHandler(this.btn_EliminarCursa_Click);
			// 
			// FormInstituto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(949, 676);
			this.Controls.Add(this.dgvCursa);
			this.Controls.Add(this.dgvMateria);
			this.Controls.Add(this.dgvAlumno);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
		private System.Windows.Forms.Button btn_ModificarAlumno;
		private System.Windows.Forms.Button btn_ModificarMateria;
		private System.Windows.Forms.Button btn_ModificarCursado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txb_id;
		private System.Windows.Forms.Button EliminarAlumno;
		private System.Windows.Forms.Button btn_EliminarMateria;
		private System.Windows.Forms.Button btn_EliminarCursa;
	}
}


/*namespace InstitutoIEFI
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
			this.txb_Nota = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_CargarMateria = new System.Windows.Forms.Button();
			this.btn_CargarCursado = new System.Windows.Forms.Button();
			this.dgvAlumno = new System.Windows.Forms.DataGridView();
			this.dgvMateria = new System.Windows.Forms.DataGridView();
			this.dgvCursa = new System.Windows.Forms.DataGridView();
			this.cb_CursaAlumno = new System.Windows.Forms.ComboBox();
			this.cb_CursaMateria = new System.Windows.Forms.ComboBox();
			this.cb_Condicion = new System.Windows.Forms.ComboBox();
			this.btn_ModificarAlumno = new System.Windows.Forms.Button();
			this.btn_ModificarMateria = new System.Windows.Forms.Button();
			this.btn_ModificarCursado = new System.Windows.Forms.Button();
			this.txb_id = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
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
			this.tabControl1.Size = new System.Drawing.Size(908, 185);
			this.tabControl1.TabIndex = 6;
			// 
			// tabAlumno
			// 
			this.tabAlumno.Controls.Add(this.btn_ModificarAlumno);
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
			// 
			// txb_NomApAlumno
			// 
			this.txb_NomApAlumno.Location = new System.Drawing.Point(11, 42);
			this.txb_NomApAlumno.Name = "txb_NomApAlumno";
			this.txb_NomApAlumno.Size = new System.Drawing.Size(147, 20);
			this.txb_NomApAlumno.TabIndex = 5;
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
			this.tabMateria.Controls.Add(this.btn_ModificarMateria);
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
			this.tabMateria.Size = new System.Drawing.Size(900, 159);
			this.tabMateria.TabIndex = 1;
			this.tabMateria.Text = "Materias";
			this.tabMateria.UseVisualStyleBackColor = true;
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
			this.tabCursa.Controls.Add(this.label5);
			this.tabCursa.Controls.Add(this.txb_id);
			this.tabCursa.Controls.Add(this.btn_ModificarCursado);
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
			// btn_CargarMateria
			// 
			this.btn_CargarMateria.Location = new System.Drawing.Point(76, 100);
			this.btn_CargarMateria.Name = "btn_CargarMateria";
			this.btn_CargarMateria.Size = new System.Drawing.Size(75, 23);
			this.btn_CargarMateria.TabIndex = 12;
			this.btn_CargarMateria.Text = "Cargar";
			this.btn_CargarMateria.UseVisualStyleBackColor = true;
			this.btn_CargarMateria.Click += new System.EventHandler(this.btn_CargarMateria_Click);
			// 
			// btn_CargarCursado
			// 
			this.btn_CargarCursado.Location = new System.Drawing.Point(287, 102);
			this.btn_CargarCursado.Name = "btn_CargarCursado";
			this.btn_CargarCursado.Size = new System.Drawing.Size(75, 23);
			this.btn_CargarCursado.TabIndex = 16;
			this.btn_CargarCursado.Text = "Cargar";
			this.btn_CargarCursado.UseVisualStyleBackColor = true;
			this.btn_CargarCursado.Click += new System.EventHandler(this.btn_CargarCursado_Click);
			// 
			// dgvAlumno
			// 
			this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlumno.Location = new System.Drawing.Point(26, 202);
			this.dgvAlumno.Name = "dgvAlumno";
			this.dgvAlumno.Size = new System.Drawing.Size(904, 150);
			this.dgvAlumno.TabIndex = 7;
			// 
			// dgvMateria
			// 
			this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMateria.Location = new System.Drawing.Point(26, 358);
			this.dgvMateria.Name = "dgvMateria";
			this.dgvMateria.Size = new System.Drawing.Size(904, 150);
			this.dgvMateria.TabIndex = 8;
			// 
			// dgvCursa
			// 
			this.dgvCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCursa.Location = new System.Drawing.Point(26, 514);
			this.dgvCursa.Name = "dgvCursa";
			this.dgvCursa.Size = new System.Drawing.Size(904, 150);
			this.dgvCursa.TabIndex = 9;
			// 
			// cb_CursaAlumno
			// 
			this.cb_CursaAlumno.FormattingEnabled = true;
			this.cb_CursaAlumno.Location = new System.Drawing.Point(60, 62);
			this.cb_CursaAlumno.Name = "cb_CursaAlumno";
			this.cb_CursaAlumno.Size = new System.Drawing.Size(121, 21);
			this.cb_CursaAlumno.TabIndex = 17;
			// 
			// cb_CursaMateria
			// 
			this.cb_CursaMateria.FormattingEnabled = true;
			this.cb_CursaMateria.Location = new System.Drawing.Point(208, 64);
			this.cb_CursaMateria.Name = "cb_CursaMateria";
			this.cb_CursaMateria.Size = new System.Drawing.Size(121, 21);
			this.cb_CursaMateria.TabIndex = 18;
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
			// btn_ModificarAlumno
			// 
			this.btn_ModificarAlumno.Location = new System.Drawing.Point(200, 82);
			this.btn_ModificarAlumno.Name = "btn_ModificarAlumno";
			this.btn_ModificarAlumno.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarAlumno.TabIndex = 21;
			this.btn_ModificarAlumno.Text = "Modificar";
			this.btn_ModificarAlumno.UseVisualStyleBackColor = true;
			this.btn_ModificarAlumno.Click += new System.EventHandler(this.btn_ModificarAlumno_Click);
			// 
			// btn_ModificarMateria
			// 
			this.btn_ModificarMateria.Location = new System.Drawing.Point(207, 100);
			this.btn_ModificarMateria.Name = "btn_ModificarMateria";
			this.btn_ModificarMateria.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarMateria.TabIndex = 22;
			this.btn_ModificarMateria.Text = "Modificar";
			this.btn_ModificarMateria.UseVisualStyleBackColor = true;
			this.btn_ModificarMateria.Click += new System.EventHandler(this.btn_ModificarMateria_Click);
			// 
			// btn_ModificarCursado
			// 
			this.btn_ModificarCursado.Location = new System.Drawing.Point(386, 102);
			this.btn_ModificarCursado.Name = "btn_ModificarCursado";
			this.btn_ModificarCursado.Size = new System.Drawing.Size(75, 23);
			this.btn_ModificarCursado.TabIndex = 23;
			this.btn_ModificarCursado.Text = "Modificar";
			this.btn_ModificarCursado.UseVisualStyleBackColor = true;
			this.btn_ModificarCursado.Click += new System.EventHandler(this.btn_ModificarCursado_Click);
			// 
			// txb_id
			// 
			this.txb_id.Location = new System.Drawing.Point(613, 65);
			this.txb_id.Name = "txb_id";
			this.txb_id.Size = new System.Drawing.Size(90, 20);
			this.txb_id.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(610, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Id";
			// 
			// FormInstituto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1497, 676);
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
		private System.Windows.Forms.Button btn_ModificarAlumno;
		private System.Windows.Forms.Button btn_ModificarMateria;
		private System.Windows.Forms.Button btn_ModificarCursado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txb_id;
	}
}*/