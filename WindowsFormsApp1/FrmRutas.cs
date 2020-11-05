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
    public partial class FrmRutas : Form
    {

        N_Rutas objNegocio = new N_Rutas();

        public FrmRutas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);
                E_Rutas.Rutas1 = comboBoxRutas.Text.ToUpper();
                


                objNegocio.Guardando_N();
                Limpiar_C();

                MessageBox.Show(" Guardado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

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
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);
                E_Rutas.Rutas1 = comboBoxRutas.Text.ToUpper();



                objNegocio.Editando_N();
                Limpiar_C();

                MessageBox.Show(" Editado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

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
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);



                objNegocio.Buscando_N();
                Limpiar_C();

                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

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
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);

                objNegocio.Borrando_N();
                Limpiar_C();

                MessageBox.Show(" Eliminado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();


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

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

        }
    }
}
