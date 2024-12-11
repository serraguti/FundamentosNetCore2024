namespace FundamentosNetCore
{
    partial class Form06ValidarMail
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
            txtEmail = new TextBox();
            btnValidarMail = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 39);
            txtEmail.TabIndex = 1;
            // 
            // btnValidarMail
            // 
            btnValidarMail.Location = new Point(40, 103);
            btnValidarMail.Name = "btnValidarMail";
            btnValidarMail.Size = new Size(410, 49);
            btnValidarMail.TabIndex = 2;
            btnValidarMail.Text = "Validar Email";
            btnValidarMail.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(41, 170);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 230);
            Controls.Add(lblResultado);
            Controls.Add(btnValidarMail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidarMail;
        private Label lblResultado;
    }
}