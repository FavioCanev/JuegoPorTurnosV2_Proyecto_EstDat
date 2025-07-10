namespace Interfaces
{
    partial class ResumenObjetos
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
            this.dgvTablaObjetos = new System.Windows.Forms.DataGridView();
            this.dgvNombreObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaObjetos
            // 
            this.dgvTablaObjetos.AllowUserToAddRows = false;
            this.dgvTablaObjetos.AllowUserToDeleteRows = false;
            this.dgvTablaObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombreObjeto,
            this.dgvTipoObjeto,
            this.dgvValorObjeto});
            this.dgvTablaObjetos.Location = new System.Drawing.Point(12, 12);
            this.dgvTablaObjetos.Name = "dgvTablaObjetos";
            this.dgvTablaObjetos.ReadOnly = true;
            this.dgvTablaObjetos.RowHeadersWidth = 51;
            this.dgvTablaObjetos.RowTemplate.Height = 24;
            this.dgvTablaObjetos.Size = new System.Drawing.Size(598, 409);
            this.dgvTablaObjetos.TabIndex = 0;
            // 
            // dgvNombreObjeto
            // 
            this.dgvNombreObjeto.HeaderText = "Objeto";
            this.dgvNombreObjeto.MinimumWidth = 6;
            this.dgvNombreObjeto.Name = "dgvNombreObjeto";
            this.dgvNombreObjeto.ReadOnly = true;
            this.dgvNombreObjeto.Width = 200;
            // 
            // dgvTipoObjeto
            // 
            this.dgvTipoObjeto.HeaderText = "Tipo";
            this.dgvTipoObjeto.MinimumWidth = 6;
            this.dgvTipoObjeto.Name = "dgvTipoObjeto";
            this.dgvTipoObjeto.ReadOnly = true;
            this.dgvTipoObjeto.Width = 75;
            // 
            // dgvValorObjeto
            // 
            this.dgvValorObjeto.HeaderText = "Valor";
            this.dgvValorObjeto.MinimumWidth = 6;
            this.dgvValorObjeto.Name = "dgvValorObjeto";
            this.dgvValorObjeto.ReadOnly = true;
            this.dgvValorObjeto.Width = 50;
            // 
            // ResumenObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.dgvTablaObjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResumenObjetos";
            this.Text = "ResumenObjetos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaObjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaObjetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorObjeto;
    }
}