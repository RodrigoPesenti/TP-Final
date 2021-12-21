
namespace TP_Final_UI
{
    partial class PantallaListaEjemplares
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
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.listaEjemplares = new System.Windows.Forms.DataGridView();
            this.botonPrestar = new System.Windows.Forms.Button();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(73, 31);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.PlaceholderText = "Ingrese ID a filtrar";
            this.textBoxFiltro.Size = new System.Drawing.Size(260, 23);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Location = new System.Drawing.Point(343, 31);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.botonFiltrar.TabIndex = 5;
            this.botonFiltrar.Text = "Buscar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonFiltrar_Click);
            // 
            // listaEjemplares
            // 
            this.listaEjemplares.AllowUserToAddRows = false;
            this.listaEjemplares.AllowUserToDeleteRows = false;
            this.listaEjemplares.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaEjemplares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID});
            this.listaEjemplares.Location = new System.Drawing.Point(165, 80);
            this.listaEjemplares.MultiSelect = false;
            this.listaEjemplares.Name = "listaEjemplares";
            this.listaEjemplares.ReadOnly = true;
            this.listaEjemplares.RowTemplate.Height = 25;
            this.listaEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaEjemplares.Size = new System.Drawing.Size(145, 304);
            this.listaEjemplares.TabIndex = 4;
            // 
            // botonPrestar
            // 
            this.botonPrestar.Location = new System.Drawing.Point(197, 401);
            this.botonPrestar.Name = "botonPrestar";
            this.botonPrestar.Size = new System.Drawing.Size(80, 37);
            this.botonPrestar.TabIndex = 7;
            this.botonPrestar.Text = "Prestar";
            this.botonPrestar.UseVisualStyleBackColor = true;
            this.botonPrestar.Click += new System.EventHandler(this.botonPrestar_Click);
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID Ejemplar";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            // 
            // PantallaListaEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.botonPrestar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.botonFiltrar);
            this.Controls.Add(this.listaEjemplares);
            this.Name = "PantallaListaEjemplares";
            this.Text = "PantallaListaEjemplares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaListaEjemplares_FormClosed);
            this.Load += new System.EventHandler(this.PantallaListaEjemplares_Load);
            this.VisibleChanged += new System.EventHandler(this.PantallaListaEjemplares_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.listaEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.DataGridView listaEjemplares;
        private System.Windows.Forms.Button botonPrestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
    }
}