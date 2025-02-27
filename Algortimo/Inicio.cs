namespace Algortimo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        Colas ventana2 = new Colas();
        ventana2.Show();
        this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Pilas ventana = new Pilas();
        ventana.Show();
        this.Hide();
        }

        private void BotonListasS_Click(object sender, EventArgs e)
        {

        }
    }
}
