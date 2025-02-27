using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentesPersonalizados1;
namespace ProbarComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Usar CustomButton
            CustomButton customButton = new CustomButton();
            customButton.Text = "Haz click";
            customButton.Location = new Point(50, 50);
            this.Controls.Add(customButton);

            // Usar CustomTextBox
            CustomTextBox customTextBox = new CustomTextBox();
            customTextBox.AllowedInputType = CustomTextBox.InputType.NumbersOnly;
            customTextBox.Location = new Point(50, 100);
            this.Controls.Add(customTextBox);

            // Usar InputValidator
            string input = "assdfe";//Aqui se ingresan los numeros o texto que se verificara si son puros numeros
            bool isNumeric = InputValidator.EsSoloNumeros(input);
            MessageBox.Show($"¿Es '{input}' solo números? {isNumeric}");

            // Usar RFCValidator
            string rfc = "3BCD123456XYZ";//Aqui se modifican los datos de la RFC que despues se comprobaran
            bool isValidRFC = RFCValidator.EsRFCValido(rfc);
            MessageBox.Show($"¿Es '{rfc}' un RFC válido? {isValidRFC}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
