namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormLibros
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpDatos = new GroupBox();
            chkActivo = new CheckBox();
            cmbAutores = new ComboBox();
            lblAutor = new Label();
            numExistencias = new NumericUpDown();
            lblExistencias = new Label();
            txtISBN = new TextBox();
            lblISBN = new Label();
            txtTituloLibro = new TextBox();
            lblTituloLibro = new Label();
            txtLibroId = new TextBox();
            lblLibroId = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvLibros = new DataGridView();
            grpBusqueda = new GroupBox();
            btnRestablecer = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            grpBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento de Libros";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(cmbAutores);
            grpDatos.Controls.Add(lblAutor);
            grpDatos.Controls.Add(numExistencias);
            grpDatos.Controls.Add(lblExistencias);
            grpDatos.Controls.Add(txtISBN);
            grpDatos.Controls.Add(lblISBN);
            grpDatos.Controls.Add(txtTituloLibro);
            grpDatos.Controls.Add(lblTituloLibro);
            grpDatos.Controls.Add(txtLibroId);
            grpDatos.Controls.Add(lblLibroId);
            grpDatos.Location = new Point(20, 55);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(330, 320);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Libro";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(20, 285);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cmbAutores
            // 
            cmbAutores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutores.FormattingEnabled = true;
            cmbAutores.Location = new Point(20, 245);
            cmbAutores.Name = "cmbAutores";
            cmbAutores.Size = new Size(285, 23);
            cmbAutores.TabIndex = 9;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(20, 227);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 8;
            lblAutor.Text = "Autor:";
            // 
            // numExistencias
            // 
            numExistencias.Location = new Point(20, 195);
            numExistencias.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numExistencias.Name = "numExistencias";
            numExistencias.Size = new Size(130, 23);
            numExistencias.TabIndex = 7;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Location = new Point(20, 177);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(67, 15);
            lblExistencias.TabIndex = 6;
            lblExistencias.Text = "Existencias:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(20, 145);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(285, 23);
            txtISBN.TabIndex = 5;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(20, 127);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(35, 15);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN:";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(20, 95);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(285, 23);
            txtTituloLibro.TabIndex = 3;
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Location = new Point(20, 77);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(40, 15);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Título:";
            // 
            // txtLibroId
            // 
            txtLibroId.Enabled = false;
            txtLibroId.Location = new Point(20, 45);
            txtLibroId.Name = "txtLibroId";
            txtLibroId.Size = new Size(130, 23);
            txtLibroId.TabIndex = 1;
            // 
            // lblLibroId
            // 
            lblLibroId.AutoSize = true;
            lblLibroId.Location = new Point(20, 27);
            lblLibroId.Name = "lblLibroId";
            lblLibroId.Size = new Size(51, 15);
            lblLibroId.TabIndex = 0;
            lblLibroId.Text = "Libro ID:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(20, 390);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 32);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(104, 390);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(78, 32);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(188, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 32);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(272, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 32);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(370, 115);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(510, 307);
            dgvLibros.TabIndex = 6;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // grpBusqueda
            // 
            grpBusqueda.Controls.Add(btnRestablecer);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Location = new Point(370, 50);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(510, 58);
            grpBusqueda.TabIndex = 7;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Buscar Libro";
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = Color.Gray;
            btnRestablecer.FlatStyle = FlatStyle.Flat;
            btnRestablecer.ForeColor = Color.White;
            btnRestablecer.Location = new Point(400, 21);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(95, 26);
            btnRestablecer.TabIndex = 3;
            btnRestablecer.Text = "Ver Todos";
            btnRestablecer.UseVisualStyleBackColor = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(310, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(125, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(175, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(15, 26);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(100, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por título:";
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 440);
            Controls.Add(grpBusqueda);
            Controls.Add(dgvLibros);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Libros";
            Load += FormLibros_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatos;
        private Label lblLibroId;
        private TextBox txtLibroId;
        private Label lblTituloLibro;
        private TextBox txtTituloLibro;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblExistencias;
        private NumericUpDown numExistencias;
        private Label lblAutor;
        private ComboBox cmbAutores;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvLibros;
        private GroupBox grpBusqueda;
        private Button btnRestablecer;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}
