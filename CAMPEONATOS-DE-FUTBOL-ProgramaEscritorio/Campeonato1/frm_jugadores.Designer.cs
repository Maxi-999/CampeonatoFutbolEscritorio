namespace Campeonato1
{
    partial class frm_jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jugadores));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_reemplazar = new System.Windows.Forms.Button();
            this.btn_sancionar = new System.Windows.Forms.Button();
            this.dgv_equipo = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_equipos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_escudo2 = new System.Windows.Forms.PictureBox();
            this.btn_equipo = new System.Windows.Forms.Button();
            this.lbl_jug_sancion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_jug_anota = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_escudo2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(54, 133);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(86, 84);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_reemplazar
            // 
            this.btn_reemplazar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reemplazar.Image")));
            this.btn_reemplazar.Location = new System.Drawing.Point(56, 221);
            this.btn_reemplazar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reemplazar.Name = "btn_reemplazar";
            this.btn_reemplazar.Size = new System.Drawing.Size(86, 84);
            this.btn_reemplazar.TabIndex = 1;
            this.btn_reemplazar.UseVisualStyleBackColor = true;
            // 
            // btn_sancionar
            // 
            this.btn_sancionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_sancionar.Image")));
            this.btn_sancionar.Location = new System.Drawing.Point(54, 309);
            this.btn_sancionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sancionar.Name = "btn_sancionar";
            this.btn_sancionar.Size = new System.Drawing.Size(86, 84);
            this.btn_sancionar.TabIndex = 2;
            this.btn_sancionar.UseVisualStyleBackColor = true;
            // 
            // dgv_equipo
            // 
            this.dgv_equipo.AllowUserToAddRows = false;
            this.dgv_equipo.AllowUserToDeleteRows = false;
            this.dgv_equipo.AllowUserToResizeRows = false;
            this.dgv_equipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgv_equipo.Location = new System.Drawing.Point(169, 133);
            this.dgv_equipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_equipo.Name = "dgv_equipo";
            this.dgv_equipo.ReadOnly = true;
            this.dgv_equipo.RowHeadersVisible = false;
            this.dgv_equipo.RowTemplate.Height = 24;
            this.dgv_equipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_equipo.Size = new System.Drawing.Size(495, 348);
            this.dgv_equipo.TabIndex = 4;
            // 
            // col1
            // 
            this.col1.HeaderText = "APELLIDO Y NOMBRE";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 250;
            // 
            // col2
            // 
            this.col2.HeaderText = "DNI";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "EDAD";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 60;
            // 
            // cmb_equipos
            // 
            this.cmb_equipos.FormattingEnabled = true;
            this.cmb_equipos.Location = new System.Drawing.Point(71, 35);
            this.cmb_equipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_equipos.Name = "cmb_equipos";
            this.cmb_equipos.Size = new System.Drawing.Size(173, 21);
            this.cmb_equipos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_escudo2);
            this.groupBox1.Controls.Add(this.btn_equipo);
            this.groupBox1.Controls.Add(this.lbl_jug_sancion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_jug_anota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_equipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_equipos);
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(665, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos equipo";
            // 
            // pic_escudo2
            // 
            this.pic_escudo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_escudo2.Image = ((System.Drawing.Image)(resources.GetObject("pic_escudo2.Image")));
            this.pic_escudo2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_escudo2.InitialImage")));
            this.pic_escudo2.Location = new System.Drawing.Point(549, 12);
            this.pic_escudo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_escudo2.Name = "pic_escudo2";
            this.pic_escudo2.Size = new System.Drawing.Size(112, 115);
            this.pic_escudo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_escudo2.TabIndex = 12;
            this.pic_escudo2.TabStop = false;
            // 
            // btn_equipo
            // 
            this.btn_equipo.Location = new System.Drawing.Point(170, 74);
            this.btn_equipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_equipo.Name = "btn_equipo";
            this.btn_equipo.Size = new System.Drawing.Size(74, 35);
            this.btn_equipo.TabIndex = 8;
            this.btn_equipo.Text = "Seleccionar Equipo";
            this.btn_equipo.UseVisualStyleBackColor = true;
            this.btn_equipo.Click += new System.EventHandler(this.btn_equipo_Click);
            // 
            // lbl_jug_sancion
            // 
            this.lbl_jug_sancion.AutoSize = true;
            this.lbl_jug_sancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jug_sancion.Location = new System.Drawing.Point(514, 96);
            this.lbl_jug_sancion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jug_sancion.Name = "lbl_jug_sancion";
            this.lbl_jug_sancion.Size = new System.Drawing.Size(15, 13);
            this.lbl_jug_sancion.TabIndex = 11;
            this.lbl_jug_sancion.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jugadores sancionados:";
            // 
            // lbl_jug_anota
            // 
            this.lbl_jug_anota.AutoSize = true;
            this.lbl_jug_anota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jug_anota.Location = new System.Drawing.Point(514, 57);
            this.lbl_jug_anota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jug_anota.Name = "lbl_jug_anota";
            this.lbl_jug_anota.Size = new System.Drawing.Size(15, 13);
            this.lbl_jug_anota.TabIndex = 9;
            this.lbl_jug_anota.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jugaforres anotados:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipo.Location = new System.Drawing.Point(377, 17);
            this.lbl_equipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(18, 17);
            this.lbl_equipo.TabIndex = 7;
            this.lbl_equipo.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipo";
            // 
            // btn_quitar
            // 
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(54, 397);
            this.btn_quitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(86, 84);
            this.btn_quitar.TabIndex = 7;
            this.btn_quitar.UseVisualStyleBackColor = true;
            // 
            // frm_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 492);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_equipo);
            this.Controls.Add(this.btn_sancionar);
            this.Controls.Add(this.btn_reemplazar);
            this.Controls.Add(this.btn_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frm_jugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Jugadores";
            this.Activated += new System.EventHandler(this.frm_jugadores_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_escudo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_reemplazar;
        private System.Windows.Forms.Button btn_sancionar;
        private System.Windows.Forms.DataGridView dgv_equipo;
        private System.Windows.Forms.ComboBox cmb_equipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_jug_sancion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_jug_anota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.PictureBox pic_escudo2;
    }
}