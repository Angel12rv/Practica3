using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlsLibrary;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Crea una instancia de CustomButton
            CustomButton customButton = new CustomButton();
            customButton.Text = "Haz doble clic";
            customButton.Location = new Point(50, 50);
            customButton.Size = new Size(150, 50);

            // Agrega el botón al formulario
            this.Controls.Add(customButton);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
