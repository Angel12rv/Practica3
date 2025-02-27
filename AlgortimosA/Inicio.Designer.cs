namespace AlgortimosA
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
            this.BotonP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonP
            // 
            this.BotonP.Location = new System.Drawing.Point(71, 53);
            this.BotonP.Name = "BotonP";
            this.BotonP.Size = new System.Drawing.Size(75, 23);
            this.BotonP.TabIndex = 0;
            this.BotonP.Text = "Pilas";
            this.BotonP.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonP);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonP;
    }
}