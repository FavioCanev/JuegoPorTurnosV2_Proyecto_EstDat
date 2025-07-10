namespace Interfaces
{
    partial class FinJuego
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
            this.lblMensajeFinal = new System.Windows.Forms.Label();
            this.btnPilaAtaques = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeFinal
            // 
            this.lblMensajeFinal.AutoSize = true;
            this.lblMensajeFinal.Font = new System.Drawing.Font("OptimusPrinceps", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeFinal.Location = new System.Drawing.Point(76, 191);
            this.lblMensajeFinal.Name = "lblMensajeFinal";
            this.lblMensajeFinal.Size = new System.Drawing.Size(1108, 154);
            this.lblMensajeFinal.TabIndex = 0;
            this.lblMensajeFinal.Text = "¡Felicidades!\r\nHas derrotado a todos los bosses";
            this.lblMensajeFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPilaAtaques
            // 
            this.btnPilaAtaques.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPilaAtaques.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilaAtaques.Location = new System.Drawing.Point(24, 568);
            this.btnPilaAtaques.Name = "btnPilaAtaques";
            this.btnPilaAtaques.Size = new System.Drawing.Size(207, 78);
            this.btnPilaAtaques.TabIndex = 1;
            this.btnPilaAtaques.Text = "Historial de ataques";
            this.btnPilaAtaques.UseVisualStyleBackColor = false;
            this.btnPilaAtaques.Click += new System.EventHandler(this.btnPilaAtaques_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalir.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1027, 568);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 78);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OptimusPrinceps", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gracias por jugar <3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPilaAtaques);
            this.Controls.Add(this.lblMensajeFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinJuego";
            this.Text = "FinJuego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeFinal;
        private System.Windows.Forms.Button btnPilaAtaques;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}