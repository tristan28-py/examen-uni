namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormAutores
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
            txtNacionalidad = new TextBox();
            lblNacionalidad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtAutorId = new TextBox();
            lblAutorId = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvAutores = new DataGridView();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento de Autores";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(txtNacionalidad);
            grpDatos.Controls.Add(lblNacionalidad);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtAutorId);
            grpDatos.Controls.Add(lblAutorId);
            grpDatos.Location = new Point(20, 55);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(320, 240);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Autor";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(25, 195);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(25, 155);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(270, 23);
            txtNacionalidad.TabIndex = 5;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(25, 137);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(80, 15);
            lblNacionalidad.TabIndex = 4;
            lblNacionalidad.Text = "Nacionalidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtAutorId
            // 
            txtAutorId.Enabled = false;
            txtAutorId.Location = new Point(25, 45);
            txtAutorId.Name = "txtAutorId";
            txtAutorId.Size = new Size(120, 23);
            txtAutorId.TabIndex = 1;
            // 
            // lblAutorId
            // 
            lblAutorId.AutoSize = true;
            lblAutorId.Location = new Point(25, 27);
            lblAutorId.Name = "lblAutorId";
            lblAutorId.Size = new Size(53, 15);
            lblAutorId.TabIndex = 0;
            lblAutorId.Text = "Autor ID:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(20, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 32);
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
            btnModificar.Location = new Point(102, 310);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 32);
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
            btnEliminar.Location = new Point(184, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 32);
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
            btnLimpiar.Location = new Point(265, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 32);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAutores
            // 
            dgvAutores.AllowUserToAddRows = false;
            dgvAutores.AllowUserToDeleteRows = false;
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.BackgroundColor = Color.White;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(360, 55);
            dgvAutores.MultiSelect = false;
            dgvAutores.Name = "dgvAutores";
            dgvAutores.ReadOnly = true;
            dgvAutores.RowHeadersVisible = false;
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.Size = new Size(420, 287);
            dgvAutores.TabIndex = 6;
            dgvAutores.CellClick += dgvAutores_CellClick;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(dgvAutores);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autores";
            Load += FormAutores_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatos;
        private Label lblAutorId;
        private TextBox txtAutorId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblNacionalidad;
        private TextBox txtNacionalidad;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvAutores;
    }
}
