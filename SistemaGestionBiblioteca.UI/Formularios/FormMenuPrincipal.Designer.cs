namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormMenuPrincipal
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
            panelSuperior = new Panel();
            lblTituloMenu = new Label();
            panelContenedor = new Panel();
            btnHistorial = new Button();
            btnColaEspera = new Button();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnPrestamos = new Button();
            btnUsuarios = new Button();
            btnAutores = new Button();
            btnLibros = new Button();
            panelSuperior.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.MidnightBlue;
            panelSuperior.Controls.Add(lblTituloMenu);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(700, 65);
            panelSuperior.TabIndex = 0;
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloMenu.ForeColor = Color.White;
            lblTituloMenu.Location = new Point(20, 18);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(337, 30);
            lblTituloMenu.TabIndex = 0;
            lblTituloMenu.Text = "Sistema de Gestión - Biblioteca";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.WhiteSmoke;
            panelContenedor.Controls.Add(btnHistorial);
            panelContenedor.Controls.Add(btnColaEspera);
            panelContenedor.Controls.Add(btnCerrarSesion);
            panelContenedor.Controls.Add(btnReportes);
            panelContenedor.Controls.Add(btnPrestamos);
            panelContenedor.Controls.Add(btnUsuarios);
            panelContenedor.Controls.Add(btnAutores);
            panelContenedor.Controls.Add(btnLibros);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 65);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(30);
            panelContenedor.Size = new Size(700, 365);
            panelContenedor.TabIndex = 1;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.DarkSlateBlue;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(360, 180);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(290, 55);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "Historial y Deshacer";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnColaEspera
            // 
            btnColaEspera.BackColor = Color.Teal;
            btnColaEspera.FlatStyle = FlatStyle.Flat;
            btnColaEspera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnColaEspera.ForeColor = Color.White;
            btnColaEspera.Location = new Point(50, 180);
            btnColaEspera.Name = "btnColaEspera";
            btnColaEspera.Size = new Size(290, 55);
            btnColaEspera.TabIndex = 6;
            btnColaEspera.Text = "Cola de Espera";
            btnColaEspera.UseVisualStyleBackColor = false;
            btnColaEspera.Click += btnColaEspera_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Firebrick;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(230, 275);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(240, 40);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.SteelBlue;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(360, 105);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(290, 55);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes y Consultas";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.DarkCyan;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrestamos.ForeColor = Color.White;
            btnPrestamos.Location = new Point(50, 105);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(290, 55);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "Préstamos y Devoluciones";
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.DarkSlateGray;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(470, 30);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(180, 55);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAutores
            // 
            btnAutores.BackColor = Color.RoyalBlue;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAutores.ForeColor = Color.White;
            btnAutores.Location = new Point(260, 30);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(180, 55);
            btnAutores.TabIndex = 1;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.Navy;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLibros.ForeColor = Color.White;
            btnLibros.Location = new Point(50, 30);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(180, 55);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 430);
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTituloMenu;
        private Panel panelContenedor;
        private Button btnLibros;
        private Button btnAutores;
        private Button btnUsuarios;
        private Button btnPrestamos;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Button btnColaEspera;
        private Button btnHistorial;
    }
}
