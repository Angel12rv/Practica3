using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaAlgoritmo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnPila_Click(object sender, EventArgs e)
        {
        Pila ventana = new Pila();
        ventana.Show();

        this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
