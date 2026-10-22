namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormPrestamos
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
            grpNuevoPrestamo = new GroupBox();
            lblInfoStock = new Label();
            btnPrestar = new Button();
            cmbLibros = new ComboBox();
            lblLibro = new Label();
            cmbUsuarios = new ComboBox();
            lblUsuario = new Label();
            dgvPrestamos = new DataGridView();
            btnDevolver = new Button();
            btnRefrescar = new Button();
            lblInstruccion = new Label();
            grpNuevoPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Préstamos y Devoluciones";
            // 
            // grpNuevoPrestamo
            // 
            grpNuevoPrestamo.Controls.Add(lblInfoStock);
            grpNuevoPrestamo.Controls.Add(btnPrestar);
            grpNuevoPrestamo.Controls.Add(cmbLibros);
            grpNuevoPrestamo.Controls.Add(lblLibro);
            grpNuevoPrestamo.Controls.Add(cmbUsuarios);
            grpNuevoPrestamo.Controls.Add(lblUsuario);
            grpNuevoPrestamo.Location = new Point(20, 55);
            grpNuevoPrestamo.Name = "grpNuevoPrestamo";
            grpNuevoPrestamo.Size = new Size(330, 250);
            grpNuevoPrestamo.TabIndex = 1;
            grpNuevoPrestamo.TabStop = false;
            grpNuevoPrestamo.Text = "Nuevo Préstamo";
            // 
            // lblInfoStock
            // 
            lblInfoStock.AutoSize = true;
            lblInfoStock.Font = new Font("Segoe UI", 9F);
            lblInfoStock.ForeColor = Color.DimGray;
            lblInfoStock.Location = new Point(20, 148);
            lblInfoStock.Name = "lblInfoStock";
            lblInfoStock.Size = new Size(128, 15);
            lblInfoStock.TabIndex = 4;
            lblInfoStock.Text = "Existencias disponibles:";
            // 
            // btnPrestar
            // 
            btnPrestar.BackColor = Color.SteelBlue;
            btnPrestar.FlatStyle = FlatStyle.Flat;
            btnPrestar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrestar.ForeColor = Color.White;
            btnPrestar.Location = new Point(20, 180);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(290, 42);
            btnPrestar.TabIndex = 5;
            btnPrestar.Text = "Prestar Libro";
            btnPrestar.UseVisualStyleBackColor = false;
            btnPrestar.Click += btnPrestar_Click;
            // 
            // cmbLibros
            // 
            cmbLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(20, 115);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(290, 23);
            cmbLibros.TabIndex = 3;
            cmbLibros.SelectedIndexChanged += cmbLibros_SelectedIndexChanged;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(20, 95);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(37, 15);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro:";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(20, 55);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(290, 23);
            cmbUsuarios.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(20, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(370, 55);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(530, 280);
            dgvPrestamos.TabIndex = 2;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.ForestGreen;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(370, 350);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(290, 42);
            btnDevolver.TabIndex = 3;
            btnDevolver.Text = "Registrar Devolución";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Gray;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(680, 350);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(220, 42);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Actualizar Lista";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblInstruccion.Location = new Point(20, 320);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(335, 15);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Seleccione un préstamo de la tabla para registrar su devolución.";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 410);
            Controls.Add(lblInstruccion);
            Controls.Add(btnRefrescar);
            Controls.Add(btnDevolver);
            Controls.Add(dgvPrestamos);
            Controls.Add(grpNuevoPrestamo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Préstamos";
            Load += FormPrestamos_Load;
            grpNuevoPrestamo.ResumeLayout(false);
            grpNuevoPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpNuevoPrestamo;
        private Label lblUsuario;
        private ComboBox cmbUsuarios;
        private Label lblLibro;
        private ComboBox cmbLibros;
        private Button btnPrestar;
        private DataGridView dgvPrestamos;
        private Button btnDevolver;
        private Button btnRefrescar;
        private Label lblInfoStock;
        private Label lblInstruccion;
    }
}
