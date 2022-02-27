using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaReporte : Form
    {
        private Form pantallaAnterior;

        public PantallaReporte(Form pPantallaAnterior)
        {
            InitializeComponent();
            pantallaAnterior = pPantallaAnterior;
        }

        private void PantallaReporte_Load(object sender, EventArgs e)
        {
            var path = @"./Reporte.json";
            string json2 = File.ReadAllText(path);
            List<EjemplarDTO> Reporte = JsonConvert.DeserializeObject<List<EjemplarDTO>>(json2);

            foreach (var ejemplarDTO in Reporte)
            {
                listaEjemplares.Rows.Add(ejemplarDTO.ID);
            }
        }

        private void PantallaReporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Show();
        }
    }
}
