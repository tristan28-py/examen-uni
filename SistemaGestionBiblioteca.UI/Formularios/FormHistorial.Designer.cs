namespace SistemaGestionBiblioteca.UI.Formularios
{
    partial class FormHistorial
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
            panelContador = new Panel();
            lblTotalPila = new Label();
            lblTituloPila = new Label();
            lstHistorial = new ListBox();
            lblTituloLista = new Label();
            btnDeshacer = new Button();
            btnVerUltima = new Button();
            btnLimpiarHistorial = new Button();
            panelContador.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de Acciones";
            // 
            // panelContador
            // 
            panelContador.BackColor = Color.DarkSlateBlue;
            panelContador.BorderStyle = BorderStyle.FixedSingle;
            panelContador.Controls.Add(lblTotalPila);
            panelContador.Controls.Add(lblTituloPila);
            panelContador.Location = new Point(540, 55);
            panelContador.Name = "panelContador";
            panelContador.Size = new Size(250, 75);
            panelContador.TabIndex = 1;
            // 
            // lblTotalPila
            // 
            lblTotalPila.Dock = DockStyle.Fill;
            lblTotalPila.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalPila.ForeColor = Color.White;
            lblTotalPila.Location = new Point(0, 25);
            lblTotalPila.Name = "lblTotalPila";
            lblTotalPila.Size = new Size(248, 48);
            lblTotalPila.TabIndex = 1;
            lblTotalPila.Text = "0";
            lblTotalPila.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloPila
            // 
            lblTituloPila.Dock = DockStyle.Top;
            lblTituloPila.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTituloPila.ForeColor = Color.White;
            lblTituloPila.Location = new Point(0, 0);
            lblTituloPila.Name = "lblTituloPila";
            lblTituloPila.Size = new Size(248, 25);
            lblTituloPila.TabIndex = 0;
            lblTituloPila.Text = "Total de acciones:";
            lblTituloPila.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstHistorial
            // 
            lstHistorial.Font = new Font("Consolas", 9.5F);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(20, 80);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(500, 319);
            lstHistorial.TabIndex = 2;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.DarkSlateGray;
            lblTituloLista.Location = new Point(20, 55);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(137, 19);
            lblTituloLista.TabIndex = 3;
            lblTituloLista.Text = "Acciones recientes:";
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Crimson;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(540, 210);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(250, 42);
            btnDeshacer.TabIndex = 4;
            btnDeshacer.Text = "Deshacer última acción";
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnVerUltima
            // 
            btnVerUltima.BackColor = Color.SteelBlue;
            btnVerUltima.FlatStyle = FlatStyle.Flat;
            btnVerUltima.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerUltima.ForeColor = Color.White;
            btnVerUltima.Location = new Point(540, 155);
            btnVerUltima.Name = "btnVerUltima";
            btnVerUltima.Size = new Size(250, 42);
            btnVerUltima.TabIndex = 5;
            btnVerUltima.Text = "Ver última acción";
            btnVerUltima.UseVisualStyleBackColor = false;
            btnVerUltima.Click += btnVerUltima_Click;
            // 
            // btnLimpiarHistorial
            // 
            btnLimpiarHistorial.BackColor = Color.DarkGray;
            btnLimpiarHistorial.FlatStyle = FlatStyle.Flat;
            btnLimpiarHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarHistorial.ForeColor = Color.White;
            btnLimpiarHistorial.Location = new Point(540, 265);
            btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            btnLimpiarHistorial.Size = new Size(250, 35);
            btnLimpiarHistorial.TabIndex = 7;
            btnLimpiarHistorial.Text = "Limpiar historial";
            btnLimpiarHistorial.UseVisualStyleBackColor = false;
            btnLimpiarHistorial.Click += btnLimpiarHistorial_Click;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 420);
            Controls.Add(btnLimpiarHistorial);
            Controls.Add(btnVerUltima);
            Controls.Add(btnDeshacer);
            Controls.Add(lblTituloLista);
            Controls.Add(lstHistorial);
            Controls.Add(panelContador);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial";
            Load += FormHistorial_Load;
            panelContador.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panelContador;
        private Label lblTituloPila;
        private Label lblTotalPila;
        private ListBox lstHistorial;
        private Label lblTituloLista;
        private Button btnDeshacer;
        private Button btnVerUltima;
        private Button btnLimpiarHistorial;
    }
}
