using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Movimientos
    {
        String _IDMovimiento;
        String _Fecha;
        String _IDCliente;
        String _Concepto;
        String _Monto;
        String _Flujo;

        public String IDMovimiento { get => _IDMovimiento; set => _IDMovimiento = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public string Concepto { get => _Concepto; set => _Concepto = value; }
        public string Monto { get => _Monto; set => _Monto = value; }
        public string Flujo { get => _Flujo; set => _Flujo = value; }


        //metodo para insertar un registro en la base de datos 
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = "INSERT INTO Movimientos (Fecha,IDCliente,Concepto,Monto,Flujo) VALUES('" + _Fecha + "', " + _IDCliente + ", '" + _Concepto + "', '" + _Monto + "', '" + _Flujo + "');";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        //metodo para actualizar un registro en la base de datos

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = "UPDATE Movimientos " +
                            "SET Fecha= '" + _Fecha + "', IDCliente = " + _IDCliente + ",Concepto= '" + _Concepto + "'," +
                            "Monto = '" + _Monto + "', Flujo = '" + _Flujo + "' WHERE IDMovimiento = " + _IDMovimiento + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        //metodo para eliminar un registro de la base datos 
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"DELETE FROM Movimientos WHERE IDMovimiento=" + _IDMovimiento + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
