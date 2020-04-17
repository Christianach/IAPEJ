using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAPEJ
{
    public partial class logo : Form
    {
        public logo()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form consultar = new Consultar();
            consultar.Show();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            Form ingresar = new añadir();
            ingresar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
