namespace Estructuras
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

        private void BtnCola_Click(object sender, EventArgs e)
        {
            Cola ventana = new Cola();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaS ventana = new ListaS();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaD ventana = new ListaD();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           ListaC ventana = new ListaC();
            ventana.Show();
            this.Hide();
        }
    }
}
