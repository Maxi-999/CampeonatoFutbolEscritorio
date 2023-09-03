namespace Campeonato1
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquipoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDePosicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeSancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem,
            this.sorteoToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem1,
            this.agregarJugadorToolStripMenuItem});
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.agregarEquipoToolStripMenuItem.Text = "Comenzar";
            // 
            // agregarEquipoToolStripMenuItem1
            // 
            this.agregarEquipoToolStripMenuItem1.Name = "agregarEquipoToolStripMenuItem1";
            this.agregarEquipoToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.agregarEquipoToolStripMenuItem1.Text = "Agregar equipo";
            this.agregarEquipoToolStripMenuItem1.Click += new System.EventHandler(this.agregarEquipoToolStripMenuItem1_Click);
            // 
            // agregarJugadorToolStripMenuItem
            // 
            this.agregarJugadorToolStripMenuItem.Name = "agregarJugadorToolStripMenuItem";
            this.agregarJugadorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.agregarJugadorToolStripMenuItem.Text = "Gestionar jugadores";
            this.agregarJugadorToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadorToolStripMenuItem_Click);
            // 
            // sorteoToolStripMenuItem
            // 
            this.sorteoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteoToolStripMenuItem1});
            this.sorteoToolStripMenuItem.Name = "sorteoToolStripMenuItem";
            this.sorteoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sorteoToolStripMenuItem.Text = "Sorteo";
            // 
            // sorteoToolStripMenuItem1
            // 
            this.sorteoToolStripMenuItem1.Name = "sorteoToolStripMenuItem1";
            this.sorteoToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.sorteoToolStripMenuItem1.Text = "Sorteo ";
            this.sorteoToolStripMenuItem1.Click += new System.EventHandler(this.sorteoToolStripMenuItem1_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDePosicionesToolStripMenuItem,
            this.cargaDeResultadosToolStripMenuItem,
            this.cargaDeSancionesToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // tablaDePosicionesToolStripMenuItem
            // 
            this.tablaDePosicionesToolStripMenuItem.Name = "tablaDePosicionesToolStripMenuItem";
            this.tablaDePosicionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tablaDePosicionesToolStripMenuItem.Text = "Tabla de posiciones";
            this.tablaDePosicionesToolStripMenuItem.Click += new System.EventHandler(this.tablaDePosicionesToolStripMenuItem_Click);
            // 
            // cargaDeResultadosToolStripMenuItem
            // 
            this.cargaDeResultadosToolStripMenuItem.Name = "cargaDeResultadosToolStripMenuItem";
            this.cargaDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargaDeResultadosToolStripMenuItem.Text = "Carga de resultados";
            // 
            // cargaDeSancionesToolStripMenuItem
            // 
            this.cargaDeSancionesToolStripMenuItem.Name = "cargaDeSancionesToolStripMenuItem";
            this.cargaDeSancionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargaDeSancionesToolStripMenuItem.Text = "Carga de sanciones";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(832, 537);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(93, 32);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Salir";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 574);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campeonato Amateur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ToolStripMenuItem sorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDePosicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeSancionesToolStripMenuItem;
    }
}