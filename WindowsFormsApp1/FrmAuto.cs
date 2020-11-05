using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Entidades;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class FrmAuto : Form
    {
        N_Autobuses objNegocio_A = new N_Autobuses();

        public FrmAuto()
        {
            InitializeComponent();
        }
               
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                E_Autobuses.ID_Chofer1 = int.Parse(txtIDChofer.Text);
                E_Autobuses.Marca1 = txtMarca.Text.ToUpper();
                E_Autobuses.Modelo1 = txtModelo.Text.ToUpper();
                E_Autobuses.Placa1 = txtPlaca.Text;
                E_Autobuses.Color1 = txtColor.Text.ToUpper();
                E_Autobuses.Año1 = Convert.ToDateTime(dateTimePickerAño.Text);


                objNegocio_A.Guardando_N();
                Limpiar();

                MessageBox.Show(" Guardado");
                dataGridViewAuto.DataSource = objNegocio_A.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnEdiar_Click_1(object sender, EventArgs e)
        {
            try
            {
                E_Autobuses.ID1 = int.Parse(txtID.Text);
                E_Autobuses.ID_Chofer1 = int.Parse(txtIDChofer.Text);
                E_Autobuses.Marca1 = txtMarca.Text.ToUpper();
                E_Autobuses.Modelo1 = txtModelo.Text.ToUpper();
                E_Autobuses.Placa1 = txtPlaca.Text;
                E_Autobuses.Color1 = txtColor.Text.ToUpper();
                E_Autobuses.Año1 = Convert.ToDateTime(dateTimePickerAño.Text);

                objNegocio_A.Editando_N();
                Limpiar();

                MessageBox.Show(" Editado");
                dataGridViewAuto.DataSource = objNegocio_A.Mostrando_N();

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
                E_Autobuses.ID1 = int.Parse(txtID.Text);
                E_Autobuses.ID_Chofer1 = int.Parse(txtIDChofer.Text);
                objNegocio_A.Borrando_N();

                MessageBox.Show(" Eliminado");

                dataGridViewAuto.DataSource = objNegocio_A.Mostrando_N();
                Limpiar();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");

            }
        }
        private void btnBuscae_Click(object sender, EventArgs e)
        {
            try
            {
                E_Autobuses.ID1 = int.Parse(txtID.Text);
                E_Autobuses.ID_Chofer1 = int.Parse(txtIDChofer.Text);

                dataGridViewAuto.DataSource = objNegocio_A.Buscando_N();
                Limpiar();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        public void Limpiar()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        private void FrmAuto_Load(object sender, EventArgs e)
        {
            dataGridViewAuto.DataSource = objNegocio_A.Mostrando_N();
        }
    }
}
