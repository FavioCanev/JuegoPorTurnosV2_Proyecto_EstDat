namespace Interfaces
{
    partial class HistorialAtaques
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
            this.dgvHistorialAtaques = new System.Windows.Forms.DataGridView();
            this.dgvNombreAtaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAtaques)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialAtaques
            // 
            this.dgvHistorialAtaques.AllowUserToAddRows = false;
            this.dgvHistorialAtaques.AllowUserToDeleteRows = false;
            this.dgvHistorialAtaques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialAtaques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombreAtaque,
            this.dgvDano});
            this.dgvHistorialAtaques.Location = new System.Drawing.Point(12, 12);
            this.dgvHistorialAtaques.Name = "dgvHistorialAtaques";
            this.dgvHistorialAtaques.ReadOnly = true;
            this.dgvHistorialAtaques.RowHeadersWidth = 51;
            this.dgvHistorialAtaques.RowTemplate.Height = 24;
            this.dgvHistorialAtaques.Size = new System.Drawing.Size(776, 426);
            this.dgvHistorialAtaques.TabIndex = 0;
            // 
            // dgvNombreAtaque
            // 
            this.dgvNombreAtaque.HeaderText = "Nombre del ataque";
            this.dgvNombreAtaque.MinimumWidth = 6;
            this.dgvNombreAtaque.Name = "dgvNombreAtaque";
            this.dgvNombreAtaque.ReadOnly = true;
            this.dgvNombreAtaque.Width = 450;
            // 
            // dgvDano
            // 
            this.dgvDano.HeaderText = "Daño";
            this.dgvDano.MinimumWidth = 6;
            this.dgvDano.Name = "dgvDano";
            this.dgvDano.ReadOnly = true;
            this.dgvDano.Width = 75;
            // 
            // HistorialAtaques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistorialAtaques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistorialAtaques";
            this.Text = "Historial de Ataques";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAtaques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialAtaques;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreAtaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDano;
    }
}