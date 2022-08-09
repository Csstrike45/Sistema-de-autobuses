using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChofer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHOFER chofer = new CHOFER();
            chofer.Show();
        }

        private void BtnAutobus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AUTOBUS autobus = new AUTOBUS();
            autobus.Show();

        }

        private void BtnRuta_Click(object sender, EventArgs e)
        {
            this.Hide();
            RUTA ruta = new RUTA();
            ruta.Show();
        }

        private void BtnViaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIAJE viaje = new VIAJE();
            viaje.Show();
        }
    }
}
