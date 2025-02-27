namespace ProgramaAlgoritmo
{
    partial class Inicio
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
            this.BtnPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPila
            // 
            this.BtnPila.Location = new System.Drawing.Point(136, 79);
            this.BtnPila.Name = "BtnPila";
            this.BtnPila.Size = new System.Drawing.Size(105, 44);
            this.BtnPila.TabIndex = 0;
            this.BtnPila.Text = "Pilas";
            this.BtnPila.UseVisualStyleBackColor = true;
            this.BtnPila.Click += new System.EventHandler(this.BtnPila_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPila);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPila;
    }
}