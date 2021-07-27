using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto_Estacionamiento.BLL;

namespace Proyecto_Estacionamiento.DAL
{
    class VehiculosDALL
    {
        ConexionDAL conexion;

        public VehiculosDALL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar(VehiculosBLL oVehiculosBLL)
        {
           return conexion.ejecutarComandoSinRetornoDatos("INSERT INTO Ingreso (vehiculo, placas, color) VALUES('"+oVehiculosBLL.Vehiculo+"', '"+oVehiculosBLL.Placas+"', '"+oVehiculosBLL.color+"')");
        }

        public int Eliminar(VehiculosBLL oVehiculosBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("DELETE FROM Ingreso WHERE ID="+oVehiculosBLL.ID);

            return 1;
        }

        public int Modificar(VehiculosBLL oVehiculosBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("UPDATE Ingreso " +
                "SET  vehiculo = '"+oVehiculosBLL.Vehiculo +"'" + 
                "WHERE ID=" + oVehiculosBLL.ID);

            conexion.ejecutarComandoSinRetornoDatos("UPDATE Ingreso " +
                "SET  placas = '" + oVehiculosBLL.Placas + "'" +
                "WHERE ID=" + oVehiculosBLL.ID);

            conexion.ejecutarComandoSinRetornoDatos("UPDATE Ingreso " +
                "SET  color = '" + oVehiculosBLL.color + "'" +
                "WHERE ID=" + oVehiculosBLL.ID);

            return 1;
        }

        public DataSet MostrarVehiculos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Ingreso");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
