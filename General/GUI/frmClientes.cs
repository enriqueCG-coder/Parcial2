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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        BindingSource _DATOS = new BindingSource();

        #region METODOS
        //CONTADOR DE REGISTROS DEL DATAGRIDVIEW
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.CLIENTES();
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = _DATOS;
                lblRegistros.Text = dgvClientes.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        //METODO PARA LIMPIAR LOS TEXTBOX
        private void limpiar()
        {
            txtID.Clear();
            txtCliente.Clear();
        }

        #endregion


        #region EVENTOS DEL FORMULARIO CLIENTES
        //CUANDO SE CARGA EL FORMULARIO
        private void frmClientes_Load(object sender, EventArgs e)
        {
            panelClientes.Visible = false;
            CargarDatos();
        }

        //CUANDO SE DA CLICK EN EL BOTON AGREGAR 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = true;
        }

        //CUANDO SE DA CLICK EN EL BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridView dgv = dgvClientes;
                txtID.Text = dgv.CurrentRow.Cells["IDCliente"].Value.ToString();
                txtCliente.Text = dgv.CurrentRow.Cells["Cliente"].Value.ToString();
                panelClientes.Visible = true;

            }
        }

        //CUANDO SE DA CLICK EN EL BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Clientes oCli = new CLS.Clientes();
                oCli.IDCliente = dgvClientes.CurrentRow.Cells["IDCliente"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oCli.Eliminar())
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


        #region EVENTOS DEL PANEL CLIENTES
        //CUANDO SE DA CLICK EN EL BOTON GUARDAR DEL PANEL
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Clientes oCli = new CLS.Clientes();
            //Sincronizar la entidad con la interfaz
            oCli.Cliente = txtCliente.Text;
            oCli.IDCliente = txtID.Text;
            //Identificar la accion a realizar
            if (txtID.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (oCli.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    limpiar();
                    panelClientes.Visible = false;
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Realizar la operacion de insertar
                if (oCli.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    limpiar();
                    panelClientes.Visible = false;
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //CUANDO SE DA CLIC EN EL BOTON CANCELAR DEL PANEL
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            panelClientes.Visible = false;
        }
        #endregion

    }
}
