namespace Algortimo
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
            Titulo = new Label();
            BotonPilas = new Button();
            BotonColas = new Button();
            BotonListasS = new Button();
            BotonListasC = new Button();
            BotonSimplesD = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(313, 27);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(135, 31);
            Titulo.TabIndex = 0;
            Titulo.Text = "Algortimos";
            Titulo.Click += label1_Click;
            // 
            // BotonPilas
            // 
            BotonPilas.Location = new Point(130, 109);
            BotonPilas.Name = "BotonPilas";
            BotonPilas.Size = new Size(128, 56);
            BotonPilas.TabIndex = 1;
            BotonPilas.Text = "Pilas";
            BotonPilas.UseVisualStyleBackColor = true;
            BotonPilas.Click += button1_Click;
            // 
            // BotonColas
            // 
            BotonColas.Location = new Point(348, 109);
            BotonColas.Name = "BotonColas";
            BotonColas.Size = new Size(128, 56);
            BotonColas.TabIndex = 2;
            BotonColas.Text = "Colas";
            BotonColas.UseVisualStyleBackColor = true;
            BotonColas.Click += button2_Click;
            // 
            // BotonListasS
            // 
            BotonListasS.Location = new Point(557, 109);
            BotonListasS.Name = "BotonListasS";
            BotonListasS.Size = new Size(128, 56);
            BotonListasS.TabIndex = 3;
            BotonListasS.Text = "Listas simples";
            BotonListasS.UseVisualStyleBackColor = true;
            BotonListasS.Click += BotonListasS_Click;
            // 
            // BotonListasC
            // 
            BotonListasC.BackColor = SystemColors.ControlDarkDark;
            BotonListasC.FlatStyle = FlatStyle.System;
            BotonListasC.Location = new Point(440, 238);
            BotonListasC.Name = "BotonListasC";
            BotonListasC.Size = new Size(245, 63);
            BotonListasC.TabIndex = 4;
            BotonListasC.Text = "Listas circulares";
            BotonListasC.UseVisualStyleBackColor = false;
            // 
            // BotonSimplesD
            // 
            BotonSimplesD.Location = new Point(130, 238);
            BotonSimplesD.Name = "BotonSimplesD";
            BotonSimplesD.Size = new Size(245, 63);
            BotonSimplesD.TabIndex = 5;
            BotonSimplesD.Text = "Listas dobles";
            BotonSimplesD.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonSimplesD);
            Controls.Add(BotonListasC);
            Controls.Add(BotonListasS);
            Controls.Add(BotonColas);
            Controls.Add(BotonPilas);
            Controls.Add(Titulo);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button BotonPilas;
        private Button BotonColas;
        private Button BotonListasS;
        private Button BotonListasC;
        private Button BotonSimplesD;
    }
}
