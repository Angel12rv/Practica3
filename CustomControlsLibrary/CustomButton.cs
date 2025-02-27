using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace CustomControlsLibrary
{
    public class CustomButton : Button
    {
        private Color originalColor;
        private System.Timers.Timer pressTimer; // Temporizador para detectar clic largo

        // Evento personalizado para clic largo
        public event EventHandler LongClick;

        public CustomButton()
        {
            originalColor = this.BackColor;
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;

            // Configurar el temporizador
            pressTimer = new System.Timers.Timer(2000); // 2 segundos
            pressTimer.AutoReset = false; // No repetir
            pressTimer.Elapsed += OnLongClick; // Suscribir al evento del temporizador

            // Suscribir a los eventos del mouse
            this.MouseDown += OnMouseDown;
            this.MouseUp += OnMouseUp;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalColor;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el temporizador cuando se presiona el botón
            pressTimer.Start();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            // Detener el temporizador cuando se suelta el botón
            pressTimer.Stop();
        }

        private void OnLongClick(object sender, ElapsedEventArgs e)
        {
            // Disparar el evento personalizado "LongClick"
            LongClick?.Invoke(this, EventArgs.Empty);
        }
    }
}