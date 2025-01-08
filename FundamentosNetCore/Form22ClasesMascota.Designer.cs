namespace FundamentosNetCore
{
    partial class Form22ClasesMascota
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            btnNuevaMascota = new Button();
            label3 = new Label();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 35);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 96);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(39, 129);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(188, 35);
            txtRaza.TabIndex = 3;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(39, 185);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(188, 64);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 9);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 5;
            label3.Text = "Mascotas";
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(42, 263);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(185, 64);
            btnLeerMascotas.TabIndex = 7;
            btnLeerMascotas.Text = "Leer mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(46, 345);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(181, 68);
            btnGuardarMascotas.TabIndex = 8;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(309, 41);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(277, 334);
            lstMascotas.TabIndex = 6;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22ClasesMascota
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 425);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form22ClasesMascota";
            Text = "Form22ClasesMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevaMascota;
        private Label label3;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private ListBox lstMascotas;
    }
}