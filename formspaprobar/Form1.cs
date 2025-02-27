using System;
using System.Drawing;
using System.Windows.Forms;
using CustomControlsLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Crea una instancia de CustomButton
            CustomButton customButton = new CustomButton();
            customButton.Text = "Mantén presionado";
            customButton.Location = new Point(50, 50);
            customButton.Size = new Size(150, 50);

            // Suscribir al evento personalizado "LongClick"
            customButton.LongClick += OnLongClick;

            // Agrega el botón al formulario
            this.Controls.Add(customButton);
        }

        private void OnLongClick(object sender, EventArgs e)
        {
            // Mostrar un mensaje cuando se detecte un clic largo
            MessageBox.Show("¡Clic largo detectado!");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
