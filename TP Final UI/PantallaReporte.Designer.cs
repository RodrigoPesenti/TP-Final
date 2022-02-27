
namespace TP_Final_UI
{
    partial class PantallaReporte
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
            this.listaEjemplares = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaEjemplares)).BeginInit();
            this.SuspendLayout();
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
            this.listaEjemplares.Location = new System.Drawing.Point(65, 12);
            this.listaEjemplares.MultiSelect = false;
            this.listaEjemplares.Name = "listaEjemplares";
            this.listaEjemplares.ReadOnly = true;
            this.listaEjemplares.RowTemplate.Height = 25;
            this.listaEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaEjemplares.Size = new System.Drawing.Size(145, 333);
            this.listaEjemplares.TabIndex = 5;
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID Ejemplar";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            // 
            // PantallaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 357);
            this.Controls.Add(this.listaEjemplares);
            this.Name = "PantallaReporte";
            this.Text = "PantallaReporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaReporte_FormClosed);
            this.Load += new System.EventHandler(this.PantallaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEjemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
    }
}