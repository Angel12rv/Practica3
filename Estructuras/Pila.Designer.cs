namespace Estructuras
{
    partial class Pila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            PilaGenerada = new ListBox();
            TextPila = new TextBox();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(568, 372);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(408, 372);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(249, 372);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Vaciar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(97, 372);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 31);
            label1.TabIndex = 4;
            label1.Text = "Pila";
            // 
            // PilaGenerada
            // 
            PilaGenerada.FormattingEnabled = true;
            PilaGenerada.HorizontalScrollbar = true;
            PilaGenerada.Location = new Point(164, 156);
            PilaGenerada.Name = "PilaGenerada";
            PilaGenerada.Size = new Size(470, 124);
            PilaGenerada.TabIndex = 5;
            // 
            // TextPila
            // 
            TextPila.Location = new Point(164, 308);
            TextPila.Name = "TextPila";
            TextPila.Size = new Size(125, 27);
            TextPila.TabIndex = 6;
            // 
            // Pila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextPila);
            Controls.Add(PilaGenerada);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnAgregar);
            Name = "Pila";
            Text = "Pila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private ListBox PilaGenerada;
        private TextBox TextPila;
    }
}