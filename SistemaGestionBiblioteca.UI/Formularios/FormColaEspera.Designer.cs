namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormColaEspera
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
            grpAcciones = new GroupBox();
            btnDespachar = new Button();
            btnVerSiguiente = new Button();
            btnEncolar = new Button();
            cmbUsuarios = new ComboBox();
            lblSeleccionar = new Label();
            panelContador = new Panel();
            lblTotalCola = new Label();
            lblTituloCola = new Label();
            dgvCola = new DataGridView();
            lblListaEspera = new Label();
            grpAcciones.SuspendLayout();
            panelContador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCola).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cola de Espera";
            // 
            // grpAcciones
            // 
            grpAcciones.Controls.Add(btnDespachar);
            grpAcciones.Controls.Add(btnVerSiguiente);
            grpAcciones.Controls.Add(btnEncolar);
            grpAcciones.Controls.Add(cmbUsuarios);
            grpAcciones.Controls.Add(lblSeleccionar);
            grpAcciones.Location = new Point(20, 55);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Size = new Size(330, 235);
            grpAcciones.TabIndex = 1;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "Opciones";
            // 
            // btnDespachar
            // 
            btnDespachar.BackColor = Color.ForestGreen;
            btnDespachar.FlatStyle = FlatStyle.Flat;
            btnDespachar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDespachar.ForeColor = Color.White;
            btnDespachar.Location = new Point(20, 175);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(290, 38);
            btnDespachar.TabIndex = 4;
            btnDespachar.Text = "Atender siguiente usuario";
            btnDespachar.UseVisualStyleBackColor = false;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnVerSiguiente
            // 
            btnVerSiguiente.BackColor = Color.DarkSlateGray;
            btnVerSiguiente.FlatStyle = FlatStyle.Flat;
            btnVerSiguiente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVerSiguiente.ForeColor = Color.White;
            btnVerSiguiente.Location = new Point(20, 128);
            btnVerSiguiente.Name = "btnVerSiguiente";
            btnVerSiguiente.Size = new Size(290, 38);
            btnVerSiguiente.TabIndex = 3;
            btnVerSiguiente.Text = "Ver siguiente en turno";
            btnVerSiguiente.UseVisualStyleBackColor = false;
            btnVerSiguiente.Click += btnVerSiguiente_Click;
            // 
            // btnEncolar
            // 
            btnEncolar.BackColor = Color.Teal;
            btnEncolar.FlatStyle = FlatStyle.Flat;
            btnEncolar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEncolar.ForeColor = Color.White;
            btnEncolar.Location = new Point(20, 80);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(290, 38);
            btnEncolar.TabIndex = 2;
            btnEncolar.Text = "Agregar a la cola";
            btnEncolar.UseVisualStyleBackColor = false;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(20, 45);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(290, 23);
            cmbUsuarios.TabIndex = 1;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Location = new Point(20, 25);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(50, 15);
            lblSeleccionar.TabIndex = 0;
            lblSeleccionar.Text = "Usuario:";
            // 
            // panelContador
            // 
            panelContador.BackColor = Color.Teal;
            panelContador.BorderStyle = BorderStyle.FixedSingle;
            panelContador.Controls.Add(lblTotalCola);
            panelContador.Controls.Add(lblTituloCola);
            panelContador.Location = new Point(20, 305);
            panelContador.Name = "panelContador";
            panelContador.Size = new Size(330, 75);
            panelContador.TabIndex = 2;
            // 
            // lblTotalCola
            // 
            lblTotalCola.Dock = DockStyle.Fill;
            lblTotalCola.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCola.ForeColor = Color.White;
            lblTotalCola.Location = new Point(0, 25);
            lblTotalCola.Name = "lblTotalCola";
            lblTotalCola.Size = new Size(328, 48);
            lblTotalCola.TabIndex = 1;
            lblTotalCola.Text = "0";
            lblTotalCola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCola
            // 
            lblTituloCola.Dock = DockStyle.Top;
            lblTituloCola.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTituloCola.ForeColor = Color.White;
            lblTituloCola.Location = new Point(0, 0);
            lblTituloCola.Name = "lblTituloCola";
            lblTituloCola.Size = new Size(328, 25);
            lblTituloCola.TabIndex = 0;
            lblTituloCola.Text = "Usuarios en espera:";
            lblTituloCola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCola
            // 
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCola.BackgroundColor = Color.White;
            dgvCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCola.Location = new Point(370, 80);
            dgvCola.MultiSelect = false;
            dgvCola.Name = "dgvCola";
            dgvCola.ReadOnly = true;
            dgvCola.RowHeadersVisible = false;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.Size = new Size(420, 300);
            dgvCola.TabIndex = 3;
            // 
            // lblListaEspera
            // 
            lblListaEspera.AutoSize = true;
            lblListaEspera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaEspera.ForeColor = Color.MidnightBlue;
            lblListaEspera.Location = new Point(370, 55);
            lblListaEspera.Name = "lblListaEspera";
            lblListaEspera.Size = new Size(111, 19);
            lblListaEspera.TabIndex = 4;
            lblListaEspera.Text = "Lista de espera:";
            // 
            // FormColaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 400);
            Controls.Add(lblListaEspera);
            Controls.Add(dgvCola);
            Controls.Add(panelContador);
            Controls.Add(grpAcciones);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormColaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cola de Espera";
            Load += FormColaEspera_Load;
            grpAcciones.ResumeLayout(false);
            grpAcciones.PerformLayout();
            panelContador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCola).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpAcciones;
        private Label lblSeleccionar;
        private ComboBox cmbUsuarios;
        private Button btnEncolar;
        private Button btnVerSiguiente;
        private Button btnDespachar;
        private Panel panelContador;
        private Label lblTituloCola;
        private Label lblTotalCola;
        private DataGridView dgvCola;
        private Label lblListaEspera;
    }
}
