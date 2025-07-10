namespace Interfaces
{
    partial class Combate
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
            this.components = new System.ComponentModel.Container();
            this.pbPersonajeCombate = new System.Windows.Forms.PictureBox();
            this.pbBossCombate = new System.Windows.Forms.PictureBox();
            this.lblNombreBoss = new System.Windows.Forms.Label();
            this.lblNombrePersonaje = new System.Windows.Forms.Label();
            this.lblVidaPersonaje = new System.Windows.Forms.Label();
            this.lblNombreZona = new System.Windows.Forms.Label();
            this.btnVerObjetos = new System.Windows.Forms.Button();
            this.btnAtaque1 = new System.Windows.Forms.Button();
            this.btnAtaque2 = new System.Windows.Forms.Button();
            this.btnAtaque3 = new System.Windows.Forms.Button();
            this.btnAtaque4 = new System.Windows.Forms.Button();
            this.pgrbrBarraVidaBoss = new System.Windows.Forms.ProgressBar();
            this.pgrbrBarraVidaPersonaje = new System.Windows.Forms.ProgressBar();
            this.lblVidaBoss = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timerBoss = new System.Windows.Forms.Timer(this.components);
            this.timerPersonaje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonajeCombate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBossCombate)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPersonajeCombate
            // 
            this.pbPersonajeCombate.Location = new System.Drawing.Point(853, 129);
            this.pbPersonajeCombate.Name = "pbPersonajeCombate";
            this.pbPersonajeCombate.Size = new System.Drawing.Size(387, 406);
            this.pbPersonajeCombate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonajeCombate.TabIndex = 0;
            this.pbPersonajeCombate.TabStop = false;
            // 
            // pbBossCombate
            // 
            this.pbBossCombate.Location = new System.Drawing.Point(12, 129);
            this.pbBossCombate.Name = "pbBossCombate";
            this.pbBossCombate.Size = new System.Drawing.Size(387, 406);
            this.pbBossCombate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBossCombate.TabIndex = 1;
            this.pbBossCombate.TabStop = false;
            // 
            // lblNombreBoss
            // 
            this.lblNombreBoss.AutoSize = true;
            this.lblNombreBoss.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBoss.Location = new System.Drawing.Point(6, 27);
            this.lblNombreBoss.Name = "lblNombreBoss";
            this.lblNombreBoss.Size = new System.Drawing.Size(202, 35);
            this.lblNombreBoss.TabIndex = 2;
            this.lblNombreBoss.Text = "Nombre Boss";
            // 
            // lblNombrePersonaje
            // 
            this.lblNombrePersonaje.AutoSize = true;
            this.lblNombrePersonaje.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersonaje.Location = new System.Drawing.Point(847, 27);
            this.lblNombrePersonaje.Name = "lblNombrePersonaje";
            this.lblNombrePersonaje.Size = new System.Drawing.Size(287, 35);
            this.lblNombrePersonaje.TabIndex = 4;
            this.lblNombrePersonaje.Text = "Nombre Personaje";
            // 
            // lblVidaPersonaje
            // 
            this.lblVidaPersonaje.AutoSize = true;
            this.lblVidaPersonaje.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaPersonaje.Location = new System.Drawing.Point(847, 62);
            this.lblVidaPersonaje.Name = "lblVidaPersonaje";
            this.lblVidaPersonaje.Size = new System.Drawing.Size(208, 35);
            this.lblVidaPersonaje.TabIndex = 5;
            this.lblVidaPersonaje.Text = "PV Personaje";
            // 
            // lblNombreZona
            // 
            this.lblNombreZona.AutoSize = true;
            this.lblNombreZona.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreZona.Location = new System.Drawing.Point(853, 552);
            this.lblNombreZona.Name = "lblNombreZona";
            this.lblNombreZona.Size = new System.Drawing.Size(224, 35);
            this.lblNombreZona.TabIndex = 6;
            this.lblNombreZona.Text = "Nombre Zona";
            // 
            // btnVerObjetos
            // 
            this.btnVerObjetos.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerObjetos.Location = new System.Drawing.Point(475, 24);
            this.btnVerObjetos.Name = "btnVerObjetos";
            this.btnVerObjetos.Size = new System.Drawing.Size(299, 99);
            this.btnVerObjetos.TabIndex = 7;
            this.btnVerObjetos.Text = "Ver objetos";
            this.btnVerObjetos.UseVisualStyleBackColor = true;
            this.btnVerObjetos.Click += new System.EventHandler(this.btnVerObjetos_Click);
            // 
            // btnAtaque1
            // 
            this.btnAtaque1.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque1.Location = new System.Drawing.Point(425, 492);
            this.btnAtaque1.Name = "btnAtaque1";
            this.btnAtaque1.Size = new System.Drawing.Size(192, 66);
            this.btnAtaque1.TabIndex = 8;
            this.btnAtaque1.Text = "Atq 1";
            this.btnAtaque1.UseVisualStyleBackColor = true;
            this.btnAtaque1.Click += new System.EventHandler(this.btnAtaque1_Click);
            // 
            // btnAtaque2
            // 
            this.btnAtaque2.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque2.Location = new System.Drawing.Point(640, 492);
            this.btnAtaque2.Name = "btnAtaque2";
            this.btnAtaque2.Size = new System.Drawing.Size(192, 66);
            this.btnAtaque2.TabIndex = 9;
            this.btnAtaque2.Text = "Atq 2";
            this.btnAtaque2.UseVisualStyleBackColor = true;
            this.btnAtaque2.Click += new System.EventHandler(this.btnAtaque2_Click);
            // 
            // btnAtaque3
            // 
            this.btnAtaque3.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque3.Location = new System.Drawing.Point(425, 579);
            this.btnAtaque3.Name = "btnAtaque3";
            this.btnAtaque3.Size = new System.Drawing.Size(192, 66);
            this.btnAtaque3.TabIndex = 10;
            this.btnAtaque3.Text = "Atq 3";
            this.btnAtaque3.UseVisualStyleBackColor = true;
            this.btnAtaque3.Click += new System.EventHandler(this.btnAtaque3_Click);
            // 
            // btnAtaque4
            // 
            this.btnAtaque4.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque4.Location = new System.Drawing.Point(640, 579);
            this.btnAtaque4.Name = "btnAtaque4";
            this.btnAtaque4.Size = new System.Drawing.Size(192, 66);
            this.btnAtaque4.TabIndex = 11;
            this.btnAtaque4.Text = "Atq 4";
            this.btnAtaque4.UseVisualStyleBackColor = true;
            this.btnAtaque4.Click += new System.EventHandler(this.btnAtaque4_Click);
            // 
            // pgrbrBarraVidaBoss
            // 
            this.pgrbrBarraVidaBoss.Location = new System.Drawing.Point(12, 100);
            this.pgrbrBarraVidaBoss.Name = "pgrbrBarraVidaBoss";
            this.pgrbrBarraVidaBoss.Size = new System.Drawing.Size(387, 23);
            this.pgrbrBarraVidaBoss.TabIndex = 12;
            // 
            // pgrbrBarraVidaPersonaje
            // 
            this.pgrbrBarraVidaPersonaje.Location = new System.Drawing.Point(853, 100);
            this.pgrbrBarraVidaPersonaje.Name = "pgrbrBarraVidaPersonaje";
            this.pgrbrBarraVidaPersonaje.Size = new System.Drawing.Size(387, 23);
            this.pgrbrBarraVidaPersonaje.TabIndex = 13;
            // 
            // lblVidaBoss
            // 
            this.lblVidaBoss.AutoSize = true;
            this.lblVidaBoss.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaBoss.Location = new System.Drawing.Point(6, 62);
            this.lblVidaBoss.Name = "lblVidaBoss";
            this.lblVidaBoss.Size = new System.Drawing.Size(123, 35);
            this.lblVidaBoss.TabIndex = 14;
            this.lblVidaBoss.Text = "PV Boss";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 595);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 66);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Combate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVidaBoss);
            this.Controls.Add(this.pgrbrBarraVidaPersonaje);
            this.Controls.Add(this.pgrbrBarraVidaBoss);
            this.Controls.Add(this.btnAtaque4);
            this.Controls.Add(this.btnAtaque3);
            this.Controls.Add(this.btnAtaque2);
            this.Controls.Add(this.btnAtaque1);
            this.Controls.Add(this.btnVerObjetos);
            this.Controls.Add(this.lblNombreZona);
            this.Controls.Add(this.lblVidaPersonaje);
            this.Controls.Add(this.lblNombrePersonaje);
            this.Controls.Add(this.lblNombreBoss);
            this.Controls.Add(this.pbBossCombate);
            this.Controls.Add(this.pbPersonajeCombate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Combate";
            this.Text = "Combate";
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonajeCombate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBossCombate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonajeCombate;
        private System.Windows.Forms.PictureBox pbBossCombate;
        private System.Windows.Forms.Label lblNombreBoss;
        private System.Windows.Forms.Label lblNombrePersonaje;
        private System.Windows.Forms.Label lblVidaPersonaje;
        private System.Windows.Forms.Label lblNombreZona;
        private System.Windows.Forms.Button btnVerObjetos;
        private System.Windows.Forms.Button btnAtaque1;
        private System.Windows.Forms.Button btnAtaque2;
        private System.Windows.Forms.Button btnAtaque3;
        private System.Windows.Forms.Button btnAtaque4;
        private System.Windows.Forms.ProgressBar pgrbrBarraVidaBoss;
        private System.Windows.Forms.ProgressBar pgrbrBarraVidaPersonaje;
        private System.Windows.Forms.Label lblVidaBoss;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer timerBoss;
        private System.Windows.Forms.Timer timerPersonaje;
    }
}