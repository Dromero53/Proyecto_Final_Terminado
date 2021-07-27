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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtModIngreso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                string rutaModArchivo = textBox1.Text;


                StreamWriter textoModArchivo = File.CreateText(rutaModArchivo);

                textoModArchivo.WriteLine("ESTACIONAMIENTO");
                textoModArchivo.WriteLine("INGRESO");
                textoModArchivo.WriteLine("Modelo: " + txtModIngreso1.Text);
                textoModArchivo.WriteLine("Placas: " + txtModIngreso2.Text);
                textoModArchivo.WriteLine("Fecha y Hora de ingreso: \n" + DateTime.Now);
                textoModArchivo.WriteLine("\n");

                textoModArchivo.Flush();
                textoModArchivo.Close();

            MessageBox.Show("Archivo Modificado Correctamente.");
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(textBox1.Text);
            MessageBox.Show("El archivo fue eliminado correctamente.");
        }
    }
}
