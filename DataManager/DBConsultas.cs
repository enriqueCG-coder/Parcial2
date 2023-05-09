using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable MOVIMIENTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select m.IDMovimiento, m.Fecha, m.IDCliente, c.Cliente, m.Concepto, m.Monto, m.Flujo from Movimientos m, Clientes c;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDCliente, Cliente FROM Clientes;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
