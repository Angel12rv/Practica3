using System.Linq.Expressions;
using System.Runtime.InteropServices.ObjectiveC;

namespace GUI_Dinamica
{
    public partial class Form1 : Form
    {
        private Button btnAddControls;
        private List<Button> dynamicButtons = new List<Button>();
        private int controlCounter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configuracion de la ventana
            this.Text = "Creacion Dinamica de controles";
            this.Size = new Size(400, 400);
            //Boton para agregar controles dinamicamente
            btnAddControls = new Button();
            btnAddControls.Text = "Agregar controles";
            btnAddControls.Location = new Point(20, 20);
            btnAddControls.Click += new EventHandler(AddControls);
            this.Controls.Add(btnAddControls);

        }
        private void AddControls(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Text = "Boton" + controlCounter;
            newButton.Size = new Size(100, 30);
            newButton.Location = new Point(20, 60 + dynamicButtons.Count * 40);
            newButton.Click += DynamicButtonClick;
            dynamicButtons.Add(newButton);
            this.Controls.Add(newButton);
            controlCounter++;

        }
        private void DynamicButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("Has presionado: " + clickedButton.Text);
        }
    }
}
