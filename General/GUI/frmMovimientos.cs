using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class frmMovimientos : Form
    {
        public frmMovimientos()
        {
            InitializeComponent();
        }

        BindingSource _DATOS = new BindingSource();

        #region METODOS
        

        //METODO QUE LLENA LOS DATOS DE CLIENTE EN PANEL MOVIMIENTOS
        private void LlenarDatos()
        {
            txtIDCliente.Text = dgvCli.CurrentRow.Cells["pIDCliente"].Value.ToString();
            txtCli.Text = dgvCli.CurrentRow.Cells["pCliente"].Value.ToString();
        }

        //CARGA LOS CLIENTES 
        private void cargarClientes()
        {
            _DATOS.DataSource = DataManager.DBConsultas.CLIENTES();
            dgvCli.AutoGenerateColumns = false;
            dgvCli.DataSource = _DATOS;
        }

        //CONTADOR DE REGISTROS DEL DATAGRIDVIEW
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.MOVIMIENTOS();
                dgvMov.AutoGenerateColumns = false;
                dgvMov.DataSource = _DATOS;
                lblRegistros.Text = dgvMov.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        //METODO PARA LIMPIAR LOS TEXTBOX
        private void limpiar()
        {
            txtID.Clear();
            dtpFecha.Value = DateTime.Now;
            txtCli.Clear();
            txtIDCliente.Clear();
            txtConcepto.Clear();
            txtFlujo.Clear();
            txtMonto.Clear();
        }
        #endregion

        #region EVENTOS FORM MOVIMIENTOS
        //EVENTO CUANDO SE ABRE EL FORMULARIO DE MOVIMIENTOS
        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            panelMovimientos.Visible = false;
            panelClientes.Visible = false;
            txtIDCliente.Visible = false;
            txtCli.Enabled = false;
            CargarDatos();
        }

        //EVENTO DESPUES DE DAR CLICK EN BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelMovimientos.Visible = true;
        }

        //EVENTO DESPUES DE DAR CLICK EN BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridView dgv = dgvMov;


                dtpFecha.Value = Convert.ToDateTime(dgv.CurrentRow.Cells["Fecha"].Value.ToString());
                txtIDCliente.Text = dgv.CurrentRow.Cells["IDCliente"].Value.ToString();
                txtCli.Text = dgv.CurrentRow.Cells["Cliente"].Value.ToString();
                txtConcepto.Text = dgv.CurrentRow.Cells["Concepto"].Value.ToString();
                txtMonto.Text = dgv.CurrentRow.Cells["Monto"].Value.ToString();
                txtFlujo.Text = dgv.CurrentRow.Cells["Flujo"].Value.ToString();
                txtID.Text = dgv.CurrentRow.Cells["IDMovimiento"].Value.ToString();
                panelMovimientos.Visible = true;

            }
        }

        //EVENTO AL DAR CLICK EN BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Movimientos oMov = new CLS.Movimientos();
                oMov.IDMovimiento = dgvMov.CurrentRow.Cells["IDMovimiento"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oMov.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region EVENTOS PANEL MOVIMIENTOS
        //EVENTO DESPUES DE DAR CLICK EN EL BOTON GUARDAR DEL PANEL MOV
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Movimientos oMov = new CLS.Movimientos();
            //Sincronizar la entidad con la interfaz
            oMov.Fecha = Convert.ToString(dtpFecha.Value.ToString("dd/MM/yyyy"));
            oMov.IDCliente = txtIDCliente.Text;
            oMov.Concepto = txtConcepto.Text;
            oMov.Monto = txtMonto.Text;
            oMov.Flujo = txtFlujo.Text;
            oMov.IDMovimiento = txtID.Text;
            //Identificar la accion a realizar
            if (txtID.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (oMov.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    limpiar();
                    panelMovimientos.Visible = false;
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Realizar la operacion de insertar
                if (oMov.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    limpiar();
                    panelMovimientos.Visible = false;
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //EVENTO AL DAR CLICK EN EL BOTON CANCELAR DEL PANEL MOV
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            panelMovimientos.Visible = false;
        }

        //EVENTO AL DAR CLICK EN EL BOTON BUSCAR DEL PANEL MOV
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarClientes();
            panelClientes.Visible = true;

        }
        #endregion

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dgvCli_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarDatos();
            panelClientes.Visible = false;
        }
    }
}
