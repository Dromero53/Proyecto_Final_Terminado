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
    public partial class Form1 : Form
    {
        TimeSpan tiempoTranscurrido;

        DateTime tiempoInicio = DateTime.MinValue;
        private Timer ti;
        public Form1()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;

        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            label2.Text = hoy.ToString("hh.mm.ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (saveFileIngreso.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileIngreso.FileName;


                StreamWriter textoArchivo = File.CreateText(rutaArchivo);

                textoArchivo.WriteLine("ESTACIONAMIENTO");
                textoArchivo.WriteLine("INGRESO");
                textoArchivo.WriteLine("Modelo: " + txtIngreso.Text);
                textoArchivo.WriteLine("Placas: " + txtIngreso2.Text);
                textoArchivo.WriteLine("Fecha y Hora de ingreso: \n" + DateTime.Now);
                textoArchivo.WriteLine("\n");

                textoArchivo.Flush();
                textoArchivo.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnEjecutar1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(txtRutaArchivo.Text);
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            leer.Close();
        }

        private void btnEjecutar2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(txtModSalida1.Text);
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox2.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            leer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el programa");
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = buscar.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtModSalida1.Text = buscar.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
