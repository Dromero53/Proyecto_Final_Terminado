using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Estacionamiento.BLL;
using Proyecto_Estacionamiento.DAL;

namespace Proyecto_Estacionamiento
{
    public partial class Form7 : Form
    {
        VehiculosDALL OVehiculosDALL;
        public Form7()
        {
            OVehiculosDALL = new VehiculosDALL();
            InitializeComponent();
            LLegarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ConexionDAL conexion = new ConexionDAL();
            MessageBox.Show("Conectado... ");
            OVehiculosDALL.Agregar(RecuperarInformacion());
            LLegarGrid();
        }

        private VehiculosBLL RecuperarInformacion()
        {
            VehiculosBLL oVehiculosBLL = new VehiculosBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oVehiculosBLL.ID = ID;
            oVehiculosBLL.Vehiculo = txtVehiculos.Text;
            oVehiculosBLL.Placas = txtPlacas.Text;
            oVehiculosBLL.color = txtColor.Text;
            return oVehiculosBLL;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvVehiculos.ClearSelection();
            if (indice >= 0)
            {
                txtID.Text = dgvVehiculos.Rows[indice].Cells[0].Value.ToString();
                txtVehiculos.Text = dgvVehiculos.Rows[indice].Cells[1].Value.ToString();
                txtPlacas.Text = dgvVehiculos.Rows[indice].Cells[2].Value.ToString();
                txtColor.Text = dgvVehiculos.Rows[indice].Cells[3].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            OVehiculosDALL.Eliminar(RecuperarInformacion());
            LLegarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OVehiculosDALL.Modificar(RecuperarInformacion());
            LLegarGrid();
        }

        public void LLegarGrid()
        {
            dgvVehiculos.DataSource = OVehiculosDALL.MostrarVehiculos().Tables[0];

            dgvVehiculos.Columns[0].HeaderText = "ID:";
            dgvVehiculos.Columns[1].HeaderText = "Vehiculo:";
            dgvVehiculos.Columns[2].HeaderText = "Placas:";
            dgvVehiculos.Columns[3].HeaderText = "Color:";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtVehiculos.Text = "";
            txtPlacas.Text = "";
            txtColor.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
