namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormReportes
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
            panelMetricas = new Panel();
            lblTotalLibrosPrestados = new Label();
            lblTituloMetrica = new Label();
            btnBajoStock = new Button();
            btnOrdenados = new Button();
            btnPrestamosUsuario = new Button();
            dgvReporte = new DataGridView();
            lblDetalleReporte = new Label();
            panelMetricas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
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
            lblTitulo.Text = "Reportes de Biblioteca";
            // 
            // panelMetricas
            // 
            panelMetricas.BackColor = Color.SteelBlue;
            panelMetricas.BorderStyle = BorderStyle.FixedSingle;
            panelMetricas.Controls.Add(lblTotalLibrosPrestados);
            panelMetricas.Controls.Add(lblTituloMetrica);
            panelMetricas.Location = new Point(570, 55);
            panelMetricas.Name = "panelMetricas";
            panelMetricas.Size = new Size(250, 75);
            panelMetricas.TabIndex = 4;
            // 
            // lblTotalLibrosPrestados
            // 
            lblTotalLibrosPrestados.Dock = DockStyle.Fill;
            lblTotalLibrosPrestados.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalLibrosPrestados.ForeColor = Color.White;
            lblTotalLibrosPrestados.Location = new Point(0, 25);
            lblTotalLibrosPrestados.Name = "lblTotalLibrosPrestados";
            lblTotalLibrosPrestados.Size = new Size(248, 48);
            lblTotalLibrosPrestados.TabIndex = 1;
            lblTotalLibrosPrestados.Text = "0";
            lblTotalLibrosPrestados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloMetrica
            // 
            lblTituloMetrica.Dock = DockStyle.Top;
            lblTituloMetrica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloMetrica.ForeColor = Color.White;
            lblTituloMetrica.Location = new Point(0, 0);
            lblTituloMetrica.Name = "lblTituloMetrica";
            lblTituloMetrica.Size = new Size(248, 25);
            lblTituloMetrica.TabIndex = 0;
            lblTituloMetrica.Text = "Libros prestados actualmente";
            lblTituloMetrica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBajoStock
            // 
            btnBajoStock.BackColor = Color.DarkOrange;
            btnBajoStock.FlatStyle = FlatStyle.Flat;
            btnBajoStock.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBajoStock.ForeColor = Color.White;
            btnBajoStock.Location = new Point(20, 60);
            btnBajoStock.Name = "btnBajoStock";
            btnBajoStock.Size = new Size(260, 32);
            btnBajoStock.TabIndex = 1;
            btnBajoStock.Text = "Libros con poco stock (Menos de 5)";
            btnBajoStock.UseVisualStyleBackColor = false;
            btnBajoStock.Click += btnBajoStock_Click;
            // 
            // btnOrdenados
            // 
            btnOrdenados.BackColor = Color.DarkSlateBlue;
            btnOrdenados.FlatStyle = FlatStyle.Flat;
            btnOrdenados.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOrdenados.ForeColor = Color.White;
            btnOrdenados.Location = new Point(290, 60);
            btnOrdenados.Name = "btnOrdenados";
            btnOrdenados.Size = new Size(260, 32);
            btnOrdenados.TabIndex = 2;
            btnOrdenados.Text = "Libros ordenados alfabéticamente";
            btnOrdenados.UseVisualStyleBackColor = false;
            btnOrdenados.Click += btnOrdenados_Click;
            // 
            // btnPrestamosUsuario
            // 
            btnPrestamosUsuario.BackColor = Color.Teal;
            btnPrestamosUsuario.FlatStyle = FlatStyle.Flat;
            btnPrestamosUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPrestamosUsuario.ForeColor = Color.White;
            btnPrestamosUsuario.Location = new Point(20, 100);
            btnPrestamosUsuario.Name = "btnPrestamosUsuario";
            btnPrestamosUsuario.Size = new Size(530, 32);
            btnPrestamosUsuario.TabIndex = 3;
            btnPrestamosUsuario.Text = "Cantidad de préstamos por usuario";
            btnPrestamosUsuario.UseVisualStyleBackColor = false;
            btnPrestamosUsuario.Click += btnPrestamosUsuario_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(20, 170);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(800, 255);
            dgvReporte.TabIndex = 5;
            // 
            // lblDetalleReporte
            // 
            lblDetalleReporte.AutoSize = true;
            lblDetalleReporte.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDetalleReporte.ForeColor = Color.DarkSlateGray;
            lblDetalleReporte.Location = new Point(20, 147);
            lblDetalleReporte.Name = "lblDetalleReporte";
            lblDetalleReporte.Size = new Size(78, 17);
            lblDetalleReporte.TabIndex = 6;
            lblDetalleReporte.Text = "Resultados:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 445);
            Controls.Add(lblDetalleReporte);
            Controls.Add(dgvReporte);
            Controls.Add(btnPrestamosUsuario);
            Controls.Add(btnOrdenados);
            Controls.Add(btnBajoStock);
            Controls.Add(panelMetricas);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += FormReportes_Load;
            panelMetricas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panelMetricas;
        private Label lblTituloMetrica;
        private Label lblTotalLibrosPrestados;
        private Button btnBajoStock;
        private Button btnOrdenados;
        private Button btnPrestamosUsuario;
        private DataGridView dgvReporte;
        private Label lblDetalleReporte;
    }
}
