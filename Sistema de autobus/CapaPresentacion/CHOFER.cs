using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CHOFER : Form
    {
        public CHOFER()
        {
            InitializeComponent();
        }

        public string IdChofer;
        public bool editar = false;

        CE_AUTOBUS ce_Autobus = new CE_AUTOBUS();
        CN_AUTOBUS cn_Autobus = new CN_AUTOBUS();

        public void MostrarDatos(string buscar)
        {
            CN_AUTOBUS cn_Autobus = new CN_AUTOBUS();
            dataGridView1.DataSource = cn_Autobus.ListChofer(buscar);
        }

        private void OcultarColumnas()
        {
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
        }

        private void LimpiarCaja()
        {
            editar = false;
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            MtbCedula.Text = "";
        }

        private void CHOFER_Load(object sender, EventArgs e)
        {
            MostrarDatos("");
            OcultarColumnas();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void BtInsertar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    ce_Autobus.NOMBRE = TxtNombre.Text;
                    ce_Autobus.APELLIDO = TxtApellido.Text;
                    ce_Autobus.FECHA = DtpFecha.Value;
                    ce_Autobus.CEDULA = MtbCedula.Text;

                    cn_Autobus.InsertChofer(ce_Autobus);
                    MessageBox.Show("Agregado con Exito.");
                    MostrarDatos("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar " + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    ce_Autobus.ID_CHOFER = Convert.ToInt32(IdChofer);
                    ce_Autobus.NOMBRE = TxtNombre.Text;
                    ce_Autobus.APELLIDO = TxtApellido.Text;
                    ce_Autobus.FECHA = DtpFecha.Value;
                    ce_Autobus.CEDULA = MtbCedula.Text;

                    cn_Autobus.EditChofer(ce_Autobus);
                    MessageBox.Show("Chofer Editado");
                    MostrarDatos("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el chofer." + ex);
                }
            }
        }

    }
}
