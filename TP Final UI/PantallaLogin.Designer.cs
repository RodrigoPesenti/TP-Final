﻿
namespace TP_Final_UI
{
    partial class PantallaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(124, 266);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptar.TabIndex = 0;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(90, 187);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PlaceholderText = "Usuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(151, 23);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(90, 229);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.PlaceholderText = "Contraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(151, 23);
            this.textBoxContraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_Final_UI.Properties.Resources.Inicio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.BotonAceptar);
            this.Name = "PantallaLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

