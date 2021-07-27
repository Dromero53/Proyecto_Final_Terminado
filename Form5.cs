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


namespace Proyecto_Estacionamiento
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string rutaModSalida = textBox1.Text;


            StreamWriter textoModSalida = File.CreateText(rutaModSalida);

            textoModSalida.WriteLine("ESTACIONAMIENTO");
            textoModSalida.WriteLine("INGRESO");
            textoModSalida.WriteLine("Modelo: " + txtModSalida1.Text);
            textoModSalida.WriteLine("Placas: " + txtModSalida2.Text);
            textoModSalida.WriteLine("Fecha y Hora de ingreso: \n" + DateTime.Now);
            textoModSalida.WriteLine("\n");

            textoModSalida.Flush();
            textoModSalida.Close();

            MessageBox.Show("Archivo Modificado Correctamente.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(textBox1.Text);
            MessageBox.Show("El archivo fue eliminado correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
