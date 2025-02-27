namespace Estructuras
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnPila = new Button();
            BtnCola = new Button();
            BtnListaS = new Button();
            BtnListasD = new Button();
            BtnListaC = new Button();
            SuspendLayout();
            // 
            // BtnPila
            // 
            BtnPila.AccessibleRole = AccessibleRole.None;
            BtnPila.Location = new Point(112, 127);
            BtnPila.Name = "BtnPila";
            BtnPila.Size = new Size(164, 66);
            BtnPila.TabIndex = 0;
            BtnPila.Text = "Pilas";
            BtnPila.UseVisualStyleBackColor = true;
            BtnPila.Click += BtnPila_Click;
            // 
            // BtnCola
            // 
            BtnCola.Location = new Point(316, 127);
            BtnCola.Name = "BtnCola";
            BtnCola.Size = new Size(164, 66);
            BtnCola.TabIndex = 1;
            BtnCola.Text = "Colas";
            BtnCola.UseVisualStyleBackColor = true;
            BtnCola.Click += BtnCola_Click;
            // 
            // BtnListaS
            // 
            BtnListaS.Location = new Point(503, 127);
            BtnListaS.Name = "BtnListaS";
            BtnListaS.Size = new Size(198, 66);
            BtnListaS.TabIndex = 2;
            BtnListaS.Text = "Listas Simples";
            BtnListaS.UseVisualStyleBackColor = true;
            BtnListaS.Click += button1_Click;
            // 
            // BtnListasD
            // 
            BtnListasD.Location = new Point(168, 243);
            BtnListasD.Name = "BtnListasD";
            BtnListasD.Size = new Size(198, 66);
            BtnListasD.TabIndex = 3;
            BtnListasD.Text = "Listas Dobles";
            BtnListasD.UseVisualStyleBackColor = true;
            BtnListasD.Click += button1_Click_1;
            // 
            // BtnListaC
            // 
            BtnListaC.Location = new Point(429, 243);
            BtnListaC.Name = "BtnListaC";
            BtnListaC.Size = new Size(198, 66);
            BtnListaC.TabIndex = 4;
            BtnListaC.Text = "Listas Circulares";
            BtnListaC.UseVisualStyleBackColor = true;
            BtnListaC.Click += button1_Click_2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnListaC);
            Controls.Add(BtnListasD);
            Controls.Add(BtnListaS);
            Controls.Add(BtnCola);
            Controls.Add(BtnPila);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPila;
        private Button BtnCola;
        private Button BtnListaS;
        private Button BtnListasD;
        private Button BtnListaC;
    }
}
