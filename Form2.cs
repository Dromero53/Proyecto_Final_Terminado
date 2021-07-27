using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Proyecto_Estacionamiento;
using System.Diagnostics;


namespace Proyecto_Estructur_de_Archvos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviarAsis_Click(object sender, EventArgs e)
        {
            if (saveFileReportes.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileReportes.FileName;


                StreamWriter textoArchivo = File.CreateText(rutaArchivo);

                textoArchivo.WriteLine("ESTACIONAMIENTO");
                textoArchivo.WriteLine("Reportes");
                textoArchivo.WriteLine("Fecha y Hora de reporte: \n" + DateTime.Now);
                textoArchivo.WriteLine(txtEnviar.Text);
                textoArchivo.WriteLine("\n");

                textoArchivo.Flush();
                textoArchivo.Close();
            }
        }

        private void btnLimpiarAsis_Click(object sender, EventArgs e)
        {
            txtEnviar.Text = "";
        }

        private void btnMostrarReportes_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(richTextBox1.Text);
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    txtReportes.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            leer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = buscar.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
