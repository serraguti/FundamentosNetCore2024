﻿namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(24, 58);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(147, 39);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 111);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(27, 146);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(144, 39);
            txtNumero2.TabIndex = 3;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(206, 92);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(252, 51);
            btnSumarNumeros.TabIndex = 4;
            btnSumarNumeros.Text = "Sumar números";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(25, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 289);
            Controls.Add(lblResultado);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}