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
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            InitializeComponent();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
            }
        }

        private void btnEjecutar2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(textBox1.Text);
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox3.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            leer.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(txtTiempoEstacionamiento.Text))
            {
                case 1:
                    MessageBox.Show("Total a cobrar = $10");
                    break;
                case 2:
                    MessageBox.Show("Total a cobrar = $20");
                    break;
                case 3:
                    MessageBox.Show("Total a cobrar = $30");
                    break;
                case 4:
                    MessageBox.Show("Total a cobrar = $40");
                    break;
                case 5:
                    MessageBox.Show("Total a cobrar = $50");
                    break;
                case 6:
                    MessageBox.Show("Total a cobrar = $60");
                    break;
                case 7:
                    MessageBox.Show("Total a cobrar = $70");
                    break;
                case 8:
                    MessageBox.Show("Total a cobrar = $80");
                    break;
                case 9:
                    MessageBox.Show("Total a cobrar = $90");
                    break;
                case 10:
                    MessageBox.Show("Total a cobrar = $100");
                    break;
                case 11:
                    MessageBox.Show("Total a cobrar = $110");
                    break;
                case 12:
                    MessageBox.Show("Total a cobrar = $120");
                    break;
                case 0:
                    MessageBox.Show("Ingrese una cantidad");
                    break;
            }
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {

            StreamReader leer = new StreamReader(textBox1.Text);
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBoxRecibo.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            leer.Close();
            MessageBox.Show("PAGADO.");

            richTextBoxRecibo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
