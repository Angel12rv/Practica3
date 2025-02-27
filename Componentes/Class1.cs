using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public class CustomButton : Button
    {
        private Color originalColor;

        public CustomButton()
        {
            originalColor = this.BackColor;
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
            this.DoubleClick += OnDoubleClick;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue; // Cambia el color al pasar el mouse
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalColor; // Restaura el color original
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas realizar esta acción?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OnCustomDoubleClick(EventArgs.Empty);
            }
        }

        public event EventHandler CustomDoubleClick;

        protected virtual void OnCustomDoubleClick(EventArgs e)
        {
            CustomDoubleClick?.Invoke(this, e);
        }
    }
}