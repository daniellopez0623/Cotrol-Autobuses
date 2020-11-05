using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class FrmChoferes : Form
    {
        N_Choferes objNegocio = new N_Choferes();

        public FrmChoferes()
        {
            InitializeComponent();
        }

            
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                E_Choferes.Nombre1 = txtNombre.Text.ToUpper();
                E_Choferes.Apellido1 = txtApellido.Text.ToUpper();
                E_Choferes.Cedula1 = mskTxtCedula.Text;
                E_Choferes.FechaNacimiento1 = Convert.ToDateTime(dateTimePickerFecha.Text);


                objNegocio.Guardando_N();
                Limpiar_C();

                MessageBox.Show("Registro Guardado");

                dataGridViewChoferes.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnEdiar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Choferes.ID1 = int.Parse(txtID.Text);
                E_Choferes.Nombre1 = txtNombre.Text.ToUpper();
                E_Choferes.Apellido1 = txtApellido.Text.ToUpper();
                E_Choferes.Cedula1 = mskTxtCedula.Text;
                E_Choferes.FechaNacimiento1 = Convert.ToDateTime(dateTimePickerFecha.Text);

                objNegocio.Editando_N();
                Limpiar_C();

                MessageBox.Show("Registro Editado");
                dataGridViewChoferes.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                E_Choferes.Nombre1 = txtNombre.Text;
                E_Choferes.ID1 = int.Parse(txtID.Text);

              
                dataGridViewChoferes.DataSource = objNegocio.Buscando_N();

                Limpiar_C();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Choferes.ID1 = int.Parse(txtID.Text);
                objNegocio.Borrando_N();

                MessageBox.Show("Registro Eliminado");

                dataGridViewChoferes.DataSource = objNegocio.Mostrando_N();
                Limpiar_C();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");

            }
        }
        public void Limpiar_C()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }
        private void FrmChoferes_Load(object sender, EventArgs e)
        {
            dataGridViewChoferes.DataSource = objNegocio.Mostrando_N();
        }

    }
}
