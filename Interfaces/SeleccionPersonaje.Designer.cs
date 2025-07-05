namespace Interfaces
{
    partial class SeleccionPersonaje
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_LineaSeparacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_NombrePersonaje = new System.Windows.Forms.Label();
            this.LB_ListaMovimientos = new System.Windows.Forms.Label();
            this.CB_CuadroDesplegablePersonajes = new System.Windows.Forms.ComboBox();
            this.DG_TablaAtaques = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_ClaseMostrar = new System.Windows.Forms.Label();
            this.LB_PuntosVidaMostrar = new System.Windows.Forms.Label();
            this.BT_Confirmar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.PB_Personaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TablaAtaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Personaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OptimusPrinceps", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1103, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccion de Personaje";
            // 
            // LB_LineaSeparacion
            // 
            this.LB_LineaSeparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_LineaSeparacion.Location = new System.Drawing.Point(0, 128);
            this.LB_LineaSeparacion.Name = "LB_LineaSeparacion";
            this.LB_LineaSeparacion.Size = new System.Drawing.Size(1265, 2);
            this.LB_LineaSeparacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clase :";
            // 
            // LB_NombrePersonaje
            // 
            this.LB_NombrePersonaje.AutoSize = true;
            this.LB_NombrePersonaje.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NombrePersonaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_NombrePersonaje.Location = new System.Drawing.Point(29, 203);
            this.LB_NombrePersonaje.Name = "LB_NombrePersonaje";
            this.LB_NombrePersonaje.Size = new System.Drawing.Size(82, 27);
            this.LB_NombrePersonaje.TabIndex = 4;
            this.LB_NombrePersonaje.Text = "PV      :";
            // 
            // LB_ListaMovimientos
            // 
            this.LB_ListaMovimientos.AutoSize = true;
            this.LB_ListaMovimientos.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ListaMovimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_ListaMovimientos.Location = new System.Drawing.Point(201, 238);
            this.LB_ListaMovimientos.Name = "LB_ListaMovimientos";
            this.LB_ListaMovimientos.Size = new System.Drawing.Size(259, 27);
            this.LB_ListaMovimientos.TabIndex = 6;
            this.LB_ListaMovimientos.Text = "Lista de Movimientos";
            // 
            // CB_CuadroDesplegablePersonajes
            // 
            this.CB_CuadroDesplegablePersonajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_CuadroDesplegablePersonajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CuadroDesplegablePersonajes.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CuadroDesplegablePersonajes.FormattingEnabled = true;
            this.CB_CuadroDesplegablePersonajes.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CB_CuadroDesplegablePersonajes.Location = new System.Drawing.Point(717, 167);
            this.CB_CuadroDesplegablePersonajes.Name = "CB_CuadroDesplegablePersonajes";
            this.CB_CuadroDesplegablePersonajes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CB_CuadroDesplegablePersonajes.Size = new System.Drawing.Size(492, 31);
            this.CB_CuadroDesplegablePersonajes.TabIndex = 7;
            this.CB_CuadroDesplegablePersonajes.SelectedIndexChanged += new System.EventHandler(this.CB_CuadroDesplegablePersonajes_SelectedIndexChanged);
            // 
            // DG_TablaAtaques
            // 
            this.DG_TablaAtaques.AllowUserToAddRows = false;
            this.DG_TablaAtaques.AllowUserToDeleteRows = false;
            this.DG_TablaAtaques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TablaAtaques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Daño});
            this.DG_TablaAtaques.Location = new System.Drawing.Point(33, 268);
            this.DG_TablaAtaques.Name = "DG_TablaAtaques";
            this.DG_TablaAtaques.ReadOnly = true;
            this.DG_TablaAtaques.RowHeadersWidth = 51;
            this.DG_TablaAtaques.RowTemplate.Height = 24;
            this.DG_TablaAtaques.Size = new System.Drawing.Size(609, 320);
            this.DG_TablaAtaques.TabIndex = 8;
            // 
            // Nombre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 330;
            // 
            // Daño
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Daño.DefaultCellStyle = dataGridViewCellStyle2;
            this.Daño.HeaderText = "Daño";
            this.Daño.MinimumWidth = 6;
            this.Daño.Name = "Daño";
            this.Daño.ReadOnly = true;
            this.Daño.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Daño.Width = 73;
            // 
            // LB_ClaseMostrar
            // 
            this.LB_ClaseMostrar.AutoSize = true;
            this.LB_ClaseMostrar.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ClaseMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_ClaseMostrar.Location = new System.Drawing.Point(131, 167);
            this.LB_ClaseMostrar.Name = "LB_ClaseMostrar";
            this.LB_ClaseMostrar.Size = new System.Drawing.Size(27, 27);
            this.LB_ClaseMostrar.TabIndex = 10;
            this.LB_ClaseMostrar.Text = "...";
            // 
            // LB_PuntosVidaMostrar
            // 
            this.LB_PuntosVidaMostrar.AutoSize = true;
            this.LB_PuntosVidaMostrar.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PuntosVidaMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_PuntosVidaMostrar.Location = new System.Drawing.Point(131, 203);
            this.LB_PuntosVidaMostrar.Name = "LB_PuntosVidaMostrar";
            this.LB_PuntosVidaMostrar.Size = new System.Drawing.Size(27, 27);
            this.LB_PuntosVidaMostrar.TabIndex = 11;
            this.LB_PuntosVidaMostrar.Text = "...";
            // 
            // BT_Confirmar
            // 
            this.BT_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Confirmar.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Confirmar.Location = new System.Drawing.Point(528, 604);
            this.BT_Confirmar.Name = "BT_Confirmar";
            this.BT_Confirmar.Size = new System.Drawing.Size(213, 44);
            this.BT_Confirmar.TabIndex = 12;
            this.BT_Confirmar.Text = "CONFIRMAR";
            this.BT_Confirmar.UseVisualStyleBackColor = true;
            this.BT_Confirmar.Click += new System.EventHandler(this.BT_Confirmar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("OptimusPrincepsSemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(33, 604);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(213, 44);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.BT_Atras_Click);
            // 
            // PB_Personaje
            // 
            this.PB_Personaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Personaje.ImageLocation = "";
            this.PB_Personaje.Location = new System.Drawing.Point(768, 194);
            this.PB_Personaje.Name = "PB_Personaje";
            this.PB_Personaje.Size = new System.Drawing.Size(376, 467);
            this.PB_Personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Personaje.TabIndex = 9;
            this.PB_Personaje.TabStop = false;
            // 
            // SeleccionPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.BT_Confirmar);
            this.Controls.Add(this.LB_PuntosVidaMostrar);
            this.Controls.Add(this.LB_ClaseMostrar);
            this.Controls.Add(this.DG_TablaAtaques);
            this.Controls.Add(this.CB_CuadroDesplegablePersonajes);
            this.Controls.Add(this.LB_ListaMovimientos);
            this.Controls.Add(this.LB_NombrePersonaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_LineaSeparacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Personaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionPersonaje";
            ((System.ComponentModel.ISupportInitialize)(this.DG_TablaAtaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Personaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_LineaSeparacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_NombrePersonaje;
        private System.Windows.Forms.Label LB_ListaMovimientos;
        private System.Windows.Forms.DataGridView DG_TablaAtaques;
        private System.Windows.Forms.Label LB_ClaseMostrar;
        private System.Windows.Forms.Label LB_PuntosVidaMostrar;
        private System.Windows.Forms.Button BT_Confirmar;
        private System.Windows.Forms.ComboBox CB_CuadroDesplegablePersonajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox PB_Personaje;
    }
}