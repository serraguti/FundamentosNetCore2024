namespace FundamentosNetCore
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(35, 45);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(307, 394);
            txtContenido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 11);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(378, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 35);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(381, 102);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(152, 79);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(385, 217);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(148, 62);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(386, 295);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(147, 65);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write file";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 11);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(577, 48);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(278, 394);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 451);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Label label3;
        private ListBox lstNombres;
    }
}